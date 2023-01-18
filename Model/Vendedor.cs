using System;
using System.Collections.Generic;
using System.Text;

namespace cotizador
{
    public class Vendedor
    {
        String nombre;
        String apellido;
        String codVendedor;
        Tienda tienda;
        List<Cotizacion> cotizaciones = new List<Cotizacion>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string CodVendedor { get => codVendedor; set => codVendedor = value; }
        internal Tienda Tienda { get => tienda; set => tienda = value; }
        internal List<Cotizacion> Cotizaciones { get => cotizaciones; set => cotizaciones = value; }

        public Vendedor(string nombre, string apellido, string codigo, Tienda tienda)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codVendedor = codigo;
            this.tienda = tienda;
        }
        public void agregarCotizacion(Cotizacion cotizacion)
        {
            cotizaciones.Add(cotizacion);
        }
    }
}
