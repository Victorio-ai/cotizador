using System;
using System.Collections.Generic;
using System.Text;

namespace cotizador
{
    enum Tipo
    {
        Comun,
        Chupin
    }
    class Pantalon : Prenda
    {
        private Tipo tipo;

        internal Tipo Tipo { get => tipo; set => tipo = value; }

        public Pantalon(Tipo tipo, Calidad calidad, int stock)
        {
            this.tipo = tipo;
            this.calidad = calidad;
            Stock = stock;
        }

        public Pantalon()
        {

        }
    }
}
