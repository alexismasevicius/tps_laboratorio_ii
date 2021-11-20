
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
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarCatalogo = new System.Windows.Forms.Button();
            this.BusquedaGB = new System.Windows.Forms.GroupBox();
            this.lblVentasInicio = new System.Windows.Forms.Label();
            this.BusquedaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusqueda.Location = new System.Drawing.Point(6, 52);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(659, 30);
            this.txtBusqueda.TabIndex = 0;
            // 
            // rbtnTitulo
            // 
            this.rbtnTitulo.AutoSize = true;
            this.rbtnTitulo.Checked = true;
            this.rbtnTitulo.Location = new System.Drawing.Point(6, 22);
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
            this.rbtnAutor.Location = new System.Drawing.Point(80, 22);
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
            this.rbtnAnio.Location = new System.Drawing.Point(153, 22);
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
            this.btnBuscar.Location = new System.Drawing.Point(671, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 30);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEstadisticas.CausesValidation = false;
            this.btnEstadisticas.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstadisticas.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEstadisticas.Location = new System.Drawing.Point(619, 145);
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
            this.btnAgregar.Location = new System.Drawing.Point(317, 145);
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
            this.btnMostrarCatalogo.Location = new System.Drawing.Point(18, 145);
            this.btnMostrarCatalogo.Name = "btnMostrarCatalogo";
            this.btnMostrarCatalogo.Size = new System.Drawing.Size(197, 55);
            this.btnMostrarCatalogo.TabIndex = 11;
            this.btnMostrarCatalogo.Text = "MOSTRAR CATALOGO DE LIBRERIA";
            this.btnMostrarCatalogo.UseVisualStyleBackColor = false;
            this.btnMostrarCatalogo.Click += new System.EventHandler(this.btnMostrarCatalogo_Click);
            // 
            // BusquedaGB
            // 
            this.BusquedaGB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BusquedaGB.Controls.Add(this.txtBusqueda);
            this.BusquedaGB.Controls.Add(this.rbtnTitulo);
            this.BusquedaGB.Controls.Add(this.rbtnAutor);
            this.BusquedaGB.Controls.Add(this.rbtnAnio);
            this.BusquedaGB.Controls.Add(this.btnBuscar);
            this.BusquedaGB.Location = new System.Drawing.Point(11, 12);
            this.BusquedaGB.Name = "BusquedaGB";
            this.BusquedaGB.Size = new System.Drawing.Size(823, 93);
            this.BusquedaGB.TabIndex = 14;
            this.BusquedaGB.TabStop = false;
            this.BusquedaGB.Text = "Busqueda";
            // 
            // lblVentasInicio
            // 
            this.lblVentasInicio.AutoSize = true;
            this.lblVentasInicio.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVentasInicio.Location = new System.Drawing.Point(18, 219);
            this.lblVentasInicio.Name = "lblVentasInicio";
            this.lblVentasInicio.Size = new System.Drawing.Size(148, 19);
            this.lblVentasInicio.TabIndex = 18;
            this.lblVentasInicio.Text = "Ventas Totales : 0";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(846, 238);
            this.Controls.Add(this.lblVentasInicio);
            this.Controls.Add(this.BusquedaGB);
            this.Controls.Add(this.btnMostrarCatalogo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEstadisticas);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libreria UTN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BusquedaGB.ResumeLayout(false);
            this.BusquedaGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.RadioButton rbtnTitulo;
        private System.Windows.Forms.RadioButton rbtnAutor;
        private System.Windows.Forms.RadioButton rbtnAnio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarCatalogo;
        private System.Windows.Forms.GroupBox BusquedaGB;
        private System.Windows.Forms.Label lblVentasInicio;
    }
}

