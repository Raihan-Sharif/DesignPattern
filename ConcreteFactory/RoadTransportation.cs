using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class RoadTransportation : Transportation
    {
        internal override void DeliverTransport()
        {
            Console.WriteLine("Truck");
        }
    }
}
