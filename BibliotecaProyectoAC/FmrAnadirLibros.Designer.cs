namespace BibliotecaProyectoAC
{
    partial class FrmAnadirLibro
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
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAñadirLibro = new System.Windows.Forms.Button();
            this.txtAutores = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAnadirAutor = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnCrearCategoria = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBuscarCaratula = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PrestableSi = new System.Windows.Forms.RadioButton();
            this.PrestableNo = new System.Windows.Forms.RadioButton();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(43, 75);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(220, 26);
            this.txtISBN.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISBN";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(43, 162);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(220, 26);
            this.txtTitulo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titulo";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.Location = new System.Drawing.Point(43, 251);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(220, 26);
            this.txtEditorial.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Editorial";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinopsis.Location = new System.Drawing.Point(291, 164);
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(220, 26);
            this.txtSinopsis.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sinopsis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Caratula";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidades.Location = new System.Drawing.Point(291, 75);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(220, 26);
            this.txtUnidades.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unidades";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Categoria";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnAñadirLibro
            // 
            this.btnAñadirLibro.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAñadirLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirLibro.ForeColor = System.Drawing.Color.White;
            this.btnAñadirLibro.Location = new System.Drawing.Point(647, 383);
            this.btnAñadirLibro.Name = "btnAñadirLibro";
            this.btnAñadirLibro.Size = new System.Drawing.Size(205, 109);
            this.btnAñadirLibro.TabIndex = 16;
            this.btnAñadirLibro.Text = "Añadir Libro";
            this.btnAñadirLibro.UseVisualStyleBackColor = false;
            this.btnAñadirLibro.Click += new System.EventHandler(this.BtnAñadirLibro_Click);
            // 
            // txtAutores
            // 
            this.txtAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutores.Location = new System.Drawing.Point(550, 75);
            this.txtAutores.Name = "txtAutores";
            this.txtAutores.Size = new System.Drawing.Size(302, 26);
            this.txtAutores.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(548, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Autor";
            // 
            // btnAnadirAutor
            // 
            this.btnAnadirAutor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAnadirAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirAutor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnadirAutor.Location = new System.Drawing.Point(550, 108);
            this.btnAnadirAutor.Name = "btnAnadirAutor";
            this.btnAnadirAutor.Size = new System.Drawing.Size(148, 32);
            this.btnAnadirAutor.TabIndex = 19;
            this.btnAnadirAutor.Text = "Añadir Autor";
            this.btnAnadirAutor.UseVisualStyleBackColor = false;
            this.btnAnadirAutor.Click += new System.EventHandler(this.BtnAnadirAutor_Click);
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAutor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarAutor.Location = new System.Drawing.Point(704, 108);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(148, 32);
            this.btnBuscarAutor.TabIndex = 20;
            this.btnBuscarAutor.Text = "Buscar Autor";
            this.btnBuscarAutor.UseVisualStyleBackColor = false;
            this.btnBuscarAutor.Click += new System.EventHandler(this.BtnBuscarAutor_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(44, 342);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.Size = new System.Drawing.Size(283, 150);
            this.dgvCategorias.TabIndex = 21;
            // 
            // btnCrearCategoria
            // 
            this.btnCrearCategoria.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCrearCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCrearCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearCategoria.Location = new System.Drawing.Point(267, 311);
            this.btnCrearCategoria.Name = "btnCrearCategoria";
            this.btnCrearCategoria.Size = new System.Drawing.Size(148, 27);
            this.btnCrearCategoria.TabIndex = 22;
            this.btnCrearCategoria.Text = "Crear Categoría";
            this.btnCrearCategoria.UseVisualStyleBackColor = false;
            this.btnCrearCategoria.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBuscarCaratula
            // 
            this.btnBuscarCaratula.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarCaratula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCaratula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCaratula.Location = new System.Drawing.Point(291, 251);
            this.btnBuscarCaratula.Name = "btnBuscarCaratula";
            this.btnBuscarCaratula.Size = new System.Drawing.Size(220, 27);
            this.btnBuscarCaratula.TabIndex = 23;
            this.btnBuscarCaratula.Text = "Buscar Caratula";
            this.btnBuscarCaratula.UseVisualStyleBackColor = false;
            this.btnBuscarCaratula.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(354, 342);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(546, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
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
            // dgvAutores
            // 
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Location = new System.Drawing.Point(628, 162);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.Size = new System.Drawing.Size(240, 150);
            this.dgvAutores.TabIndex = 28;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(135, 311);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(116, 26);
            this.txtCategoria.TabIndex = 29;
            // 
            // FrmAnadirLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 519);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.dgvAutores);
            this.Controls.Add(this.PrestableNo);
            this.Controls.Add(this.PrestableSi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuscarCaratula);
            this.Controls.Add(this.btnCrearCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnBuscarAutor);
            this.Controls.Add(this.btnAnadirAutor);
            this.Controls.Add(this.txtAutores);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAñadirLibro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSinopsis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label1);
            this.Name = "FrmAnadirLibro";
            this.Text = "AnadirLibros";
            this.Load += new System.EventHandler(this.AnadirLibros_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAñadirLibro;
        private System.Windows.Forms.TextBox txtAutores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAnadirAutor;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnCrearCategoria;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBuscarCaratula;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton PrestableSi;
        private System.Windows.Forms.RadioButton PrestableNo;
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.TextBox txtCategoria;
    }
}