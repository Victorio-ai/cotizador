using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cotizador
{
    public class HistorialForm : Form, ICotizacionesView
    {
        private ListView listViewCotizaciones;

        public HistorialForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Historial de cotizaciones";
            // Establecer el tamaño del formulario
            this.Size = new Size(940, 700);
            // Establecer el tamaño del área de contenido del formulario
            //.ClientSize = new Size(800, 600);
            // Crear una nueva instancia del control ListView
            listViewCotizaciones = new ListView();

            // Establecer las propiedades necesarias para que el control sea visible
            listViewCotizaciones.Location = new Point(10, 10);
            listViewCotizaciones.Size = new Size(300, 200);
            listViewCotizaciones.View = View.Details;
            listViewCotizaciones.FullRowSelect = true;
            listViewCotizaciones.GridLines = true;
            listViewCotizaciones.Visible = true;

            // Agregar columnas al ListView
            listViewCotizaciones.Columns.Add("ID", 100);
            listViewCotizaciones.Columns.Add("Fecha y hora", 150);
            listViewCotizaciones.Columns.Add("Cod. Vendedor", 100);
            listViewCotizaciones.Columns.Add("Prenda", 220);
            listViewCotizaciones.Columns.Add("Precio unitario", 100);
            listViewCotizaciones.Columns.Add("Cantidad", 100);
            listViewCotizaciones.Columns.Add("Resultado", 100);




            listViewCotizaciones.Size = new Size(900, 600);

            // Agregar el control al formulario
            this.Controls.Add(listViewCotizaciones);
        }

        public  void mostrar()
        {
            this.Show();
        }

        public void ocultar()
        {
            this.Hide();
        }

        public void mostrarCotizaciones(List<Cotizacion> cotizaciones)
        {
            listViewCotizaciones.Items.Clear();
            String prendaString = string.Empty;

            foreach (Cotizacion cotizacion in cotizaciones)
            {
                ListViewItem item = new ListViewItem(cotizacion.ID1.ToString());
                item.SubItems.Add(cotizacion.TiempoCotizacion.ToString());
                item.SubItems.Add(cotizacion.CodVendedor.ToString());
                if (cotizacion.Prenda.GetType() == typeof(Camisa))
                {
                    Camisa prenda = (Camisa)cotizacion.Prenda;
                    prendaString = cotizacion.Prenda.GetType().Name.ToString() + ", manga " + prenda.Manga.ToString().ToLower() + ", cuello " + prenda.Cuello.ToString().ToLower();
                }
                else
                {
                    if (cotizacion.Prenda.GetType() == typeof(Pantalon))
                    {
                        Pantalon prenda = (Pantalon)cotizacion.Prenda;
                        prendaString = cotizacion.Prenda.GetType().Name.ToString() + ", tipo " + prenda.Tipo.ToString().ToLower();
                    }
                }
                item.SubItems.Add(prendaString);
                item.SubItems.Add(cotizacion.Prenda.Precio.ToString());
                item.SubItems.Add(cotizacion.Cantidad.ToString());
                item.SubItems.Add("$"+cotizacion.Resultado.ToString());

                listViewCotizaciones.Items.Add(item);
            }
        }
    }
}
