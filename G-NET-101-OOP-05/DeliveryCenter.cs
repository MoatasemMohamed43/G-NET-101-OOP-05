namespace G_NET_101_OOP_05
{
    
        class DeliveryCenter
        {
            private Shipment[] shipments;

            public string CenterName { get; set; }
            public Driver Driver { get; set; }

            public Shipment[] Shipments
            {
                get { return shipments; }
            }

            public DeliveryCenter(string centerName)
            {
                CenterName = centerName;
                shipments = new Shipment[20];
            }

            public void AddShipment(Shipment shipment)
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] == null)
                    {
                        shipments[i] = shipment;
                        return;
                    }
                }
            }
            public Shipment this[string trackingCode]
            {
                get
                {
                    for (int i = 0; i < shipments.Length; i++)
                    {
                        if (shipments[i] != null &&
                            shipments[i].TrackingCode == trackingCode)
                        {
                            return shipments[i];
                        }
                    }

                    return null;
                }
            }

            public bool RemoveShipment(string trackingCode)
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null &&
                        shipments[i].TrackingCode == trackingCode)
                    {
                        shipments[i] = null;
                        return true;
                    }
                }

                return false;
            }

            public void PrintAllShipments()
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null)
                    {
                        shipments[i].PrintShipment();
                        Console.WriteLine("===============");
                    }
                }
            }

            public void PrintTrackingStatuses()
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null)
                    {
                        Console.WriteLine(((ITrackable)shipments[i]).GetTrackingStatus());
                    }
                }
            }



        }
    
}
