using System;
using System.Collections.Generic;
using System.Linq;

namespace SupermarketSystem
{
    class Program
    {
        static void Main(string[] args)
        {
           
          ///Bienvenida al programa
            Console.WriteLine("<!-------------------BIENVENIDO A CHEDRAUI------------------------->");
            Console.WriteLine("<!-------------------SISTEMA DE COMPRAS------------------------->");
            //Comienzan instrucciones
            Console.WriteLine("Indica el numero de tickets: ");
            var ticketsQty = Console.ReadLine();
            int ticketsQtyParced = int.Parse(ticketsQty);
            Console.WriteLine("Ingresar el número de productos: ");
            var productsQty = Console.ReadLine();
            int productsQtyParced = int.Parse(productsQty);
            try
            {  //Muestra menu de opciones
                string selectionMenu = "";
                Console.WriteLine("Teclea la opcion que deseas hacer:");
                Console.WriteLine("1)Agregar elemento a ticket  " + "2)Eliminar elemento del ticket  " +"3)Finalizar venta  " + "4)Cancelar venta  "  + "5)Imprimir ticket  " );
                var optionMenu = Console.ReadLine();
                selectionMenu = optionMenu;
                List<string> productsList = new List<string>();
                List<float> priceList = new List<float>(); //Seleccion por numeros para evitar errores con errores de ortografia
                while (selectionMenu == "1" || selectionMenu == "2" || selectionMenu == "3" || selectionMenu == "4" || selectionMenu == "5")
                {
                    do
                    {
                        switch (selectionMenu) //Estructura de control switch case
                        {
                            case "1" when (selectionMenu == "1"): //Agregar producto
                                Console.WriteLine("Indica el nombre del producto:");
                                var productNameId = Console.ReadLine();
                                productsList.Add(productNameId);
                                Console.WriteLine("Ingresa el precio del producto:");
                                var productPrice = Console.ReadLine();
                                float productPriceParced = float.Parse(productPrice);
                                priceList.Add(productPriceParced);
                                break;
                            case "2" when (selectionMenu == "2"): //Eliminar producto
                                Console.WriteLine("Indica el producto por eliminar: ");
                                foreach (string productoList in productsList)
                                {
                                    Console.WriteLine(productoList);
                                }
                                var productRemove = Console.ReadLine();
                                productsList.Remove(productRemove);
                                break;
                            case "3" when (selectionMenu == "3"): //Venta finalizada por el usuario
                                Console.WriteLine("Venta Finalizada, Gracias por su preferencia");
                                Environment.Exit(0);
                                break;
                            case "4" when (selectionMenu == "4"): //Venta cancelada
                                Console.WriteLine("Usted ha  cancelado su venta.");
                                Environment.Exit(0);
                                break;
                            case "5" when (selectionMenu == "5"): //Loader imaginario de acto de impresion
                                Console.WriteLine("/////////////////IMPRIMIENDO//////////////////////");
                                Producto ticketOnDemand = new Producto(ticketsQtyParced, productsQtyParced);
                                ticketOnDemand.ShowTemplateCompanyDataTicket(); //Llamado al metodo para imprimir datos fiscales en el ticker
                                Console.WriteLine("Producto----------------------No.Articulos ");
                                foreach (var productShow in productsList.GroupBy(x => x))
                                    Console.WriteLine($"{productShow.Key}      {productShow.Count()}");
                                float totalAddToCart = priceList.Sum();
                                Console.WriteLine("Total:          {0}", totalAddToCart);
                                ticketOnDemand.ShowTicket();
                                Environment.Exit(0);
                                break;
                        }
                        //Comienza iteracion dos en menu de seleccion par acticidades extras
                        if (selectionMenu == "1" || selectionMenu == "2" || selectionMenu == "3" || selectionMenu == "4" || selectionMenu == "5")
                        {
                            Console.WriteLine("Elige que mas quieres hacer en esta venta"); //Se elige opcion con un caracter numerico
                            Console.WriteLine("1)Agregar elemento a ticket  " + "2)Eliminar elemento del ticket  " + "3)Finalizar venta  " + "4)Cancelar venta  " + "5)Imprimir ticket  ");
                            var actionUser = Console.ReadLine();
                            selectionMenu = actionUser;
                            if (selectionMenu == "1")
                            {
                                Console.WriteLine("Indica el nombre del producto:"); //Agregar otro producto
                                var productNameId = Console.ReadLine();
                                productsList.Add(productNameId);
                                Console.WriteLine("Indica el precio del producto:");
                                var productPrice = Console.ReadLine();
                                float productPriceParced = float.Parse(productPrice);
                                priceList.Add(productPriceParced);
                            }
                            else if (selectionMenu == "2")
                            {
                                Console.WriteLine("Indica el producto por eliminar: "); //eliminar otro producto
                                foreach (string productShow in productsList)
                                {
                                    Console.WriteLine(productShow);
                                }
                                var productRemove = Console.ReadLine();
                                productsList.Remove(productRemove);
                            }
                            else if (selectionMenu == "3")
                            {
                                Console.WriteLine("Gracias por tu preferencia"); //Confirmacion por preferencia
                                Environment.Exit(0);
                            }
                            else if (selectionMenu == "4")
                            {
                                Console.WriteLine("Usted ha cancelado su venta."); //Aviso de venta cancelada por el usuario
                                Environment.Exit(0);
                            }
                            else if (selectionMenu == "5")
                            {
                                Console.WriteLine("/////////////////IMPRIMIENDO//////////////////////"); //Loader imaginario de impresion
                                Producto ticketOnDemand = new Producto(ticketsQtyParced, productsQtyParced);
                                ticketOnDemand.ShowTemplateCompanyDataTicket(); //LLama a metodo para mostrar los productos ingresados
                                Console.WriteLine("Producto--------No.Articulos");
                                foreach (var productShow in productsList.GroupBy(x => x))
                                    Console.WriteLine($"{productShow.Key}      {productShow.Count()}");
                                float totalAddToCart = priceList.Sum();
                                Console.WriteLine("Total:          {0}", totalAddToCart);
                                ticketOnDemand.ShowTicket();
                                Environment.Exit(0);
                            }
                        }
                    }
                    while (selectionMenu == "1" || selectionMenu == "2");
                }
            }
            catch (IndexOutOfRangeException arrayException)
            {
                Console.WriteLine(arrayException);
            }
        }
    }
}
