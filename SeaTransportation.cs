using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class SeaTransportation : Transportation
    {
        internal override void DeliverTransport()
        {
            Console.WriteLine("Ship");
        }
    }
}
