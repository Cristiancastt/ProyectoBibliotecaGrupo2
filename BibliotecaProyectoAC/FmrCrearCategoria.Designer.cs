namespace BibliotecaProyectoAC
{
    partial class FmrCrearCategoria
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
            this.BtnCrearCategoria = new System.Windows.Forms.Button();
            this.TxtNombreCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCrearCategoria
            // 
            this.BtnCrearCategoria.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnCrearCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCategoria.ForeColor = System.Drawing.Color.White;
            this.BtnCrearCategoria.Location = new System.Drawing.Point(421, 165);
            this.BtnCrearCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCrearCategoria.Name = "BtnCrearCategoria";
            this.BtnCrearCategoria.Size = new System.Drawing.Size(197, 74);
            this.BtnCrearCategoria.TabIndex = 20;
            this.BtnCrearCategoria.Text = "Crear Categoría";
            this.BtnCrearCategoria.UseVisualStyleBackColor = false;
            this.BtnCrearCategoria.Click += new System.EventHandler(this.BtnEliminarLibro_Click);
            // 
            // TxtNombreCategoria
            // 
            this.TxtNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCategoria.Location = new System.Drawing.Point(75, 106);
            this.TxtNombreCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNombreCategoria.Name = "TxtNombreCategoria";
            this.TxtNombreCategoria.Size = new System.Drawing.Size(936, 30);
            this.TxtNombreCategoria.TabIndex = 19;
            this.TxtNombreCategoria.TextChanged += new System.EventHandler(this.TxtNombreCategoria_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Descripción";
            // 
            // CrearCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 274);
            this.Controls.Add(this.BtnCrearCategoria);
            this.Controls.Add(this.TxtNombreCategoria);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CrearCategoria";
            this.Text = "CrearCategoria";
            this.Load += new System.EventHandler(this.CrearCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCrearCategoria;
        private System.Windows.Forms.TextBox TxtNombreCategoria;
        private System.Windows.Forms.Label label1;
    }
}