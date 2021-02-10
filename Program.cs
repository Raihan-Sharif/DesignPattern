using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Transportation roadTransport = new RoadTransportation();
            TransportService transportService = new TransportService(roadTransport);

        }
    }
}
