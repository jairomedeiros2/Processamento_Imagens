namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pb_Original = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbl_high = new System.Windows.Forms.Label();
            this.trackBar_High = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar_low = new System.Windows.Forms.TrackBar();
            this.btn_RealceLinear = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tb_High = new System.Windows.Forms.Label();
            this.lbl_tb_Low = new System.Windows.Forms.Label();
            this.rb_ImagemColorida = new System.Windows.Forms.RadioButton();
            this.rb_ImagemCinza = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pb_Exponencial = new System.Windows.Forms.PictureBox();
            this.pb_Logaritmico = new System.Windows.Forms.PictureBox();
            this.pb_Gama = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pb_Linear = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pb_Histog_Linear = new System.Windows.Forms.PictureBox();
            this.pb_Histog_Exponencial = new System.Windows.Forms.PictureBox();
            this.pb_Histog_Logaritmico = new System.Windows.Forms.PictureBox();
            this.pb_Histog_Gama = new System.Windows.Forms.PictureBox();
            this.pb_Histog_Original = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_Linear = new System.Windows.Forms.CheckBox();
            this.cb_Exponencial = new System.Windows.Forms.CheckBox();
            this.cb_Logaritmico = new System.Windows.Forms.CheckBox();
            this.cb_Gama = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_High)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_low)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exponencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logaritmico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Linear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histog_Linear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histog_Exponencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histog_Logaritmico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histog_Gama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histog_Original)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pb_Original
            // 
            this.pb_Original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Original.Location = new System.Drawing.Point(33, 413);
            this.pb_Original.Name = "pb_Original";
            this.pb_Original.Size = new System.Drawing.Size(300, 200);
            this.pb_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Original.TabIndex = 1;
            this.pb_Original.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "gray";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "salt & peper";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "hist eq";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_high
            // 
            this.lbl_high.AutoSize = true;
            this.lbl_high.Location = new System.Drawing.Point(172, 230);
            this.lbl_high.Name = "lbl_high";
            this.lbl_high.Size = new System.Drawing.Size(34, 13);
            this.lbl_high.TabIndex = 5;
            this.lbl_high.Text = "HIGH";
            // 
            // trackBar_High
            // 
            this.trackBar_High.Location = new System.Drawing.Point(176, 247);
            this.trackBar_High.Maximum = 255;
            this.trackBar_High.Name = "trackBar_High";
            this.trackBar_High.Size = new System.Drawing.Size(157, 45);
            this.trackBar_High.TabIndex = 6;
            this.trackBar_High.Value = 255;
            //this.trackBar_High.Scroll += new System.EventHandler(this.TrackBar_high_Scroll);
            this.trackBar_High.ValueChanged += new System.EventHandler(this.TrackBar_High_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "LOW";
            // 
            // trackBar_low
            // 
            this.trackBar_low.Location = new System.Drawing.Point(13, 247);
            this.trackBar_low.Maximum = 255;
            this.trackBar_low.Name = "trackBar_low";
            this.trackBar_low.Size = new System.Drawing.Size(157, 45);
            this.trackBar_low.TabIndex = 8;
           // this.trackBar_low.Scroll += new System.EventHandler(this.TrackBar_low_Scroll);
            this.trackBar_low.ValueChanged += new System.EventHandler(this.TrackBar_low_ValueChanged);
            // 
            // btn_RealceLinear
            // 
            this.btn_RealceLinear.Location = new System.Drawing.Point(10, 165);
            this.btn_RealceLinear.Name = "btn_RealceLinear";
            this.btn_RealceLinear.Size = new System.Drawing.Size(75, 23);
            this.btn_RealceLinear.TabIndex = 9;
            this.btn_RealceLinear.Text = "Linear";
            this.btn_RealceLinear.UseVisualStyleBackColor = true;
            this.btn_RealceLinear.Click += new System.EventHandler(this.Btn_RealceLinear_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(91, 165);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Exponencial";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(172, 165);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Logaritmico";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(253, 165);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Gama";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Realce";
            // 
            // lbl_tb_High
            // 
            this.lbl_tb_High.AutoSize = true;
            this.lbl_tb_High.Location = new System.Drawing.Point(254, 230);
            this.lbl_tb_High.Name = "lbl_tb_High";
            this.lbl_tb_High.Size = new System.Drawing.Size(25, 13);
            this.lbl_tb_High.TabIndex = 11;
            this.lbl_tb_High.Text = "255";
            // 
            // lbl_tb_Low
            // 
            this.lbl_tb_Low.AutoSize = true;
            this.lbl_tb_Low.Location = new System.Drawing.Point(91, 231);
            this.lbl_tb_Low.Name = "lbl_tb_Low";
            this.lbl_tb_Low.Size = new System.Drawing.Size(13, 13);
            this.lbl_tb_Low.TabIndex = 14;
            this.lbl_tb_Low.Text = "0";
            // 
            // rb_ImagemColorida
            // 
            this.rb_ImagemColorida.AutoSize = true;
            this.rb_ImagemColorida.Checked = true;
            this.rb_ImagemColorida.Location = new System.Drawing.Point(16, 317);
            this.rb_ImagemColorida.Name = "rb_ImagemColorida";
            this.rb_ImagemColorida.Size = new System.Drawing.Size(63, 17);
            this.rb_ImagemColorida.TabIndex = 15;
            this.rb_ImagemColorida.TabStop = true;
            this.rb_ImagemColorida.Text = "Colorido";
            this.rb_ImagemColorida.UseVisualStyleBackColor = true;
            // 
            // rb_ImagemCinza
            // 
            this.rb_ImagemCinza.AutoSize = true;
            this.rb_ImagemCinza.Location = new System.Drawing.Point(16, 341);
            this.rb_ImagemCinza.Name = "rb_ImagemCinza";
            this.rb_ImagemCinza.Size = new System.Drawing.Size(51, 17);
            this.rb_ImagemCinza.TabIndex = 16;
            this.rb_ImagemCinza.Text = "Cinza";
            this.rb_ImagemCinza.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Imagem";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "2",
            "3",
            "4",
            "5",
            "50",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(91, 316);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Tag = "";
            this.comboBox1.Text = "1";
            // 
            // pb_Exponencial
            // 
            this.pb_Exponencial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Exponencial.Location = new System.Drawing.Point(665, 52);
            this.pb_Exponencial.Name = "pb_Exponencial";
            this.pb_Exponencial.Size = new System.Drawing.Size(300, 200);
            this.pb_Exponencial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Exponencial.TabIndex = 1;
            this.pb_Exponencial.TabStop = false;
            // 
            // pb_Logaritmico
            // 
            this.pb_Logaritmico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Logaritmico.Location = new System.Drawing.Point(359, 413);
            this.pb_Logaritmico.Name = "pb_Logaritmico";
            this.pb_Logaritmico.Size = new System.Drawing.Size(300, 200);
            this.pb_Logaritmico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logaritmico.TabIndex = 1;
            this.pb_Logaritmico.TabStop = false;
            // 
            // pb_Gama
            // 
            this.pb_Gama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Gama.Location = new System.Drawing.Point(665, 413);
            this.pb_Gama.Name = "pb_Gama";
            this.pb_Gama.Size = new System.Drawing.Size(300, 200);
            this.pb_Gama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Gama.TabIndex = 1;
            this.pb_Gama.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Linear";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(790, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Exponencial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Logaritmico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(790, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Gama";
            // 
            // pb_Linear
            // 
            this.pb_Linear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Linear.Location = new System.Drawing.Point(359, 52);
            this.pb_Linear.Name = "pb_Linear";
            this.pb_Linear.Size = new System.Drawing.Size(300, 200);
            this.pb_Linear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Linear.TabIndex = 1;
            this.pb_Linear.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Original";
            // 
            // pb_Histog_Linear
            // 
            this.pb_Histog_Linear.Location = new System.Drawing.Point(385, 258);
            this.pb_Histog_Linear.Name = "pb_Histog_Linear";
            this.pb_Histog_Linear.Size = new System.Drawing.Size(256, 100);
            this.pb_Histog_Linear.TabIndex = 18;
            this.pb_Histog_Linear.TabStop = false;
            // 
            // pb_Histog_Exponencial
            // 
            this.pb_Histog_Exponencial.Location = new System.Drawing.Point(686, 258);
            this.pb_Histog_Exponencial.Name = "pb_Histog_Exponencial";
            this.pb_Histog_Exponencial.Size = new System.Drawing.Size(256, 100);
            this.pb_Histog_Exponencial.TabIndex = 18;
            this.pb_Histog_Exponencial.TabStop = false;
            // 
            // pb_Histog_Logaritmico
            // 
            this.pb_Histog_Logaritmico.Location = new System.Drawing.Point(385, 621);
            this.pb_Histog_Logaritmico.Name = "pb_Histog_Logaritmico";
            this.pb_Histog_Logaritmico.Size = new System.Drawing.Size(256, 100);
            this.pb_Histog_Logaritmico.TabIndex = 18;
            this.pb_Histog_Logaritmico.TabStop = false;
            // 
            // pb_Histog_Gama
            // 
            this.pb_Histog_Gama.Location = new System.Drawing.Point(686, 621);
            this.pb_Histog_Gama.Name = "pb_Histog_Gama";
            this.pb_Histog_Gama.Size = new System.Drawing.Size(256, 100);
            this.pb_Histog_Gama.TabIndex = 18;
            this.pb_Histog_Gama.TabStop = false;
            // 
            // pb_Histog_Original
            // 
            this.pb_Histog_Original.Location = new System.Drawing.Point(55, 621);
            this.pb_Histog_Original.Name = "pb_Histog_Original";
            this.pb_Histog_Original.Size = new System.Drawing.Size(256, 100);
            this.pb_Histog_Original.TabIndex = 18;
            this.pb_Histog_Original.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nível de Gama";
            // 
            // cb_Linear
            // 
            this.cb_Linear.AutoSize = true;
            this.cb_Linear.Location = new System.Drawing.Point(12, 194);
            this.cb_Linear.Name = "cb_Linear";
            this.cb_Linear.Size = new System.Drawing.Size(55, 17);
            this.cb_Linear.TabIndex = 21;
            this.cb_Linear.Text = "Linear";
            this.cb_Linear.UseVisualStyleBackColor = true;
            // 
            // cb_Exponencial
            // 
            this.cb_Exponencial.AutoSize = true;
            this.cb_Exponencial.Location = new System.Drawing.Point(91, 194);
            this.cb_Exponencial.Name = "cb_Exponencial";
            this.cb_Exponencial.Size = new System.Drawing.Size(84, 17);
            this.cb_Exponencial.TabIndex = 21;
            this.cb_Exponencial.Text = "Exponencial";
            this.cb_Exponencial.UseVisualStyleBackColor = true;
            // 
            // cb_Logaritmico
            // 
            this.cb_Logaritmico.AutoSize = true;
            this.cb_Logaritmico.Location = new System.Drawing.Point(172, 194);
            this.cb_Logaritmico.Name = "cb_Logaritmico";
            this.cb_Logaritmico.Size = new System.Drawing.Size(80, 17);
            this.cb_Logaritmico.TabIndex = 21;
            this.cb_Logaritmico.Text = "Logaritmico";
            this.cb_Logaritmico.UseVisualStyleBackColor = true;
            // 
            // cb_Gama
            // 
            this.cb_Gama.AutoSize = true;
            this.cb_Gama.Location = new System.Drawing.Point(253, 194);
            this.cb_Gama.Name = "cb_Gama";
            this.cb_Gama.Size = new System.Drawing.Size(54, 17);
            this.cb_Gama.TabIndex = 21;
            this.cb_Gama.Text = "Gama";
            this.cb_Gama.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 733);
            this.Controls.Add(this.cb_Gama);
            this.Controls.Add(this.cb_Logaritmico);
            this.Controls.Add(this.cb_Exponencial);
            this.Controls.Add(this.cb_Linear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pb_Histog_Gama);
            this.Controls.Add(this.pb_Histog_Logaritmico);
            this.Controls.Add(this.pb_Histog_Exponencial);
            this.Controls.Add(this.pb_Histog_Linear);
            this.Controls.Add(this.pb_Histog_Original);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_ImagemCinza);
            this.Controls.Add(this.rb_ImagemColorida);
            this.Controls.Add(this.lbl_tb_Low);
            this.Controls.Add(this.lbl_tb_High);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_RealceLinear);
            this.Controls.Add(this.trackBar_low);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar_High);
            this.Controls.Add(this.lbl_high);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pb_Gama);
            this.Controls.Add(this.pb_Logaritmico);
            this.Controls.Add(this.pb_Exponencial);
            this.Controls.Add(this.pb_Linear);
            this.Controls.Add(this.pb_Original);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Processamento de Imagem V03";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_High)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_low)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exponencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logaritmico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Linear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histog_Linear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histog_Exponencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histog_Logaritmico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histog_Gama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histog_Original)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pb_Original;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_high;
        private System.Windows.Forms.TrackBar trackBar_High;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar_low;
        private System.Windows.Forms.Button btn_RealceLinear;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tb_High;
        private System.Windows.Forms.Label lbl_tb_Low;
        private System.Windows.Forms.RadioButton rb_ImagemColorida;
        private System.Windows.Forms.RadioButton rb_ImagemCinza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pb_Exponencial;
        private System.Windows.Forms.PictureBox pb_Logaritmico;
        private System.Windows.Forms.PictureBox pb_Gama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pb_Linear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pb_Histog_Linear;
        private System.Windows.Forms.PictureBox pb_Histog_Exponencial;
        private System.Windows.Forms.PictureBox pb_Histog_Logaritmico;
        private System.Windows.Forms.PictureBox pb_Histog_Gama;
        private System.Windows.Forms.PictureBox pb_Histog_Original;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cb_Linear;
        private System.Windows.Forms.CheckBox cb_Exponencial;
        private System.Windows.Forms.CheckBox cb_Logaritmico;
        private System.Windows.Forms.CheckBox cb_Gama;
    }
}

