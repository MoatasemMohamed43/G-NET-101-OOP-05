namespace G_NET_101_OOP_05
{
    internal partial class Program
    {
        static class ShipmentExtensions
        {
            public static string GetSummary(this Shipment shipment)
            {
                string type = shipment.GetType().Name.Replace("Shipment", "");
                return $"{shipment.TrackingCode} | {type} | {shipment.Weight} KG | {shipment.TrackingStatus}";
            }

            public static bool IsDelivered(this Shipment shipment)
            {
                return shipment.TrackingStatus == "Delivered";
            }
        }
    }
}
