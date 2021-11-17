
namespace TP3
{
    partial class FormEstadistica
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
            this.lstboxEstadisticas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstboxEstadisticas
            // 
            this.lstboxEstadisticas.BackColor = System.Drawing.Color.CadetBlue;
            this.lstboxEstadisticas.FormattingEnabled = true;
            this.lstboxEstadisticas.ItemHeight = 20;
            this.lstboxEstadisticas.Location = new System.Drawing.Point(40, 25);
            this.lstboxEstadisticas.Name = "lstboxEstadisticas";
            this.lstboxEstadisticas.Size = new System.Drawing.Size(682, 404);
            this.lstboxEstadisticas.TabIndex = 0;
            // 
            // FormEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.lstboxEstadisticas);
            this.Name = "FormEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FormEstadistica_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxEstadisticas;
    }
}