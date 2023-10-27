namespace BibliotecaProyectoAC
{
    partial class AnadirLibros
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
            this.TxtISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSinopsis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUnidades = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAñadirLibro = new System.Windows.Forms.Button();
            this.TxtAutores = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnAnadirAutor = new System.Windows.Forms.Button();
            this.BtnBuscarAutor = new System.Windows.Forms.Button();
            this.DataCategorias = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PrestableSi = new System.Windows.Forms.RadioButton();
            this.PrestableNo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtISBN
            // 
            this.TxtISBN.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtISBN.Location = new System.Drawing.Point(43, 75);
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.Size = new System.Drawing.Size(220, 27);
            this.TxtISBN.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISBN";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.Location = new System.Drawing.Point(43, 162);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(220, 27);
            this.TxtTitulo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titulo";
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEditorial.Location = new System.Drawing.Point(43, 251);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(220, 27);
            this.TxtEditorial.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Editorial";
            // 
            // TxtSinopsis
            // 
            this.TxtSinopsis.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSinopsis.Location = new System.Drawing.Point(291, 164);
            this.TxtSinopsis.Name = "TxtSinopsis";
            this.TxtSinopsis.Size = new System.Drawing.Size(220, 27);
            this.TxtSinopsis.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sinopsis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Caratula";
            // 
            // TxtUnidades
            // 
            this.TxtUnidades.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnidades.Location = new System.Drawing.Point(291, 75);
            this.TxtUnidades.Name = "TxtUnidades";
            this.TxtUnidades.Size = new System.Drawing.Size(220, 27);
            this.TxtUnidades.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unidades";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Categoria";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BtnAñadirLibro
            // 
            this.BtnAñadirLibro.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnAñadirLibro.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAñadirLibro.ForeColor = System.Drawing.Color.White;
            this.BtnAñadirLibro.Location = new System.Drawing.Point(647, 383);
            this.BtnAñadirLibro.Name = "BtnAñadirLibro";
            this.BtnAñadirLibro.Size = new System.Drawing.Size(205, 109);
            this.BtnAñadirLibro.TabIndex = 16;
            this.BtnAñadirLibro.Text = "Añadir Libro";
            this.BtnAñadirLibro.UseVisualStyleBackColor = false;
            this.BtnAñadirLibro.Click += new System.EventHandler(this.BtnAñadirLibro_Click);
            // 
            // TxtAutores
            // 
            this.TxtAutores.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAutores.Location = new System.Drawing.Point(550, 75);
            this.TxtAutores.Name = "TxtAutores";
            this.TxtAutores.Size = new System.Drawing.Size(302, 27);
            this.TxtAutores.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(548, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Autor";
            // 
            // BtnAnadirAutor
            // 
            this.BtnAnadirAutor.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnAnadirAutor.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnadirAutor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAnadirAutor.Location = new System.Drawing.Point(550, 108);
            this.BtnAnadirAutor.Name = "BtnAnadirAutor";
            this.BtnAnadirAutor.Size = new System.Drawing.Size(148, 32);
            this.BtnAnadirAutor.TabIndex = 19;
            this.BtnAnadirAutor.Text = "Añadir Autor";
            this.BtnAnadirAutor.UseVisualStyleBackColor = false;
            // 
            // BtnBuscarAutor
            // 
            this.BtnBuscarAutor.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnBuscarAutor.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarAutor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBuscarAutor.Location = new System.Drawing.Point(704, 108);
            this.BtnBuscarAutor.Name = "BtnBuscarAutor";
            this.BtnBuscarAutor.Size = new System.Drawing.Size(148, 32);
            this.BtnBuscarAutor.TabIndex = 20;
            this.BtnBuscarAutor.Text = "Buscar Autor";
            this.BtnBuscarAutor.UseVisualStyleBackColor = false;
            // 
            // DataCategorias
            // 
            this.DataCategorias.AllowUserToAddRows = false;
            this.DataCategorias.AllowUserToDeleteRows = false;
            this.DataCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCategorias.Location = new System.Drawing.Point(44, 342);
            this.DataCategorias.Name = "DataCategorias";
            this.DataCategorias.ReadOnly = true;
            this.DataCategorias.Size = new System.Drawing.Size(283, 150);
            this.DataCategorias.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(179, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 27);
            this.button3.TabIndex = 22;
            this.button3.Text = "Crear Categoría";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(291, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 27);
            this.button1.TabIndex = 23;
            this.button1.Text = "Buscar Caratula";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(355, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(546, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Prestable";
            // 
            // PrestableSi
            // 
            this.PrestableSi.AutoSize = true;
            this.PrestableSi.Location = new System.Drawing.Point(552, 201);
            this.PrestableSi.Name = "PrestableSi";
            this.PrestableSi.Size = new System.Drawing.Size(34, 17);
            this.PrestableSi.TabIndex = 26;
            this.PrestableSi.TabStop = true;
            this.PrestableSi.Text = "Si";
            this.PrestableSi.UseVisualStyleBackColor = true;
            this.PrestableSi.CheckedChanged += new System.EventHandler(this.PrestableSi_CheckedChanged);
            // 
            // PrestableNo
            // 
            this.PrestableNo.AutoSize = true;
            this.PrestableNo.Location = new System.Drawing.Point(552, 224);
            this.PrestableNo.Name = "PrestableNo";
            this.PrestableNo.Size = new System.Drawing.Size(39, 17);
            this.PrestableNo.TabIndex = 27;
            this.PrestableNo.TabStop = true;
            this.PrestableNo.Text = "No";
            this.PrestableNo.UseVisualStyleBackColor = true;
            this.PrestableNo.CheckedChanged += new System.EventHandler(this.PrestableNo_CheckedChanged);
            // 
            // AnadirLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 519);
            this.Controls.Add(this.PrestableNo);
            this.Controls.Add(this.PrestableSi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DataCategorias);
            this.Controls.Add(this.BtnBuscarAutor);
            this.Controls.Add(this.BtnAnadirAutor);
            this.Controls.Add(this.TxtAutores);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnAñadirLibro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtUnidades);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSinopsis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtEditorial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtISBN);
            this.Controls.Add(this.label1);
            this.Name = "AnadirLibros";
            this.Text = "AnadirLibros";
            this.Load += new System.EventHandler(this.AnadirLibros_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DataCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSinopsis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtUnidades;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnAñadirLibro;
        private System.Windows.Forms.TextBox TxtAutores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnAnadirAutor;
        private System.Windows.Forms.Button BtnBuscarAutor;
        private System.Windows.Forms.DataGridView DataCategorias;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton PrestableSi;
        private System.Windows.Forms.RadioButton PrestableNo;
    }
}