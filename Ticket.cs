using System;
using System.Collections.Generic;
using System.Text;

namespace SupermarketSystem
{
     abstract class Ticket
    {
        
        protected int ticketNo;
        protected int productsNo;

        //Finalizer de clase
       
        public Ticket(int ticketNO, int productsNO)
        {
            ticketNo = ticketNO;
            productsNo = productsNO;
        }
      
        public void ShowTemplateCompanyDataTicket() //Metodo mostrar top head the ticket
        {
            if (ticketNo >= 1)
            {
               
               Console.WriteLine("          S.A de C.V          ");
               Console.WriteLine("       RFC:LIOP85172X1        ");
               Console.WriteLine("  Colonia Florida,Benito Juarez CDMX");
               Console.WriteLine("       Tel:01 800 CHEDRAUI       ");
               Console.WriteLine("---------------------------------------");
               Console.WriteLine("        FACTURA DE CONSUMO           ");
               Console.WriteLine("---------------------------------------");
            }
            else
            {
               Console.WriteLine("Se agoto el papel impresor, por favor reemplacelo.");
            }
        }
        public abstract int ShowTicket();
     
        public int TicketDataInterface
        {
            get
            {
                return ticketNo;
            }
            set
            {
                ticketNo = value;
            }
        }
        public int ProductDataInterface
        {
            get
            {
                return productsNo;
            }
            set
            {
                productsNo = value;
            }
        }
        //Finalizer de clase
        ~Ticket()
        {
            productsNo = 0;
            ticketNo = 0;

        }
    }
}
