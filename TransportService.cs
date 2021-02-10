using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class TransportService
    {
        private Transportation _transportFactory;
        public TransportService(Transportation transportation)
        {
            _transportFactory = transportation;
        }

        internal void GetTransport()
        {
            _transportFactory.DeliverTransport();
        }
    }
}
