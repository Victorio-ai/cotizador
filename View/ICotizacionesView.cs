using System;
using System.Collections.Generic;
using System.Text;

namespace cotizador
{
    interface ICotizacionesView
    {
        public void mostrarCotizaciones(List<Cotizacion> cotizaciones);
        public void mostrar();
        public void ocultar();
    }
}
