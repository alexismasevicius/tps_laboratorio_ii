using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class FormAgregar : Form
    {
        Libreria miLibreria;
        Revisteria miRevisteria;

        public FormAgregar(Libreria miLibreria, Revisteria miRevisteria )
        {
            InitializeComponent();
            this.miRevisteria = miRevisteria;
            this.miLibreria = miLibreria;

        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Agrega un elemento a la lista
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string titulo = this.txtTitulo.Text;
            string autor = this.txtAutor.Text;
            int anio;
            if (int.TryParse(this.txtAnio.Text, out anio) && anio<2025 && anio>0) { }
            else { anio = 0; }
            int stock = (int)this.numericStock.Value;
            float precio;
            if (float.TryParse(this.txtPrecio.Text, out precio) && precio>0) { }
            else { precio = 0; }

            if (this.rbtnLibro.Checked)
            {         
                string genero = this.txtGenero.Text;

                Libro miLibro = new Libro(titulo, autor, anio, stock, 0, precio, genero);

                if (MessageBox.Show($"Esta seguro de agregar?\nTITULO: {titulo} \nAUTOR: {autor}\nANIO:{anio} \n STOCK: {stock}\n PRECIO: {precio}\n GENERO: {genero} ",
                    "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        this.miLibreria.AgregarProducto(miLibro);
                        
                    }
                    catch (BibliotecaException f)
                    {

                        MessageBox.Show($"{f.Message},\n En clase: {f.NombreClase}, Metodo: {f.NombreMetodo} \n {f.InnerException.Message}");
                    }
                    this.Close();
                }               
            }
            else
            {
                if (this.rbtnComic.Checked)
                {
                    string esManga = this.txtGenero.Text;
                    Comic miComic = new Comic(titulo, autor, anio, stock, 0, precio, esManga);

                    if (MessageBox.Show($"Esta seguro de agregar?\nTITULO: {titulo} \nAUTOR: {autor}\nANIO:{anio} \n STOCK: {stock}\n PRECIO: {precio}\n ES MANGA?: {esManga} ",
                                        "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                             this.miRevisteria.AgregarProducto(miComic);
                        }
                        catch (BibliotecaException f)
                        {
                            MessageBox.Show($"{f.Message},\n En clase: {f.NombreClase}, Metodo: {f.NombreMetodo} \n {f.InnerException.Message}");
                        }

                        this.Close();
                    }                   
                }
                else
                {
                    Revista miRev = new Revista(titulo, autor, anio, stock, 0, precio);

                    if (MessageBox.Show($"Esta seguro de agregar?\nTITULO: {titulo} \nAUTOR: {autor}\nANIO:{anio} \n STOCK: {stock}\n PRECIO: {precio}\n ",
                        "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            this.miRevisteria.AgregarProducto(miRev);
                        }
                        catch (BibliotecaException f)
                        {

                            MessageBox.Show($"{f.Message},\n En clase: {f.NombreClase}, Metodo: {f.NombreMetodo} \n {f.InnerException.Message}");

                        }
                        this.Close();
                    }                   
                }
            }
        }


        private void rbtnRevista_CheckedChanged(object sender, EventArgs e)
        {
            this.lblGenero.Hide();
            this.txtGenero.Hide();
        }

        private void rbtnComic_CheckedChanged(object sender, EventArgs e)
        {
            this.lblGenero.Text = "ES MANGA?:";
            this.lblGenero.Show();
            this.txtGenero.Show();
        }

        private void rbtnLibro_CheckedChanged(object sender, EventArgs e)
        {
            this.lblGenero.Text = "     GENERO:";
            this.lblGenero.Show();
            this.txtGenero.Show();
        }

    }
}
