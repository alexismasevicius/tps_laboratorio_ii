
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
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVender = new System.Windows.Forms.Button();
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
            this.dataGridBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Titulo,
            this.Autor,
            this.Tema,
            this.Genero,
            this.Pais,
            this.Año,
            this.Stock});
            this.dataGridBusqueda.Location = new System.Drawing.Point(12, 26);
            this.dataGridBusqueda.Name = "dataGridBusqueda";
            this.dataGridBusqueda.RowHeadersWidth = 51;
            this.dataGridBusqueda.RowTemplate.Height = 29;
            this.dataGridBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBusqueda.Size = new System.Drawing.Size(1053, 344);
            this.dataGridBusqueda.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 125;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 125;
            // 
            // Tema
            // 
            this.Tema.HeaderText = "Tema";
            this.Tema.MinimumWidth = 6;
            this.Tema.Name = "Tema";
            this.Tema.ReadOnly = true;
            this.Tema.Width = 125;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Width = 125;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "Pais";
            this.Pais.MinimumWidth = 6;
            this.Pais.Name = "Pais";
            this.Pais.ReadOnly = true;
            this.Pais.Width = 125;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.MinimumWidth = 6;
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            this.Año.Width = 125;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 125;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.CadetBlue;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVender.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVender.Location = new System.Drawing.Point(407, 390);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(258, 64);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = false;
            // 
            // FormBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1092, 466);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.dataGridBusqueda);
            this.Name = "FormBusqueda";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Button btnVender;
    }
}