namespace BibliotecaProyectoAC
{
    partial class PrestarLibro
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
            this.button3 = new System.Windows.Forms.Button();
            this.TxtDevolucion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrestamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DataUsuarios = new System.Windows.Forms.DataGridView();
            this.DataLibro = new System.Windows.Forms.DataGridView();
            this.BtnBuscarLibro = new System.Windows.Forms.Button();
            this.TxtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1037, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 86);
            this.button3.TabIndex = 42;
            this.button3.Text = "Prestar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TxtDevolucion
            // 
            this.TxtDevolucion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDevolucion.Location = new System.Drawing.Point(16, 408);
            this.TxtDevolucion.Name = "TxtDevolucion";
            this.TxtDevolucion.Size = new System.Drawing.Size(250, 27);
            this.TxtDevolucion.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(449, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Fecha Devolución (Por Defecto 15 Dias Más a la de Prestamo)";
            // 
            // TxtPrestamo
            // 
            this.TxtPrestamo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrestamo.Location = new System.Drawing.Point(16, 305);
            this.TxtPrestamo.Name = "TxtPrestamo";
            this.TxtPrestamo.Size = new System.Drawing.Size(250, 27);
            this.TxtPrestamo.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Fecha Prestamo (Por Defecto Hoy)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(225, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(394, 27);
            this.button2.TabIndex = 37;
            this.button2.Text = "Dar Alta";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnBuscar.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(506, 48);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(113, 30);
            this.BtnBuscar.TabIndex = 36;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // DataUsuarios
            // 
            this.DataUsuarios.AllowUserToAddRows = false;
            this.DataUsuarios.AllowUserToDeleteRows = false;
            this.DataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataUsuarios.Location = new System.Drawing.Point(16, 96);
            this.DataUsuarios.Name = "DataUsuarios";
            this.DataUsuarios.ReadOnly = true;
            this.DataUsuarios.Size = new System.Drawing.Size(603, 150);
            this.DataUsuarios.TabIndex = 35;
            // 
            // DataLibro
            // 
            this.DataLibro.AllowUserToAddRows = false;
            this.DataLibro.AllowUserToDeleteRows = false;
            this.DataLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataLibro.Location = new System.Drawing.Point(650, 96);
            this.DataLibro.Name = "DataLibro";
            this.DataLibro.ReadOnly = true;
            this.DataLibro.Size = new System.Drawing.Size(561, 150);
            this.DataLibro.TabIndex = 34;
            // 
            // BtnBuscarLibro
            // 
            this.BtnBuscarLibro.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnBuscarLibro.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarLibro.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarLibro.Location = new System.Drawing.Point(1111, 48);
            this.BtnBuscarLibro.Name = "BtnBuscarLibro";
            this.BtnBuscarLibro.Size = new System.Drawing.Size(100, 30);
            this.BtnBuscarLibro.TabIndex = 33;
            this.BtnBuscarLibro.Text = "Buscar";
            this.BtnBuscarLibro.UseVisualStyleBackColor = false;
            // 
            // TxtISBN
            // 
            this.TxtISBN.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtISBN.Location = new System.Drawing.Point(650, 51);
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.Size = new System.Drawing.Size(455, 27);
            this.TxtISBN.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(646, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Buscar Libro (ISBN)";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.Location = new System.Drawing.Point(16, 49);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(484, 27);
            this.txtCarnet.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Identificate (Num. Carnet)";
            // 
            // PrestarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 490);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TxtDevolucion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPrestamo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.DataUsuarios);
            this.Controls.Add(this.DataLibro);
            this.Controls.Add(this.BtnBuscarLibro);
            this.Controls.Add(this.TxtISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.label1);
            this.Name = "PrestarLibro";
            this.Text = "PrestarLibro";
            ((System.ComponentModel.ISupportInitialize)(this.DataUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TxtDevolucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView DataUsuarios;
        private System.Windows.Forms.DataGridView DataLibro;
        private System.Windows.Forms.Button BtnBuscarLibro;
        private System.Windows.Forms.TextBox TxtISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label label1;
    }
}