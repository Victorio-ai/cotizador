using System;
using System.Collections.Generic;
using System.Text;

namespace cotizador
{
    enum Manga
    {
        Corta,
        Larga
    }
    enum Cuello
    {
        Mao,
        Comun
    }
    class Camisa : Prenda
    {
        private Manga manga;
        private Cuello cuello;

        internal Manga Manga { get => manga; set => manga = value; }
        internal Cuello Cuello { get => cuello; set => cuello = value; }

        public Camisa(Manga manga, Cuello cuello, Calidad calidad, int stock)
        {
            this.manga = manga;
            this.cuello = cuello;
            this.calidad = calidad;
            Stock = stock;
        }

        public Camisa()
        {

        }
    }
}
