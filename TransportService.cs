using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class TransportService
    {
        private Transportation _transportFactory;
        public TransportService(TransportationFactory transportationFactory)
        {
            _transportFactory = transportationFactory.GetTransportation();
        }

        private void GetTransport()
        {
            _transportFactory.DeliverTransport();
        }
    }
}
