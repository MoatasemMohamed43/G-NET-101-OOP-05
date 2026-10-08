namespace G_NET_101_OOP_05
{
    internal partial class Program
    {
        #region StandardShipment class

        #endregion

        class ExpressShipment : Shipment, ITrackable, IInsurable
        {
            public override Shipment CopyShipment()
            {
                return new ExpressShipment(
                    TrackingCode,
                    Description,
                    Weight,
                    DeliveryFee,
                    Destination,
                    ExtraFee
                );
            }

            public override Shipment DeepCopy()
            {
                return new ExpressShipment(
                    TrackingCode,
                    Description,
                    Weight,
                    DeliveryFee,
                    new DeliveryAddress(
                        Destination.City,
                        Destination.Street,
                        Destination.BuildingNumber
                    ),
                    ExtraFee
                );
            }

            private decimal extraFee;

            public decimal ExtraFee
            {
                get { return extraFee; }
                set
                {
                    if (value >= 0)
                        extraFee = value;
                }
            }

            public override decimal EstimatedCost
            {
                get
                {
                    return DeliveryFee + ((decimal)Weight * 5) + ExtraFee;
                }
            }
            public decimal CalculateInsurance()
            {
                return EstimatedCost * 0.08m;
            }

            public string GetTrackingStatus()
            {
                return $"Shipment {TrackingCode} is Out for Delivery.";
            }

            public ExpressShipment(
                string trackingCode,
                string description,
                double weight,
                decimal deliveryFee,
                DeliveryAddress destination,
                decimal extraFee)
                : base(trackingCode, description, weight, deliveryFee, destination)
            {
                ExtraFee = extraFee;
            }

            public override void PrintShipment()
            {
                Console.WriteLine("Express Shipment");
                Console.WriteLine();
                Console.WriteLine("Tracking Code : " + TrackingCode);
                Console.WriteLine("Description   : " + Description);
                Console.WriteLine("Weight        : " + Weight + " KG");
                Console.WriteLine("Delivery Fee  : " + DeliveryFee + " EGP");
                Console.WriteLine("Extra Fee     : " + ExtraFee + " EGP");
                Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
            }
        }
    }
}
