﻿
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
            this.richtxtGeneroClientes = new System.Windows.Forms.RichTextBox();
            this.richtxtHorarioVentas = new System.Windows.Forms.RichTextBox();
            this.richtxtRecaudacionDia = new System.Windows.Forms.RichTextBox();
            this.richTextEdadesVentas = new System.Windows.Forms.RichTextBox();
            this.dataGridMasVendidos = new System.Windows.Forms.DataGridView();
            this.lblMasVendidos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMasVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // richtxtGeneroClientes
            // 
            this.richtxtGeneroClientes.BackColor = System.Drawing.Color.CadetBlue;
            this.richtxtGeneroClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richtxtGeneroClientes.Location = new System.Drawing.Point(229, 23);
            this.richtxtGeneroClientes.Name = "richtxtGeneroClientes";
            this.richtxtGeneroClientes.Size = new System.Drawing.Size(189, 88);
            this.richtxtGeneroClientes.TabIndex = 0;
            this.richtxtGeneroClientes.Text = "";
            // 
            // richtxtHorarioVentas
            // 
            this.richtxtHorarioVentas.BackColor = System.Drawing.Color.CadetBlue;
            this.richtxtHorarioVentas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richtxtHorarioVentas.Location = new System.Drawing.Point(424, 23);
            this.richtxtHorarioVentas.Name = "richtxtHorarioVentas";
            this.richtxtHorarioVentas.Size = new System.Drawing.Size(189, 88);
            this.richtxtHorarioVentas.TabIndex = 1;
            this.richtxtHorarioVentas.Text = "";
            // 
            // richtxtRecaudacionDia
            // 
            this.richtxtRecaudacionDia.BackColor = System.Drawing.Color.CadetBlue;
            this.richtxtRecaudacionDia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richtxtRecaudacionDia.Location = new System.Drawing.Point(34, 23);
            this.richtxtRecaudacionDia.Name = "richtxtRecaudacionDia";
            this.richtxtRecaudacionDia.Size = new System.Drawing.Size(189, 62);
            this.richtxtRecaudacionDia.TabIndex = 2;
            this.richtxtRecaudacionDia.Text = "";
            // 
            // richTextEdadesVentas
            // 
            this.richTextEdadesVentas.BackColor = System.Drawing.Color.CadetBlue;
            this.richTextEdadesVentas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextEdadesVentas.Location = new System.Drawing.Point(34, 91);
            this.richTextEdadesVentas.Name = "richTextEdadesVentas";
            this.richTextEdadesVentas.Size = new System.Drawing.Size(189, 185);
            this.richTextEdadesVentas.TabIndex = 3;
            this.richTextEdadesVentas.Text = "";
            // 
            // dataGridMasVendidos
            // 
            this.dataGridMasVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMasVendidos.Location = new System.Drawing.Point(229, 137);
            this.dataGridMasVendidos.Name = "dataGridMasVendidos";
            this.dataGridMasVendidos.RowHeadersWidth = 51;
            this.dataGridMasVendidos.RowTemplate.Height = 29;
            this.dataGridMasVendidos.Size = new System.Drawing.Size(384, 139);
            this.dataGridMasVendidos.TabIndex = 4;
            // 
            // lblMasVendidos
            // 
            this.lblMasVendidos.AutoSize = true;
            this.lblMasVendidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMasVendidos.Location = new System.Drawing.Point(229, 114);
            this.lblMasVendidos.Name = "lblMasVendidos";
            this.lblMasVendidos.Size = new System.Drawing.Size(186, 20);
            this.lblMasVendidos.TabIndex = 5;
            this.lblMasVendidos.Text = "LIBROS MAS VENDIDOS: ";
            // 
            // FormEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(660, 314);
            this.Controls.Add(this.lblMasVendidos);
            this.Controls.Add(this.dataGridMasVendidos);
            this.Controls.Add(this.richTextEdadesVentas);
            this.Controls.Add(this.richtxtRecaudacionDia);
            this.Controls.Add(this.richtxtHorarioVentas);
            this.Controls.Add(this.richtxtGeneroClientes);
            this.Name = "FormEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FormEstadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMasVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtGeneroClientes;
        private System.Windows.Forms.RichTextBox richtxtHorarioVentas;
        private System.Windows.Forms.RichTextBox richtxtRecaudacionDia;
        private System.Windows.Forms.RichTextBox richTextEdadesVentas;
        private System.Windows.Forms.DataGridView dataGridMasVendidos;
        private System.Windows.Forms.Label lblMasVendidos;
    }
}