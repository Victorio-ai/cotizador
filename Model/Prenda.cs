using System;
using System.Collections.Generic;
using System.Text;

namespace cotizador
{
    public enum Calidad
    {
        Standard,
        Premium
    }
    public class Prenda
    {
        protected Calidad calidad;
        float precio;
        private int stock;

        public float Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        internal Calidad Calidad { get => calidad; set => calidad = value; }
    }
}
