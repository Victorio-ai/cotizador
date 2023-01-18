using System;
using System.Collections.Generic;
using System.Text;

namespace cotizador
{
    interface IView
    {
        public Dictionary<string, string> getInputCotizacion();
        public void mostrarDatosTienda(string nombre, string direccion);
        public void mostrarDatosVendedor(string nombre, string apellido, string codigo);
        public Dictionary<string, string> getInputPrenda();
        public void mostrarDatoStock(int stock);
        public void mostrarResultado(float resultado);
        public void mostraMensaje(string msg);

    }
}
