using System;
using System.Collections.Generic;
using System.Text;

namespace cotizador
{
    public class Tienda
    {
        String nombre;
        String direccion;
        List<Prenda> prendas = new List<Prenda>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<Prenda> Prendas { get => prendas; set => prendas = value; }

        public Tienda(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public void agregarPrenda(Prenda prenda)
        {
            prendas.Add(prenda);
        }
    }
}
