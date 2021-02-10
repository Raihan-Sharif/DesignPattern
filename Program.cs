using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Transportation transport = new RoadTransportation();
            TransportService transportService = new TransportService(transport);
            transportService.GetTransport();

            transport = new SeaTransportation();
            transportService = new TransportService(transport);
            transportService.GetTransport();
        }
    }
}
