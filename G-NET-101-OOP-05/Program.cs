namespace G_NET_101_OOP_05
{
    internal partial class Program
    {


        static void Main(string[] args)
        {

            #region theoretical Qs

            #region Q1  Object Copying
            //a) What happens when you assign one object variable to another object variable?
            // both refer to the same object in memory and Changes in one variable will affect the other 

            //b) Does assigning one object to another create a new object? Explain.
            // No it creates a new reference to the same object in memory


            //c) What is the difference between copying an object and copying its reference?
            // Copying object creates a new instance of the object with the same values
            // copying reference creates a new reference to the same object in memory
            #endregion

            #region Q2  Shallow Copy vs Deep Copy

            //a) What is a Shallow Copy?
            //creating a new object that is a copy of the original object except reference type members 

            //b) What is a Deep Copy?
            //creating a new object that is a copy of the original object including reference type members

            //c) What happens to reference-type members when a Shallow Copy is created ?
            //original object and the copied object will refer to the same instance of the reference type member

            //d) What happens to reference-type members when a Deep Copy is created?
            //it will copied to a different place in memory 


            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            //when we change the reference type member in the copied object






            #endregion

            #region Q3  Static Members
            //a) What is a static field, and how is it different from an instance field?
            //static field belongs to the class itself and shared among all instances of the class
            //instance field belongs to a specific object and can have different values for each instance



            //b) What is a static method? Can a static method directly access instance members?
            //static method belongs to the class itself and can be called without creating an instance of the class
            //static method can't access instance members because it doesn't have a reference to a specific object


            //c) What is a static constructor, and when is it executed ?
            //a special constructor used to initialize static members of a class
            //executed only once 

            //d) What is a static class? Can you create an object from a static class?
            //a class that can only contain static members and can't be instantiated

            #endregion


            #endregion

            #region practical Qs

            DeliveryUtilities.PrintSystemTitle();

                Shipment.GetTotalShipmentsCreated();

                DeliveryUtilities.PrintSeparator();
                Console.WriteLine("Creating Shipments...");
                DeliveryUtilities.PrintSeparator();

                Shipment s1 = new StandardShipment("SH001", "Books", 3, 50m,
                    new DeliveryAddress("Cairo", "Tahrir St", 10));
                Console.WriteLine("Standard Shipment Created");

                Shipment s2 = new ExpressShipment("SH002", "Laptop", 2, 80m,
                    new DeliveryAddress("Alexandria", "Corniche", 5), 30m);
                Console.WriteLine("Express Shipment Created");

                Shipment s3 = new InternationalShipment("SH003", "Gift", 8, 150m,
                    new DeliveryAddress("Dubai", "Sheikh Zayed Rd", 20), "UAE", 100m);
                Console.WriteLine("International Shipment Created");

                s1.UpdateTrackingStatus("In Transit");
                s2.UpdateTrackingStatus("Out For Delivery");
                s3.UpdateTrackingStatus("Delivered");

                Console.WriteLine("Total Shipments Created : " + Shipment.GetTotalShipmentsCreated());

                //  Object Copying 
                DeliveryUtilities.PrintSeparator();
                Console.WriteLine("Object Copying");
                DeliveryUtilities.PrintSeparator();

                Shipment assigned = s1;
                Console.WriteLine("Original Shipment : " + s1.TrackingCode);
                Console.WriteLine("Assigned Shipment : " + assigned.TrackingCode);
                Console.WriteLine("Same Object : " + ReferenceEquals(s1, assigned));

                Shipment copy = s1.CopyShipment();
                Console.WriteLine("CopyShipment Same Object : " + ReferenceEquals(s1, copy));

                // Shallow Copy 
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Shallow Copy");
                Console.WriteLine("------------------------------------------");

                Shipment shallow = s1.ShallowCopy();
                Console.WriteLine("Original Shipment Address : " + s1.Destination.City);
                Console.WriteLine("Copied Shipment Address : " + shallow.Destination.City);
                Console.WriteLine("Changing copied shipment address...");
                shallow.Destination.City = "Giza";
                Console.WriteLine("Original Shipment Address : " + s1.Destination.City);
                Console.WriteLine("Copied Shipment Address : " + shallow.Destination.City);
                Console.WriteLine("Same DeliveryAddress Object : " + ReferenceEquals(s1.Destination, shallow.Destination));

                s1.Destination.City = "Cairo";  

                //Deep Copy
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Deep Copy");
                Console.WriteLine("------------------------------------------");

                Shipment deep = s1.DeepCopy();
                Console.WriteLine("Original Shipment Address : " + s1.Destination.City);
                Console.WriteLine("Copied Shipment Address : " + deep.Destination.City);
                Console.WriteLine("Changing copied shipment address...");
                deep.Destination.City = "Giza";
                Console.WriteLine("Original Shipment Address : " + s1.Destination.City);
                Console.WriteLine("Copied Shipment Address : " + deep.Destination.City);
                Console.WriteLine("Same DeliveryAddress Object : " + ReferenceEquals(s1.Destination, deep.Destination));

                //  Extension Methods 
                DeliveryUtilities.PrintSeparator();
                Console.WriteLine("Extension Methods");
                DeliveryUtilities.PrintSeparator();

                Console.WriteLine(s1.GetSummary());
                Console.WriteLine(s2.GetSummary());
                Console.WriteLine(s3.GetSummary());
                Console.WriteLine(s1.TrackingCode + " Is Delivered : " + s1.IsDelivered());
                Console.WriteLine(s3.TrackingCode + " Is Delivered : " + s3.IsDelivered());

                // Tracking Status
                DeliveryUtilities.PrintSeparator();
                Console.WriteLine("Tracking Status");
                DeliveryUtilities.PrintSeparator();

                s2.UpdateTrackingStatus("Out For Delivery");

                //Static Utilities 
                DeliveryUtilities.PrintSeparator();
                Console.WriteLine("Static Utilities");
                DeliveryUtilities.PrintSeparator();

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Delivery Center");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Total Shipments Created : " + Shipment.GetTotalShipmentsCreated());

                //Partial Method
                DeliveryUtilities.PrintSeparator();
                Console.WriteLine("Partial Method");
                DeliveryUtilities.PrintSeparator();

                s3.UpdateTrackingStatus("Delivered");

                //Assignment 04 still works
                DeliveryUtilities.PrintSeparator();
                Console.WriteLine("Assignment 04 Features");
                DeliveryUtilities.PrintSeparator();

                DeliveryCenter center = new DeliveryCenter("Main Center");
                center.AddShipment(s1);
                center.AddShipment(s2);
                center.AddShipment(s3);
                center.PrintAllShipments();
                center.PrintTrackingStatuses();

                DeliveryReport report = new DeliveryReport();
                report.PrintInsurance((IInsurable)s1);

                DeliveryUtilities.PrintSeparator();
                Console.WriteLine("Assignment Completed");
                DeliveryUtilities.PrintSeparator();
            
            #endregion
        }
    }
}
