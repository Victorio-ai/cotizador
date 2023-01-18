using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;


namespace cotizador
{
    class Presenter
    {
        IView view;
        Cotizacion cotizacion;
        Tienda tienda;
        Vendedor vendedor;
        int prendaStock;
        
        public Presenter(IView view)
        {
            this.view = view;
        }
        public void cotizar()
        {
            Dictionary<string, string> dataInput = view.getInputCotizacion();
            //int cantidad = int.Parse(dataInput["cantidad"]); //realizar validación

            float precio;
            int cantidad;
            string msg;
            if(!validarPrecio(dataInput["precio"],out precio, out msg))
            {
                view.mostraMensaje(msg);
                return;
            }
            if(!validarCantidad(dataInput["cantidad"], out cantidad, out msg))
            {
                view.mostraMensaje(msg);
                return;
            }
            
            if (dataInput["prenda"] == "camisa")
            {
                Camisa prenda = new Camisa(); ;
                if(dataInput["manga"] == "corta")
                {
                    prenda.Manga = Manga.Corta;
                }
                else
                {
                    prenda.Manga = Manga.Larga;
                }

                if (dataInput["cuello"] == "mao")
                {
                    prenda.Cuello = Cuello.Mao;
                }
                else
                {
                    prenda.Cuello = Cuello.Comun;
                }

                if (dataInput["calidad"] == "standard")
                {
                    prenda.Calidad = Calidad.Standard;
                }
                else
                {
                    if (dataInput["calidad"] == "premium")
                    {
                        prenda.Calidad = Calidad.Premium;
                    }
                }

                prenda.Precio = float.Parse(dataInput["precio"]); //realizar validación
                cotizacion = new Cotizacion(prenda, cantidad, vendedor);
                view.mostrarResultado(cotizacion.Resultado);


            }
            else
            {
                if (dataInput["prenda"] == "pantalon")
                {
                    Pantalon prenda = new Pantalon();
                    if (dataInput["tipo"] == "chupin")
                    {
                        prenda.Tipo = Tipo.Chupin;
                    }
                    else
                    {
                        prenda.Tipo = Tipo.Comun;
                    }

                    if (dataInput["calidad"] == "standard")
                    {
                        prenda.Calidad = Calidad.Standard;
                    }
                    else
                    {

                        prenda.Calidad = Calidad.Premium;

                    }

                    prenda.Precio = float.Parse(dataInput["precio"]); //realizar validación
                    cotizacion = new Cotizacion(prenda, cantidad, vendedor);
                    view.mostrarResultado(cotizacion.Resultado);
                }
            }

        }

        public void mostrarDatosTiendaVendedor()
        {
            //cargarDatosFicticios();
            view.mostrarDatosTienda(vendedor.Tienda.Nombre, vendedor.Tienda.Direccion);
            view.mostrarDatosVendedor(vendedor.Nombre, vendedor.Apellido, vendedor.CodVendedor);
        }

        public void cargarStock()
        {


            // 1000 camisas

            // 500 manga corta

            // 200 cuello mao

            Camisa camisa1 = new Camisa(Manga.Corta, Cuello.Mao, Calidad.Standard,100); // 100 calidad Standard
            Camisa camisa2 = new Camisa(Manga.Corta, Cuello.Mao, Calidad.Premium,100); // 100 calidad Premium

            // 300 cuallo común

            Camisa camisa3 = new Camisa(Manga.Corta, Cuello.Comun, Calidad.Standard,150); // 150 calidad Standard
            Camisa camisa4 = new Camisa(Manga.Corta, Cuello.Comun, Calidad.Premium,150); // 150 calidad Premium

            // 500 manga larga

            // 150 cuello mao

            Camisa camisa5 = new Camisa(Manga.Larga, Cuello.Mao, Calidad.Standard,75); // 75 calidad Standard
            Camisa camisa6 = new Camisa(Manga.Larga, Cuello.Mao, Calidad.Premium,75); // 75 calidad Premium

            // 350 cuello común

            Camisa camisa7 = new Camisa(Manga.Larga, Cuello.Comun, Calidad.Standard,175); // 175 calidad Standard
            Camisa camisa8 = new Camisa(Manga.Larga, Cuello.Comun, Calidad.Premium,175); // 175 calidad Premium


            // 2000 pantalones

            // 1500 chupines

            Pantalon pantalon1 = new Pantalon(Tipo.Chupin, Calidad.Standard, 750); // 750 calidad Standard
            Pantalon pantalon2 = new Pantalon(Tipo.Chupin, Calidad.Premium, 750); // 750 calidad Standard

            // 500 comunes

            Pantalon pantalon3 = new Pantalon(Tipo.Comun, Calidad.Standard, 250); // 250 calidad Standard
            Pantalon pantalon4 = new Pantalon(Tipo.Comun, Calidad.Premium, 250); // 250 calidad Premium

            tienda.agregarPrenda(camisa1);
            tienda.agregarPrenda(camisa2);
            tienda.agregarPrenda(camisa3);
            tienda.agregarPrenda(camisa4);
            tienda.agregarPrenda(camisa5);
            tienda.agregarPrenda(camisa6);
            tienda.agregarPrenda(camisa7);
            tienda.agregarPrenda(camisa8);

            tienda.agregarPrenda(pantalon1);
            tienda.agregarPrenda(pantalon2);
            tienda.agregarPrenda(pantalon3);
            tienda.agregarPrenda(pantalon4);

        }

        public void cargarDatosFicticios()
        {
         
            tienda = new Tienda("La Tienda", "Dirección 123");
            vendedor = new Vendedor("Algun", "Nombre", "12345678", tienda);
   
        }

        public int consultarStock()
        {
            Dictionary<string, string> prendaInput = view.getInputPrenda();
            int stock = 0;

            if (prendaInput["prenda"] == "camisa")
            {
                Manga manga;
                Cuello cuello;
                Calidad calidad;

                
                if (prendaInput["manga"] == "corta")
                {
                    manga = Manga.Corta;
                }
                else
                {
                    manga = Manga.Larga;
                }

                if (prendaInput["cuello"] == "mao")
                {
                    cuello = Cuello.Mao;
                }
                else
                {
                    cuello = Cuello.Comun;
                }

                if (prendaInput["calidad"] == "standard")
                {
                    calidad = Calidad.Standard;
                }
                else
                {

                    calidad = Calidad.Premium;

                }

                List<Camisa> camisas = tienda.Prendas.OfType<Camisa>().Cast<Camisa>().ToList();

                Prenda prenda = camisas.FirstOrDefault(c => c.Calidad == calidad && c.Manga == manga && c.Cuello == cuello);
                stock = prenda.Stock;
                

            }
            else
            {
                if (prendaInput["prenda"] == "pantalon")
                {
                    Tipo tipo;
                    Calidad calidad;

                    if (prendaInput["tipo"] == "chupin")
                    {
                        tipo = Tipo.Chupin;
                    }
                    else
                    {
                        tipo = Tipo.Comun;
                    }

                    if (prendaInput["calidad"] == "standard")
                    {
                        calidad = Calidad.Standard;
                    }
                    else
                    {

                        calidad = Calidad.Premium;

                    }

                    List<Pantalon> pantalones = tienda.Prendas.OfType<Pantalon>().Cast<Pantalon>().ToList();

                    Prenda prenda = pantalones.FirstOrDefault(c => c.Calidad == calidad && c.Tipo == tipo);
                    stock = prenda.Stock;
                    
                }


            }

            return stock;

            
        }

        public void mostrarStock()
        {
            prendaStock = consultarStock();
            view.mostrarDatoStock(prendaStock);
        }

        private bool validarPrecio(string precio, out float precioNum, out string msg)
        {
            msg = null;
            precioNum = 0;

            if(precio == String.Empty)
            {
                msg = "No se ha ingresado el precio unitario";
                return false;
            }
            else
            {
                if (Regex.IsMatch(precio, @"^-?\d+$"))
                {
                    if (float.TryParse(precio, out precioNum))
                    {
                        if (precioNum > 0)
                        {
                            return true;
                        }
                        else
                        {
                            msg = "El precio unitario debe ser mayor a 0";
                            return false;
                        }
                    }
                    else
                    {
                        msg = "El valor del precio unitario se encuentra fuera del rango permitido";
                        return false;
                    }

                }
                else
                {
                    msg = "El precio unitario debe ser un valor numérico";
                    return false;
                }
            }

        }

        private bool validarCantidad(string cantidad, out int cantidadNum, out string msg)
        {
            msg = null;
            cantidadNum = 0;

            if (cantidad == String.Empty)
            {
                msg = "No se ha ingresado la cantidad";
                return false;
            }
            else
            {
                if (Regex.IsMatch(cantidad, @"^-?\d+$"))
                {
                    if (int.TryParse(cantidad, out cantidadNum))
                    {
                        if (cantidadNum > 0)
                        {
                            if (cantidadNum > prendaStock)
                            {
                                msg = "La cantidad no puede superar el stock disponible";
                                return false;
                            }
                            return true;
                        }
                        else
                        {
                            msg = "La cantidad debe ser mayor a 0";
                            return false;
                        }
                    }
                    else
                    {
                        msg = "La cantidad se encuentra fuera del rango permitido";
                        return false;
                    }

                }
                else
                {
                    msg = "La cantidad debe ser un valor numérico";
                    return false;
                }
            }

        }

        public void mostrarHistorial(ICotizacionesView view)
        {
            List<Cotizacion> cotizaciones = vendedor.Cotizaciones;
            view.mostrarCotizaciones(cotizaciones);
            view.mostrar();
        }



    }
}
