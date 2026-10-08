namespace G_NET_101_OOP_05
{
    
        class DeliveryAddress
        {
            private string city;
            private string street;
            private int buildingNumber;

            public string City
            {
                get { return city; }
                set { city = value; }
            }
            public string Street
            {
                get { return street; }
                set { street = value; }
            }
            public int BuildingNumber
            {
                get { return buildingNumber; }
                set { buildingNumber = value; }
            }
            public DeliveryAddress(string city, string street, int buildingNumber)
            {
                this.city = city;
                this.street = street;
                this.buildingNumber = buildingNumber;
            }
            public string GetFullAddress()
            {
                return $"{street}, {buildingNumber}, {city}";
            }

        }
    
}
