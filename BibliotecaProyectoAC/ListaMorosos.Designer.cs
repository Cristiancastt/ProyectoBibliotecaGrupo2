namespace BibliotecaProyectoAC
{
    partial class ListaMorosos
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
            this.DataMorosos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataMorosos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataMorosos
            // 
            this.DataMorosos.AllowUserToAddRows = false;
            this.DataMorosos.AllowUserToDeleteRows = false;
            this.DataMorosos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMorosos.Location = new System.Drawing.Point(79, 81);
            this.DataMorosos.Name = "DataMorosos";
            this.DataMorosos.ReadOnly = true;
            this.DataMorosos.Size = new System.Drawing.Size(635, 332);
            this.DataMorosos.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 33);
            this.label2.TabIndex = 32;
            this.label2.Text = "Lista Morosos";
            // 
            // ListaMorosos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataMorosos);
            this.Name = "ListaMorosos";
            this.Text = "ListaMorosos";
            this.Load += new System.EventHandler(this.ListaMorosos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataMorosos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataMorosos;
        private System.Windows.Forms.Label label2;
    }
}