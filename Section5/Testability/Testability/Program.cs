using System;


namespace Testability
{
    public class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 10f };
            orderProcessor.Process(order);
            Console.WriteLine("order shipment cost {0}, order shipment shippingDate {1}",order.Shipment.Cost,order.Shipment.ShippingDate);
        }
    }
}
