
namespace TP3
{
    partial class FormBusqueda
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
            this.dataGridBusqueda = new System.Windows.Forms.DataGridView();
            this.btnVender = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnCatRevistas = new System.Windows.Forms.RadioButton();
            this.rbtnCatComics = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBusqueda
            // 
            this.dataGridBusqueda.AllowUserToDeleteRows = false;
            this.dataGridBusqueda.AllowUserToOrderColumns = true;
            this.dataGridBusqueda.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBusqueda.Location = new System.Drawing.Point(12, 62);
            this.dataGridBusqueda.Name = "dataGridBusqueda";
            this.dataGridBusqueda.RowHeadersWidth = 51;
            this.dataGridBusqueda.RowTemplate.Height = 29;
            this.dataGridBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBusqueda.Size = new System.Drawing.Size(1177, 507);
            this.dataGridBusqueda.TabIndex = 0;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.CadetBlue;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVender.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVender.Location = new System.Drawing.Point(931, 597);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(258, 64);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "ELIMINAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // rbtnCatRevistas
            // 
            this.rbtnCatRevistas.AutoSize = true;
            this.rbtnCatRevistas.Checked = true;
            this.rbtnCatRevistas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnCatRevistas.Location = new System.Drawing.Point(12, 22);
            this.rbtnCatRevistas.Name = "rbtnCatRevistas";
            this.rbtnCatRevistas.Size = new System.Drawing.Size(181, 24);
            this.rbtnCatRevistas.TabIndex = 3;
            this.rbtnCatRevistas.TabStop = true;
            this.rbtnCatRevistas.Text = "CATALOGO REVISTAS";
            this.rbtnCatRevistas.UseVisualStyleBackColor = true;
            this.rbtnCatRevistas.Visible = false;
            this.rbtnCatRevistas.CheckedChanged += new System.EventHandler(this.rbtnCatRevistas_CheckedChanged);
            // 
            // rbtnCatComics
            // 
            this.rbtnCatComics.AutoSize = true;
            this.rbtnCatComics.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnCatComics.Location = new System.Drawing.Point(199, 22);
            this.rbtnCatComics.Name = "rbtnCatComics";
            this.rbtnCatComics.Size = new System.Drawing.Size(169, 24);
            this.rbtnCatComics.TabIndex = 4;
            this.rbtnCatComics.Text = "CATALOGO COMICS";
            this.rbtnCatComics.UseVisualStyleBackColor = true;
            this.rbtnCatComics.Visible = false;
            this.rbtnCatComics.CheckedChanged += new System.EventHandler(this.rbtnCatComics_CheckedChanged);
            // 
            // FormBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1204, 673);
            this.Controls.Add(this.rbtnCatComics);
            this.Controls.Add(this.rbtnCatRevistas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.dataGridBusqueda);
            this.Name = "FormBusqueda";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBusqueda;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnCatRevistas;
        private System.Windows.Forms.RadioButton rbtnCatComics;
    }
}