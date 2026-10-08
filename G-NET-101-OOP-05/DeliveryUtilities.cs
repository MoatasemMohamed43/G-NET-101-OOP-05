namespace G_NET_101_OOP_05
{
    
        static class DeliveryUtilities
        {
            public static void PrintSeparator()
            {
                Console.WriteLine(new string('=', 30));
            }

            public static void PrintSystemTitle()
            {
                PrintSeparator();
                Console.WriteLine("Smart Delivery Management System");
                PrintSeparator();
            }
        }
    
}
