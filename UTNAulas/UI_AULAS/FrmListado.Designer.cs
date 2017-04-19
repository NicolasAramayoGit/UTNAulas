namespace UI_AULAS
{
    partial class FrmListado
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
            this.lstListado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstListado
            // 
            this.lstListado.FormattingEnabled = true;
            this.lstListado.Location = new System.Drawing.Point(32, 45);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(316, 186);
            this.lstListado.TabIndex = 0;
            // 
            // FrmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 273);
            this.Controls.Add(this.lstListado);
            this.Name = "FrmListado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.FrmListado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstListado;
    }
}