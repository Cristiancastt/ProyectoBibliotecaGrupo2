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
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscarLibro = new System.Windows.Forms.Button();
            this.DataLibro = new System.Windows.Forms.DataGridView();
            this.DataUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtPrestamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDevolucion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCarnet
            // 
            this.txtCarnet.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.Location = new System.Drawing.Point(32, 63);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(484, 27);
            this.txtCarnet.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Identificate (Num. Carnet)";
            // 
            // TxtISBN
            // 
            this.TxtISBN.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtISBN.Location = new System.Drawing.Point(666, 65);
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.Size = new System.Drawing.Size(455, 27);
            this.TxtISBN.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(662, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Buscar Libro (ISBN)";
            // 
            // BtnBuscarLibro
            // 
            this.BtnBuscarLibro.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnBuscarLibro.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarLibro.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarLibro.Location = new System.Drawing.Point(1127, 62);
            this.BtnBuscarLibro.Name = "BtnBuscarLibro";
            this.BtnBuscarLibro.Size = new System.Drawing.Size(100, 30);
            this.BtnBuscarLibro.TabIndex = 18;
            this.BtnBuscarLibro.Text = "Buscar";
            this.BtnBuscarLibro.UseVisualStyleBackColor = false;
            this.BtnBuscarLibro.Click += new System.EventHandler(this.BtnEliminarLibro_Click);
            // 
            // DataLibro
            // 
            this.DataLibro.AllowUserToAddRows = false;
            this.DataLibro.AllowUserToDeleteRows = false;
            this.DataLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataLibro.Location = new System.Drawing.Point(666, 110);
            this.DataLibro.Name = "DataLibro";
            this.DataLibro.ReadOnly = true;
            this.DataLibro.Size = new System.Drawing.Size(561, 150);
            this.DataLibro.TabIndex = 20;
            // 
            // DataUsuarios
            // 
            this.DataUsuarios.AllowUserToAddRows = false;
            this.DataUsuarios.AllowUserToDeleteRows = false;
            this.DataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataUsuarios.Location = new System.Drawing.Point(32, 110);
            this.DataUsuarios.Name = "DataUsuarios";
            this.DataUsuarios.ReadOnly = true;
            this.DataUsuarios.Size = new System.Drawing.Size(603, 150);
            this.DataUsuarios.TabIndex = 21;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnBuscar.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(522, 62);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(113, 30);
            this.BtnBuscar.TabIndex = 22;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(241, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(394, 27);
            this.button2.TabIndex = 23;
            this.button2.Text = "Dar Alta";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtPrestamo
            // 
            this.TxtPrestamo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrestamo.Location = new System.Drawing.Point(32, 319);
            this.TxtPrestamo.Name = "TxtPrestamo";
            this.TxtPrestamo.Size = new System.Drawing.Size(250, 27);
            this.TxtPrestamo.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Fecha Prestamo (Por Defecto Hoy)";
            // 
            // TxtDevolucion
            // 
            this.TxtDevolucion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDevolucion.Location = new System.Drawing.Point(32, 422);
            this.TxtDevolucion.Name = "TxtDevolucion";
            this.TxtDevolucion.Size = new System.Drawing.Size(250, 27);
            this.TxtDevolucion.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(449, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fecha Devolución (Por Defecto 15 Dias Más a la de Prestamo)";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1053, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 86);
            this.button3.TabIndex = 28;
            this.button3.Text = "Prestar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PrestarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 504);
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
            ((System.ComponentModel.ISupportInitialize)(this.DataLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscarLibro;
        private System.Windows.Forms.DataGridView DataLibro;
        private System.Windows.Forms.DataGridView DataUsuarios;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtPrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDevolucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}