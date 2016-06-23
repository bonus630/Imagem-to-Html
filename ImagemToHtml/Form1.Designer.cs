namespace ImagemToHtml
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
            this.img_preview = new System.Windows.Forms.PictureBox();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_converter = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_color = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scale = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_navegador = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale)).BeginInit();
            this.SuspendLayout();
            // 
            // img_preview
            // 
            this.img_preview.Location = new System.Drawing.Point(-3, 0);
            this.img_preview.Name = "img_preview";
            this.img_preview.Size = new System.Drawing.Size(827, 500);
            this.img_preview.TabIndex = 0;
            this.img_preview.TabStop = false;
            // 
            // btn_abrir
            // 
            this.btn_abrir.Location = new System.Drawing.Point(8, 505);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(44, 23);
            this.btn_abrir.TabIndex = 1;
            this.btn_abrir.Text = "Abrir";
            this.btn_abrir.UseVisualStyleBackColor = true;
            this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.ReadOnlyChecked = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.ShowReadOnly = true;
            this.openFileDialog1.Title = "Selecione uma Imagem";
            // 
            // btn_converter
            // 
            this.btn_converter.Enabled = false;
            this.btn_converter.Location = new System.Drawing.Point(58, 505);
            this.btn_converter.Name = "btn_converter";
            this.btn_converter.Size = new System.Drawing.Size(62, 23);
            this.btn_converter.TabIndex = 2;
            this.btn_converter.Text = "Converter";
            this.btn_converter.UseVisualStyleBackColor = true;
            this.btn_converter.Click += new System.EventHandler(this.btn_converter_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.White;
            this.btn_color.Location = new System.Drawing.Point(176, 505);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(30, 23);
            this.btn_color.TabIndex = 3;
            this.btn_color.Text = " ";
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // scale
            // 
            this.scale.Location = new System.Drawing.Point(255, 506);
            this.scale.Name = "scale";
            this.scale.Size = new System.Drawing.Size(38, 20);
            this.scale.TabIndex = 5;
            this.scale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scale.ValueChanged += new System.EventHandler(this.scale_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bg Color";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Scale";
            // 
            // cb_navegador
            // 
            this.cb_navegador.AutoSize = true;
            this.cb_navegador.Location = new System.Drawing.Point(299, 507);
            this.cb_navegador.Name = "cb_navegador";
            this.cb_navegador.Size = new System.Drawing.Size(136, 17);
            this.cb_navegador.TabIndex = 8;
            this.cb_navegador.Text = "Mostrar no navegador?";
            this.cb_navegador.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 532);
            this.Controls.Add(this.cb_navegador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.btn_converter);
            this.Controls.Add(this.btn_abrir);
            this.Controls.Add(this.img_preview);
            this.Name = "Form1";
            this.Text = "Sou imagem? Não sou html!";
            ((System.ComponentModel.ISupportInitialize)(this.img_preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_preview;
        private System.Windows.Forms.Button btn_abrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_converter;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown scale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_navegador;
    }
}

