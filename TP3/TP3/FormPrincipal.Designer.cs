
namespace TP3
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.rbtnTitulo = new System.Windows.Forms.RadioButton();
            this.rbtnAutor = new System.Windows.Forms.RadioButton();
            this.rbtnAnio = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarCatalogo = new System.Windows.Forms.Button();
            this.btnMostrarRevisteria = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusqueda.Location = new System.Drawing.Point(31, 92);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(659, 30);
            this.txtBusqueda.TabIndex = 0;
            // 
            // rbtnTitulo
            // 
            this.rbtnTitulo.AutoSize = true;
            this.rbtnTitulo.Checked = true;
            this.rbtnTitulo.Location = new System.Drawing.Point(31, 43);
            this.rbtnTitulo.Name = "rbtnTitulo";
            this.rbtnTitulo.Size = new System.Drawing.Size(68, 24);
            this.rbtnTitulo.TabIndex = 1;
            this.rbtnTitulo.TabStop = true;
            this.rbtnTitulo.Text = "Titulo";
            this.rbtnTitulo.UseVisualStyleBackColor = true;
            // 
            // rbtnAutor
            // 
            this.rbtnAutor.AutoSize = true;
            this.rbtnAutor.Location = new System.Drawing.Point(105, 43);
            this.rbtnAutor.Name = "rbtnAutor";
            this.rbtnAutor.Size = new System.Drawing.Size(67, 24);
            this.rbtnAutor.TabIndex = 2;
            this.rbtnAutor.TabStop = true;
            this.rbtnAutor.Text = "Autor";
            this.rbtnAutor.UseVisualStyleBackColor = true;
            // 
            // rbtnAnio
            // 
            this.rbtnAnio.AutoSize = true;
            this.rbtnAnio.Location = new System.Drawing.Point(178, 43);
            this.rbtnAnio.Name = "rbtnAnio";
            this.rbtnAnio.Size = new System.Drawing.Size(57, 24);
            this.rbtnAnio.TabIndex = 3;
            this.rbtnAnio.TabStop = true;
            this.rbtnAnio.Text = "Año";
            this.rbtnAnio.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(704, 91);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 30);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEstadisticas.CausesValidation = false;
            this.btnEstadisticas.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstadisticas.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEstadisticas.Location = new System.Drawing.Point(640, 138);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(197, 55);
            this.btnEstadisticas.TabIndex = 9;
            this.btnEstadisticas.Text = "VER ESTADISTICAS";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAgregar.CausesValidation = false;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(437, 138);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(197, 55);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "AGREGAR PRODUCTO";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarCatalogo
            // 
            this.btnMostrarCatalogo.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMostrarCatalogo.CausesValidation = false;
            this.btnMostrarCatalogo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMostrarCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarCatalogo.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarCatalogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarCatalogo.Location = new System.Drawing.Point(31, 138);
            this.btnMostrarCatalogo.Name = "btnMostrarCatalogo";
            this.btnMostrarCatalogo.Size = new System.Drawing.Size(197, 55);
            this.btnMostrarCatalogo.TabIndex = 11;
            this.btnMostrarCatalogo.Text = "MOSTRAR CATALOGO DE LIBRERIA";
            this.btnMostrarCatalogo.UseVisualStyleBackColor = false;
            this.btnMostrarCatalogo.Click += new System.EventHandler(this.btnMostrarCatalogo_Click);
            // 
            // btnMostrarRevisteria
            // 
            this.btnMostrarRevisteria.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMostrarRevisteria.CausesValidation = false;
            this.btnMostrarRevisteria.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMostrarRevisteria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarRevisteria.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarRevisteria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarRevisteria.Location = new System.Drawing.Point(234, 138);
            this.btnMostrarRevisteria.Name = "btnMostrarRevisteria";
            this.btnMostrarRevisteria.Size = new System.Drawing.Size(197, 55);
            this.btnMostrarRevisteria.TabIndex = 12;
            this.btnMostrarRevisteria.Text = "MOSTRAR CATALOGO DE REVISTERIA";
            this.btnMostrarRevisteria.UseVisualStyleBackColor = false;
            this.btnMostrarRevisteria.Click += new System.EventHandler(this.btnMostrarRevisteria_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Libro",
            "Comic",
            "Revista"});
            this.cmbTipo.Location = new System.Drawing.Point(268, 42);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(117, 28);
            this.cmbTipo.TabIndex = 13;
            this.cmbTipo.Text = "Seleccionar";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 205);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.btnMostrarRevisteria);
            this.Controls.Add(this.btnMostrarCatalogo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rbtnAnio);
            this.Controls.Add(this.rbtnAutor);
            this.Controls.Add(this.rbtnTitulo);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.RadioButton rbtnTitulo;
        private System.Windows.Forms.RadioButton rbtnAutor;
        private System.Windows.Forms.RadioButton rbtnAnio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarCatalogo;
        private System.Windows.Forms.Button btnMostrarRevisteria;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
    }
}

