
namespace TP3
{
    partial class FormAgregar
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
            this.components = new System.ComponentModel.Container();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.rbtnLibro = new System.Windows.Forms.RadioButton();
            this.rbtnRevista = new System.Windows.Forms.RadioButton();
            this.rbtnComic = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.numericStock = new System.Windows.Forms.NumericUpDown();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoProducto.Location = new System.Drawing.Point(12, 9);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(158, 20);
            this.lblTipoProducto.TabIndex = 0;
            this.lblTipoProducto.Text = "TIPO DE PRODUCTO: ";
            // 
            // rbtnLibro
            // 
            this.rbtnLibro.AutoSize = true;
            this.rbtnLibro.Checked = true;
            this.rbtnLibro.Location = new System.Drawing.Point(176, 9);
            this.rbtnLibro.Name = "rbtnLibro";
            this.rbtnLibro.Size = new System.Drawing.Size(64, 24);
            this.rbtnLibro.TabIndex = 1;
            this.rbtnLibro.TabStop = true;
            this.rbtnLibro.Text = "Libro";
            this.rbtnLibro.UseVisualStyleBackColor = true;
            this.rbtnLibro.CheckedChanged += new System.EventHandler(this.rbtnLibro_CheckedChanged);
            // 
            // rbtnRevista
            // 
            this.rbtnRevista.AutoSize = true;
            this.rbtnRevista.Location = new System.Drawing.Point(246, 9);
            this.rbtnRevista.Name = "rbtnRevista";
            this.rbtnRevista.Size = new System.Drawing.Size(77, 24);
            this.rbtnRevista.TabIndex = 2;
            this.rbtnRevista.Text = "Revista";
            this.rbtnRevista.UseVisualStyleBackColor = true;
            this.rbtnRevista.CheckedChanged += new System.EventHandler(this.rbtnRevista_CheckedChanged);
            // 
            // rbtnComic
            // 
            this.rbtnComic.AutoSize = true;
            this.rbtnComic.Location = new System.Drawing.Point(329, 9);
            this.rbtnComic.Name = "rbtnComic";
            this.rbtnComic.Size = new System.Drawing.Size(72, 24);
            this.rbtnComic.TabIndex = 3;
            this.rbtnComic.Text = "Comic";
            this.rbtnComic.UseVisualStyleBackColor = true;
            this.rbtnComic.CheckedChanged += new System.EventHandler(this.rbtnComic_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(12, 253);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(187, 49);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Brown;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(231, 253);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(187, 49);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(19, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(66, 20);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "TITULO:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAutor.Location = new System.Drawing.Point(21, 111);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(64, 20);
            this.lblAutor.TabIndex = 8;
            this.lblAutor.Text = "AUTOR:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnio.Location = new System.Drawing.Point(38, 150);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(47, 20);
            this.lblAnio.TabIndex = 9;
            this.lblAnio.Text = "AÑO:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(207, 150);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(65, 20);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "PRECIO:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStock.Location = new System.Drawing.Point(246, 198);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(59, 20);
            this.lblStock.TabIndex = 11;
            this.lblStock.Text = "STOCK:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.CadetBlue;
            this.txtTitulo.Location = new System.Drawing.Point(91, 67);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(319, 27);
            this.txtTitulo.TabIndex = 12;
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.Color.CadetBlue;
            this.txtAutor.Location = new System.Drawing.Point(91, 108);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(319, 27);
            this.txtAutor.TabIndex = 13;
            // 
            // txtAnio
            // 
            this.txtAnio.BackColor = System.Drawing.Color.CadetBlue;
            this.txtAnio.Location = new System.Drawing.Point(91, 147);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(104, 27);
            this.txtAnio.TabIndex = 14;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.CadetBlue;
            this.txtPrecio.Location = new System.Drawing.Point(278, 147);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(132, 27);
            this.txtPrecio.TabIndex = 15;
            // 
            // numericStock
            // 
            this.numericStock.BackColor = System.Drawing.Color.CadetBlue;
            this.numericStock.Location = new System.Drawing.Point(315, 196);
            this.numericStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericStock.Name = "numericStock";
            this.numericStock.Size = new System.Drawing.Size(86, 27);
            this.numericStock.TabIndex = 16;
            this.numericStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.Location = new System.Drawing.Point(12, 198);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(93, 20);
            this.lblGenero.TabIndex = 17;
            this.lblGenero.Text = "     GENERO:";
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.Color.CadetBlue;
            this.txtGenero.Location = new System.Drawing.Point(113, 195);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(127, 27);
            this.txtGenero.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 329);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.numericStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbtnComic);
            this.Controls.Add(this.rbtnRevista);
            this.Controls.Add(this.rbtnLibro);
            this.Controls.Add(this.lblTipoProducto);
            this.MaximizeBox = false;
            this.Name = "FormAgregar";
            this.Text = "FormAgregar";
            this.Load += new System.EventHandler(this.FormAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.RadioButton rbtnLibro;
        private System.Windows.Forms.RadioButton rbtnRevista;
        private System.Windows.Forms.RadioButton rbtnComic;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.NumericUpDown numericStock;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}