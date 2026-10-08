namespace G_NET_101_OOP_05
{
    internal partial class Program
    {
        class DeliveryReport
        {
            public void PrintShipment(ITrackable shipment)
            {
                Console.WriteLine(shipment.GetTrackingStatus());
            }
            public void PrintInsurance(IInsurable shipment)
            {

                Console.WriteLine($"Insurance Cost: {shipment.CalculateInsurance()} EGP");

            }



        }
    }
}
