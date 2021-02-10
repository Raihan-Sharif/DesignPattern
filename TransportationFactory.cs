using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal abstract class TransportationFactory 
    {
        internal abstract Transportation GetTransportation();
    }
}
