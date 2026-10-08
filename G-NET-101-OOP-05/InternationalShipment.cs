namespace G_NET_101_OOP_05
{
  
        #region ExpressShipment
        #endregion


        class InternationalShipment : Shipment, ITrackable, IInsurable
        {

            public override Shipment CopyShipment()
            {
                return new InternationalShipment(
                    TrackingCode,
                    Description,
                    Weight,
                    DeliveryFee,
                    Destination,
                    DestinationCountry,
                    CustomsFee
                );
            }

            public override Shipment DeepCopy()
            {
                return new InternationalShipment(
                    TrackingCode,
                    Description,
                    Weight,
                    DeliveryFee,
                    new DeliveryAddress(
                        Destination.City,
                        Destination.Street,
                        Destination.BuildingNumber
                    ),
                    DestinationCountry,
                    CustomsFee
                );
            }


            private string destinationCountry;
            private decimal customsFee;

            public string DestinationCountry
            {
                get { return destinationCountry; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        destinationCountry = value;
                }
            }

            public decimal CustomsFee
            {
                get { return customsFee; }
                set
                {
                    if (value >= 0)
                        customsFee = value;
                }
            }

            public override decimal EstimatedCost
            {
                get
                {
                    return DeliveryFee + ((decimal)Weight * 5) + CustomsFee;
                }
            }
            public decimal CalculateInsurance()
            {
                return EstimatedCost * 0.12m;
            }

           

            public InternationalShipment(
                string trackingCode,
                string description,
                double weight,
                decimal deliveryFee,
                DeliveryAddress destination,
                string destinationCountry,
                decimal customsFee)
                : base(trackingCode, description, weight, deliveryFee, destination)
            {
                DestinationCountry = destinationCountry;
                CustomsFee = customsFee;
            }

            public override void PrintShipment()
            {
                Console.WriteLine("International Shipment");
                Console.WriteLine();
                Console.WriteLine("Tracking Code        : " + TrackingCode);
                Console.WriteLine("Description          : " + Description);
                Console.WriteLine("Weight               : " + Weight + " KG");
                Console.WriteLine("Delivery Fee         : " + DeliveryFee + " EGP");
                Console.WriteLine("Destination Country  : " + DestinationCountry);
                Console.WriteLine("Customs Fee          : " + CustomsFee + " EGP");
                Console.WriteLine("Estimated Cost       : " + EstimatedCost + " EGP");

            }
        }
    
}
