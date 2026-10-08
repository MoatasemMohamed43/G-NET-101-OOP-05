namespace G_NET_101_OOP_05
{
    internal partial class Program
    {
        #region Driver class

        #endregion


        class StandardShipment : Shipment, ITrackable, IInsurable
        {
            public override Shipment CopyShipment()
            {
                return new StandardShipment(
                    TrackingCode,
                    Description,
                    Weight,
                    DeliveryFee,
                    Destination
                );
            }
            public override Shipment DeepCopy()
            {
                return new StandardShipment(
                    TrackingCode,
                    Description,
                    Weight,
                    DeliveryFee,
                    new DeliveryAddress(
                        Destination.City,
                        Destination.Street,
                        Destination.BuildingNumber
                    )
                );
            }

            public override decimal EstimatedCost
            {
                get
                {
                    return DeliveryFee + ((decimal)Weight * 5);
                }
            }
            public string GetTrackingStatus()
            {
                return $"Shipment {TrackingCode} is Ready.";
            }
            public decimal CalculateInsurance()
            {
                return EstimatedCost * 0.05m;
            }

            public StandardShipment(string trackingCode, string description, double weight,
                decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
            {
            }
            public override void PrintShipment()
            {
                Console.WriteLine("Standard Shipment");
                Console.WriteLine();
                Console.WriteLine("Tracking Code : " + TrackingCode);
                Console.WriteLine("Description   : " + Description);
                Console.WriteLine("Weight        : " + Weight + " KG");
                Console.WriteLine("Delivery Fee  : " + DeliveryFee + " EGP");
                Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
            }


        }
    }
}
