namespace G_NET_101_OOP_05
{
    abstract partial class Shipment : ITrackable
    {
        private string trackingStatus = "Ready";

        public string TrackingStatus
        {
            get { return trackingStatus; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingStatus = value;
            }
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is {TrackingStatus}.";
        }

        partial void OnTrackingStatusChanged(string newStatus);

        public void UpdateTrackingStatus(string newStatus)
        {
            TrackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus);  
        }
    }
}