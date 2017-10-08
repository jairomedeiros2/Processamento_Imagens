using System;
using System.Drawing;
using System.Windows.Forms;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Bitmap bmp_aux;
        Bitmap bmp_Linear;
        Bitmap bmp_Exponencial;
        Bitmap bmp_Logaritmico;
        Bitmap bmp_Gama;
        Bitmap histograma;
        //Bitmap pb_Histog_Linear;
        //Bitmap pb_Histog_Exponencial;
        //Bitmap pb_Histog_Logaritmico;
        //Bitmap pb_Histog_Gama;
        Bitmap histograma_aux;

        double[] colorTable = new double[256];
        int colorR, colorG, colorB;      // para o Imagemcolor()
        int[] frequencia = new int[256]; // para o histograma
        int max = 0, escala = 0, op=0;   // Para o histograma
       
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedValue = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //programar abrir imagem
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(openFileDialog1.FileName);
                pb_Original.Image = bmp;
                bmp_aux = new Bitmap(bmp);
                 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Grayscale gray = new Grayscale(.3, .59, .11);
            bmp = new Bitmap(Grayscale.CommonAlgorithms.BT709.Apply(bmp));
            pb_Original.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaltAndPepperNoise noise = new SaltAndPepperNoise(100);
            noise.ApplyInPlace(bmp);
            pb_Original.Image = bmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Equalização de Histograma
            HistogramEqualization hq = new HistogramEqualization();
            hq.ApplyInPlace(bmp);
            pb_Original.Image = bmp;
        }
        
        void Imagemcolor(Color k, double[] colorTable, int x, int y)
        {
            if (rb_ImagemColorida.Checked) {
                //Color k = bmp.GetPixel(x, y);     // Pega o Pixel da imagem
                colorR = k.R;
                colorG = k.G;
                colorB = k.B;
                colorR = (int)colorTable[colorR];
                colorG = (int)colorTable[colorG];
                colorB = (int)colorTable[colorB];
                bmp_aux.SetPixel(x, y, Color.FromArgb(colorR, colorG, colorB));
            }
            else if (rb_ImagemCinza.Checked)
            {
                int gray = (k.R + k.G + k.B) / 3; // Pega os valores dos pixels e transforma na escala de cinza 
                gray = (int)colorTable[gray];   // 
                frequencia[gray] += 1; // para o histograma
                bmp_aux.SetPixel(x, y, Color.FromArgb(gray, gray, gray)); //Pinta o Pixel ccom Gray2               
            }
        }

        protected Bitmap CopyBitmap(Bitmap source)
        {
            return new Bitmap(source);
        }

        /* Falta fazer o histograma funcionar para RGB tbm */
        void Tb_histograma(int op)
        {
            histograma_aux = new Bitmap(256, 100);

            for (int i = 0; i < 256; i++) //estava no ImageColor*
            {
                if (frequencia[i] > max) max = frequencia[i];
            }

            for (int x = 0; x < histograma_aux.Width - 1; x++)
            {
                for (int y = 0; y < histograma_aux.Height - 1; y++)
                {
                    escala = (int)(Math.Log10(frequencia[x]) * 100 / Math.Log10(max));
                    int z = 0;
                    while (z < escala)
                    {
                        histograma_aux.SetPixel(x, z, Color.FromArgb(100, 100, 100));
                        z++;
                    }
                }
            }

            if      (op == 1) pb_Histog_Linear.Image = histograma_aux;
            else if (op == 2) pb_Histog_Exponencial.Image = histograma_aux;
            else if (op == 3) pb_Histog_Exponencial.Image = histograma_aux;
            else if (op == 4) pb_Histog_Gama.Image = histograma_aux;
            else              pb_Histog_Original.Image = histograma;
        }

        void Realce_Linear()
        {
            //op = 1; // Opção 1 = Linear

            bmp_aux = CopyBitmap(bmp); // Copia o Bitmap
            pb_Linear.Image = bmp_aux;
            int high = (int)trackBar_High.Value, low = (int)trackBar_low.Value; //max e min
            
            int intVal;
            double a, b;
            int range = high - low; //alcance 
            a = 255.0 / range;
            b = -a * low;

            for (int x = 0; x < 256; ++x) //Realce linear
            {
                if (x <= low)
                    colorTable[x] = 0;
                else if (x > high)
                    colorTable[x] = 255;
                else
                {
                    intVal = Convert.ToInt32(a * x + b);
                    if (intVal > 255) intVal = 255;
                    if (intVal < 0) intVal = 0;
                    colorTable[x] = (byte)intVal;
                }
            }

        }
        void Realce_Logaritmico()
        {
            bmp_aux = CopyBitmap(bmp); // Copia o Bitmap pra toda mudança de basear no Bitmap original e não no já modificado
            pb_Logaritmico.Image = bmp_aux; //Desenha bmp_aux no pb
            int high = (int)trackBar_High.Value, low = (int)trackBar_low.Value; //max e min
       
            double a, b;
            double lHigh = Math.Log10(high + 1.0);
            double lLow = Math.Log10(low + 1.0);
            double range = lHigh - lLow;

            a = 255.0 / range;
            b = -a * lLow;
            int intVal;
            for (int i = 0; i < 256; ++i)
            {
                if (i <= low)
                    colorTable[i] = 0;
                else if (i > high)
                    colorTable[i] = 255;
                else
                {
                    intVal = Convert.ToInt32(a * Math.Log10(i + 1) + b);
                    if (intVal > 255) intVal = 255;
                    if (intVal < 0) intVal = 0;
                    colorTable[i] = (byte)intVal;
                }
            }
        }       
        void Realce_Exponencial()
        {
            bmp_aux = CopyBitmap(bmp); // Copia o Bitmap
            pb_Exponencial.Image = bmp_aux;
            int high = (int)trackBar_High.Value, low = (int)trackBar_low.Value; //max e min

            double scale1 = Math.Log10(256.0) / 255.0;
            double a, b;
            a = Math.Exp(scale1 * low) - 1.0;
            b = Math.Exp(scale1 * high) - 1.0;
            double scale2 = 255.0 / (b - a);
            int intVal;
            for (int i = 0; i < 256; ++i)
            {
                if (i <= low)
                    colorTable[i] = 0;
                else if (i > high)
                    colorTable[i] = 255;
                else
                {
                    intVal = Convert.ToInt32(Math.Round(scale2 * (Math.Exp(scale1
                   * i) - 1.0 - a)));
                    if (intVal > 255) intVal = 255;
                    if (intVal < 0) intVal = 0;
                    colorTable[i] = (byte)intVal;
                }
            }
        }
        void Realce_Gama()
        {
            bmp_aux = CopyBitmap(bmp); // Copia o Bitmap
            pb_Gama.Image = bmp_aux;
            int high = (int)trackBar_High.Value, low = (int)trackBar_low.Value; //max e min
            
            double gamma = Convert.ToDouble(comboBox1.Text);
          
            double a, b;

            a = Math.Pow(low, gamma);
            b = Math.Pow(high, gamma);
            double scale = 255.0 / (b - a);
            int intVal;
            for (int i = 0; i < 256; ++i)
            {
                if (i <= low)
                    colorTable[i] = 0;
                else if (i > high)
                    colorTable[i] = 255;
                else
                {
                    intVal = Convert.ToInt32(Math.Round(scale * (Math.Pow(i,
                   gamma) - a)));
                    if (intVal > 255) intVal = 255;
                    if (intVal < 0) intVal = 0;
                    colorTable[i] = (byte)intVal;
                }
            }
            // Colorir_PictureBox(4); 
        }

        void Colorir_PictureBox(int op)
        {
            for (int x = 0; x < bmp_aux.Width; x++)
            {
            //for (int y = 0; y < bmp.Height -1; y++)
                for (int y = 0; y < bmp_aux.Height; y++)
                {
                    Color k = bmp_aux.GetPixel(x, y);     // Pega o Pixel da imagem
                    Imagemcolor(k, colorTable, x, y);
                }
               // pb_Original.Refresh();
            }

            if (op == 1)      { pb_Linear.Refresh();      }
            else if (op == 2) { pb_Exponencial.Refresh(); }
            else if (op == 3) { pb_Logaritmico.Refresh(); }
            else if (op == 4) { pb_Gama.Refresh();        }

            Tb_histograma(op);        
        }

        void Button7_Click(object sender, EventArgs e) { Realce_Logaritmico(); Colorir_PictureBox(3); } //
        void button8_Click(object sender, EventArgs e) { Realce_Gama();        Colorir_PictureBox(4); } //
        void Button6_Click(object sender, EventArgs e) { Realce_Exponencial(); Colorir_PictureBox(2); } //
        void Btn_RealceLinear_Click(object sender, EventArgs e) { Realce_Linear(); Colorir_PictureBox(1); }//

        //Se mover o TrackBar
        private void TrackBar_low_ValueChanged(object sender, EventArgs e)
        {
            TrackBar myTrackBar_Low;
            myTrackBar_Low = (TrackBar)sender;
            lbl_tb_Low.Text = myTrackBar_Low.Value.ToString();

            if (cb_Linear.Checked) {
                Realce_Linear();
                Colorir_PictureBox(1);
            }

            if (cb_Exponencial.Checked)
            {
                Realce_Exponencial();
                Colorir_PictureBox(2);
            }

            if (cb_Logaritmico.Checked)
            {
                Realce_Logaritmico();
                Colorir_PictureBox(3);
            }

            if (cb_Gama.Checked)
            {
                Realce_Gama();
                Colorir_PictureBox(4);
            }            
        }
        private void TrackBar_High_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTrackBar_High;
            myTrackBar_High = (System.Windows.Forms.TrackBar)sender;
            lbl_tb_High.Text = myTrackBar_High.Value.ToString(); //Mostra o valor do TrackBar_High na label

            if (cb_Linear.Checked)
            {
                Realce_Linear();
                Colorir_PictureBox(1);
            } 

            if (cb_Exponencial.Checked)
            {
                Realce_Exponencial();
                Colorir_PictureBox(2);
            }

            if (cb_Logaritmico.Checked)
            {
                Realce_Logaritmico();
                Colorir_PictureBox(3);
            }

            if (cb_Gama.Checked)
            {
                Realce_Gama();
                Colorir_PictureBox(4);
            }
        }
       
   
        
    }
}
