using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SupermarketSystem
{
    class Producto : Ticket
    {
        //Variables

        public Producto(int ticketNo, int productsNo) : base(ticketNo, productsNo) { }

       
        public override int ShowTicket()//Metodo mostrar cuerpo de ticket
        {
            try
            {
                string confirmationCode = "13-10-7852";
                string Card = "XXXX-XXXX-3049";
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Metodo de pago:    " + Card);
                Console.WriteLine("Approval Code       #" + confirmationCode);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("   Gracias por tu compra    ");
                Console.WriteLine("  Visita Chedraui.com.mx    ");
            }
            catch (IOException ioe)
            {
                throw new NotImplementedException();
                Console.WriteLine(ioe);
            }
            return base.productsNo;
        }
    }
}
