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
    public partial class Form1 : Form, IView
    {
        Presenter presenter;
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            presenter.cotizar();

        }


        public void mostrarDatosTienda(string nombre, string direccion)
        {
            lblNombreTienda.Text = nombre;
            lblDireccionTienda.Text = direccion;
        }

        public void mostrarDatosVendedor(string nombre, string apellido, string codigo)
        {
            lblNombreApellidoVendedor.Text = nombre +" "+ apellido;
            lblCodigoVendedor.Text = codigo.ToString();
        }

        public void mostraMensaje(string msg)
        {
            MessageBox.Show(msg,"Cotizador");
        }

        public Dictionary<string, string> getInputCotizacion()
        {
            //Dictionary<string, string> dataInput = new Dictionary<string, string>();
            Dictionary<string, string> dataInput = getInputPrenda();

            dataInput.Add("precio", tbPrecioU.Text);
            dataInput.Add("cantidad", tbCantidad.Text);

            return dataInput;


        }

        public Dictionary<string, string> getInputPrenda()
        {
            Dictionary<string, string> dataInput = new Dictionary<string, string>();


            if (rbCamisa.Checked)
            {
                dataInput.Add("prenda", "camisa");
                if (cbMangaCorta.Checked)
                {
                    dataInput.Add("manga", "corta");
                }
                else
                {
                    dataInput.Add("manga", "larga");
                }
                if (cbCuelloMao.Checked)
                {
                    dataInput.Add("cuello", "mao");
                }
                else
                {
                    dataInput.Add("cuello", "comun");
                }
            }
            else
            {
                if (rbPantalon.Checked)
                {
                    dataInput.Add("prenda", "pantalon");
                    if (cbChupin.Checked)
                    {
                        dataInput.Add("tipo", "chupin");
                    }
                    else
                    {
                        dataInput.Add("tipo", "comun");
                    }
                }
            }

            if (rbStandard.Checked)
            {
                dataInput.Add("calidad", "standard");

            }
            else
            {
                if (rbPremium.Checked)
                {
                    dataInput.Add("calidad", "premium");
                }
            }


            return dataInput;

        }

        public void mostrarDatoStock(int stock)
        {
            lblStock.Text = stock.ToString();
        }

        public void mostrarResultado(float resultado)
        {
            lblResultado.Text = resultado.ToString();
        }

        private void rbCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCamisa.Checked)
            {
                cbMangaCorta.Enabled = true;
                cbCuelloMao.Enabled = true;
                cbChupin.Enabled = false;


            }
            presenter.mostrarStock();
        }

        private void rbPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPantalon.Checked)
            {
                cbMangaCorta.Enabled = false;
                cbCuelloMao.Enabled = false;
                cbChupin.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            presenter = new Presenter(this);
            presenter.cargarDatosFicticios();
            presenter.mostrarDatosTiendaVendedor();
            presenter.cargarStock();
            presenter.mostrarStock();

        }

        private void cbMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            presenter.mostrarStock();
        }

        private void cbCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            presenter.mostrarStock();
        }

        private void cbChupin_CheckedChanged(object sender, EventArgs e)
        {
            presenter.mostrarStock();
        }

        private void rbStandard_CheckedChanged(object sender, EventArgs e)
        {
            presenter.mostrarStock();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            presenter.mostrarHistorial(new HistorialForm());
        }
    }
}
