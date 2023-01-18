using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cotizador
{
    public class Cotizacion
    {
        int ID;
        DateTime tiempoCotizacion;
        String codVendedor;
        Prenda prenda;
        int cantidad;
        float resultado;
        public float Resultado { get => resultado; set => resultado = value; }
        public int ID1 { get => ID; set => ID = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime TiempoCotizacion { get => tiempoCotizacion; set => tiempoCotizacion = value; }
        public string CodVendedor { get => codVendedor; set => codVendedor = value; }
        public Prenda Prenda { get => prenda; set => prenda = value; }

        public  Cotizacion(Prenda prenda, int cantidad, Vendedor vendedor)
        {

            
            if(vendedor.Cotizaciones.Count == 0)
            {
                ID = 1;
            }
            else
            {
                Cotizacion ultimaCotizacion = vendedor.Cotizaciones.Last();
                ID = ultimaCotizacion.ID+1; 
            }
            
            tiempoCotizacion = DateTime.Now;
            this.codVendedor = vendedor.CodVendedor;
            this.prenda = prenda;
            this.cantidad = cantidad; // comprobar stock
            resultado = calcularResultado(this.prenda);
            vendedor.agregarCotizacion(this);


            
        }



        private float calcularResultado(Prenda prenda)
        {
            float precio = this.prenda.Precio;
            if (this.prenda.GetType() == typeof(Camisa))
            {
                Camisa Camisa = (Camisa)this.prenda;
                if (Camisa.Manga == Manga.Corta)
                {
                    precio = precio - (precio * 0.1f);
                }

                if (Camisa.Cuello == Cuello.Mao)
                {
                    precio = precio + (precio * 0.03f);
                }


            }

            if (this.prenda.GetType() == typeof(Pantalon))
            {
                Pantalon pantalon = (Pantalon)this.prenda;
                if (pantalon.Tipo == Tipo.Chupin)
                {
                    precio = precio - (precio * 0.12f);
                }

            }

            if (prenda.Calidad == Calidad.Premium)
            {
                precio = precio + (precio * 0.3f);
            }

            return precio*(float)cantidad;
        }
    }
}
