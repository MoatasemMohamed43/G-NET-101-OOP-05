namespace G_NET_101_OOP_05
{
    internal partial class Program
    {
        abstract class Shipment
        {
            private string trackingCode;
            private string description;
            private double weight;
            private decimal deliveryFee;
            private DeliveryAddress destination;

            public Shipment ShallowCopy()
            {
                return (Shipment)this.MemberwiseClone();
            }

            public abstract Shipment DeepCopy();

            private string trackingStatus = "Ready";

            public string TrackingStatus
            {
                get { return trackingStatus; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        trackingStatus = value;
                }
            }



            public DeliveryAddress Destination
            {
                get { return destination; }
                set { destination = value; }
            }

            public string TrackingCode
            {
                get { return trackingCode; }
                private set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        trackingCode = value;
                }
            }

            public string Description
            {
                get { return description; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        description = value;
                }
            }

            public double Weight
            {
                get { return weight; }
                set
                {
                    if (value > 0)
                        weight = value;
                }
            }

            public decimal DeliveryFee
            {
                get { return deliveryFee; }
                private set
                {
                    if (value > 0)
                        deliveryFee = value;
                }
            }

            public abstract decimal EstimatedCost { get; }

            public Shipment(string trackingCode)
            {
                this.trackingCode = null;
                this.description = null;
                this.weight = 0;
                this.deliveryFee = 0;
                this.destination = default;

                TrackingCode = trackingCode;
                Description = "Unknown";
                Weight = 1;
                DeliveryFee = 50;
            }

            public Shipment(
                string trackingCode,
                string description,
                double weight,
                decimal deliveryFee,
                DeliveryAddress destination)
            {
                this.trackingCode = null;
                this.description = null;
                this.weight = 0;
                this.deliveryFee = 0;
                this.destination = default;

                TrackingCode = trackingCode;
                Description = description;
                Weight = weight;
                DeliveryFee = deliveryFee;
                Destination = destination;
            }

            private static int totalShipmentsCreated;

            static Shipment()
            {
                totalShipmentsCreated = 0;
                Console.WriteLine("Shipment class initialized.");
            }


            public void UpdateDeliveryFee(decimal newFee)
            {
                if (newFee > 0)
                    DeliveryFee = newFee;
            }

            public abstract void PrintShipment();

            public abstract Shipment CopyShipment();


            public void UpdateWeight(double newWeight)
            {
                Weight = newWeight;
            }
            public void UpdateWeight(double newWeight, double extraPackingWeight)
            {
                Weight = newWeight + extraPackingWeight;
            }

            public static int GetTotalShipmentsCreated()
            {
                return totalShipmentsCreated;
            }

        }
    }
}
