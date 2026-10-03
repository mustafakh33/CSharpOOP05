using CSharpOOP05.@class;
using CSharpOOP05.ExtensionMethods;

namespace CSharpOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Q1  Object Copying
            // a) What happens when you assign one object variable to another object variable?
            // When one object variable is assigned to another, the reference to the object is copied.
            // Both variables will refer to the same object in memory.

            // b) Does assigning one object to another create a new object? Explain.
            // No, assigning one object variable to another does not create a new object.
            // It only copies the reference, so both variables refer to the same object in memory.

            // c) What is the difference between copying an object and copying its reference ?
            // Copying a reference means that two variables refer to the same object.
            // Copying an object means creating a new object and copying the data from the original object.
            // The two objects have different references and can be modified independently.
            #endregion

            #region Q2  Shallow Copy vs Deep Copy
            // a) What is a Shallow Copy?
            // A Shallow Copy creates a new object, but copies the references of reference-type members.
            // Therefore, the original object and the copy may share the same referenced objects.

            // b) What is a Deep Copy?
            // A Deep Copy creates a new object and also creates independent copies of its reference-type members.
            // Therefore, the original object and the copy are completely independent.

            // c) What happens to reference-type members when a Shallow Copy is created?
            // The references are copied, not the referenced objects.
            // As a result, both the original and the copied object refer to the same reference-type objects.

            // d) What happens to reference-type members when a Deep Copy is created?
            // New copies of the referenced objects are created.
            // As a result, the original and copied objects have independent reference-type members.

            // e) Give one situation where Deep Copy would be safer than Shallow Copy.
            // Deep Copy would be safer when we need to modify a copied object's reference-type members
            // without affecting the original object, such as copying a Person with an Address.

            #endregion

            #region Q3  Static Members

            // a) What is a static field, and how is it different from an instance field?
            // A static field belongs to the class itself and has only one shared copy for all objects.
            // An instance field belongs to a specific object, so each object has its own copy.

            // b) What is a static method? Can a static method directly access instance members?
            // A static method belongs to the class rather than to a specific object.
            // A static method cannot directly access instance members because it is not associated with a specific object.
            // It can access instance members through an object reference.

            // c) What is a static constructor, and when is it executed?
            // A static constructor is used to initialize static members of a class.
            // It has no access modifier and no parameters.
            // It is executed automatically by the runtime before the type is first used or its static members are accessed.
            // It is executed only once.

            // d) What is a static class? Can you create an object from a static class?
            // A static class is a class that cannot be instantiated and can contain only static members.
            // No, you cannot create an object from a static class.
            // Static classes are accessed directly through the class name.

            #endregion

            #region Q4 — Extension Methods

            // a) What is an Extension Method?
            // An Extension Method allows us to add new functionality to an existing type
            // without modifying its source code or creating a derived class.

            // b) What keyword must be used in the first parameter of an extension method?
            // The "this" keyword must be used in the first parameter of an extension method.
            // It specifies the type that the method extends.

            // c) Where must an extension method be declared?
            // An extension method must be declared as a static method inside a static class.

            // d) Can an extension method access private members of the class it extends?
            // No, an extension method cannot directly access private members of the type it extends.
            // It can only access members that are accessible to it, such as public members.

            #endregion

            #region Q5 — Partial Classes & Partial Methods

            // a) What is a Partial Class?
            // A Partial Class is a class whose definition can be divided into multiple parts.
            // All parts are combined by the compiler and treated as one class.

            // b) Why would a developer split one class into multiple files?
            // A developer may split a class into multiple files to keep the code organized,
            // easier to read and maintain, and to allow multiple developers to work on different parts.

            // c) What is a Partial Method?
            // A Partial Method is a method that can be declared in one part of a partial class
            // and implemented in another part of the same class.

            // d) What happens if a declared partial method has no implementation?
            // If a partial method has no implementation, the compiler removes the method declaration
            // and calls to it from the compiled code, so no runtime call occurs.

            #endregion

            #endregion

            #region Part 02 — Practical
            #region Q1  Object Copying
            //Shipment shipment1 = new StandardShipment("TRK001", "Package 1", 10.5m, 25.0m, new DeliveryAddress("New York", "Main Street", 123));
            //Console.WriteLine("=== Object Copying ===");

            //Shipment shipment2 = shipment1;

            //Console.WriteLine("Reference Assignment:");
            //Console.WriteLine($"shipment1 == shipment2: {ReferenceEquals(shipment1, shipment2)}");

            //Shipment shipment3 = shipment1.CopyShipment();

            //Console.WriteLine();

            //Console.WriteLine("Actual Copy:");
            //Console.WriteLine($"shipment1 == shipment3: {ReferenceEquals(shipment1, shipment3)}");
            #endregion

            #region Q2  Shallow Copy
            //StandardShipment shipment1 = new StandardShipment(
            //    "SH001",
            //    "Laptop",
            //    3m,
            //    50m,
            //    new DeliveryAddress("Cairo", "Nasr City", 10)
            //);
            //Shipment shipment2 = shipment1.ShallowCopy();
            //Console.WriteLine("=== Shallow Copy ===");
            //Console.WriteLine($"Same Shipment object? {ReferenceEquals(shipment1, shipment2)}");

            //Console.WriteLine();
            //Console.WriteLine("Before modifying the copied shipment's destination:");
            //Console.WriteLine($"Original: {shipment1.Destination.GetFullAddress()}");
            //Console.WriteLine($"Copied  : {shipment2.Destination.GetFullAddress()}");

            //shipment2.Destination.City = "Giza";
            //Console.WriteLine();
            //Console.WriteLine("After modifying the copied shipment's destination:");
            //Console.WriteLine($"Original: {shipment1.Destination.GetFullAddress()}");
            //Console.WriteLine($"Copied  : {shipment2.Destination.GetFullAddress()}");
            #endregion

            #region Q3  Deep Copy
            //StandardShipment shipment1 = new StandardShipment(
            //    "SH001",
            //    "Laptop",
            //    3m,
            //    50m,
            //    new DeliveryAddress("Cairo", "Nasr City", 10)
            //);

            //Shipment shipment2 = shipment1.DeepCopy();

            //Console.WriteLine("=== Deep Copy ===");

            //Console.WriteLine(
            //    $"Same Shipment object? {ReferenceEquals(shipment1, shipment2)}"
            //);

            //Console.WriteLine(
            //    $"Same DeliveryAddress object? " +
            //    $"{ReferenceEquals(shipment1.Destination, shipment2.Destination)}"
            //);

            //Console.WriteLine();

            //Console.WriteLine("Before change:");

            //Console.WriteLine(
            //    $"Original: {shipment1.Destination.GetFullAddress()}"
            //);

            //Console.WriteLine(
            //    $"Copied  : {shipment2.Destination.GetFullAddress()}"
            //);

            //Console.WriteLine();

            //shipment2.Destination.City = "Giza";
            //shipment2.Destination.Street = "6th of October";
            //shipment2.Destination.BuildingNumber = 20;

            //Console.WriteLine("After changing copied address:");

            //Console.WriteLine(
            //    $"Original: {shipment1.Destination.GetFullAddress()}"
            //);

            //Console.WriteLine(
            //    $"Copied  : {shipment2.Destination.GetFullAddress()}"
            //);
            #endregion

            #region Q4  Static Field
            //StandardShipment shipment1 = new StandardShipment(
            //    "SH001",
            //    "Laptop",
            //    3m,
            //    50m,
            //    new DeliveryAddress("Cairo", "Nasr City", 10)
            // );

            //ExpressShipment shipment2 = new ExpressShipment(
            //    "SH002",
            //    "Phone",
            //    2m,
            //    70m,
            //    new DeliveryAddress("Giza", "Dokki", 20),
            //    30m
            //);

            //InternationalShipment shipment3 = new InternationalShipment(
            //    "SH003",
            //    "Monitor",
            //    5m,
            //    100m,
            //    new DeliveryAddress("Cairo", "Maadi", 15),
            //    "USA",
            //    50m
            //);
            //Console.WriteLine($"Total Shipments Created: {Shipment.TotalShipmentsCreated}");
            #endregion

            #region Q5  Static Constructor
            //Console.WriteLine("Program Started");

            //StandardShipment shipment1 = new StandardShipment(
            //    "SH001",
            //    "Laptop",
            //    3m,
            //    50m,
            //    new DeliveryAddress("Cairo", "Nasr City", 10)
            //);

            //ExpressShipment shipment2 = new ExpressShipment(
            //    "SH002",
            //    "Phone",
            //    2m,
            //    70m,
            //    new DeliveryAddress("Giza", "Dokki", 20),
            //    30m
            //);
            #endregion

            #region Q6  Static Method
            //Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");
            //#endregion

            //#region Q7  Static Class
            //DeliveryUtilities.PrintSystemTitle();
            //DeliveryUtilities.PrintSystemTitle();
            //#endregion

            //#region Q8   Extension Methods
            //Console.WriteLine(shipment1.GetSummary());

            //Console.WriteLine(shipment1.IsDelivered());
            #endregion

            #region Q9   Partial Shipment Class
            //Shipment partialShipment = new StandardShipment(
            //      "TRK-Q9",
            //      "Partial Shipment Test",
            //      10m,
            //      100m,
            //     new DeliveryAddress("Cairo", "Nasr City", 10)
            // );

            //Console.WriteLine($"Tracking Code: {partialShipment.TrackingCode}");
            //Console.WriteLine($"Tracking Status: {partialShipment.GetTrackingStatus()}");

            //partialShipment.UpdateTrackingStatus("Delivered");

            //Console.WriteLine($"Updated Status: {partialShipment.GetTrackingStatus()}");

            #endregion

            #region Q10  Partial Method
            //Console.WriteLine();
            //shipment1.UpdateTrackingStatus("Out For Delivery");
            //Console.WriteLine(shipment1.GetTrackingStatus());
            #endregion

            #region Q11  Main() Checklist
                // ==============================
                // Creating Shipments
                // ==============================

                DeliveryUtilities.PrintSystemTitle();

                Console.WriteLine("Creating Shipments...");
                DeliveryUtilities.PrintSeparator();

                StandardShipment shipment1 = new StandardShipment(
                    "SH001",
                    "Standard Shipment",
                    3,
                    50,
                    new DeliveryAddress("Cairo", "Main Street", 10)
                );

                ExpressShipment shipment2 = new ExpressShipment(
                    "SH002",
                    "Express Shipment",
                    2,
                    60,
                    new DeliveryAddress("Cairo", "Nasr City", 20),
                    30
                );

                InternationalShipment shipment3 = new InternationalShipment(
                    "SH003",
                    "International Shipment",
                    8,
                    100,
                    new DeliveryAddress("Cairo", "Downtown", 15),
                    "USA",
                    50
                );

                Console.WriteLine("Standard Shipment Created");
                Console.WriteLine("Express Shipment Created");
                Console.WriteLine("International Shipment Created");

                Console.WriteLine();

                Console.WriteLine(
                    $"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}"
                );


                // ==============================
                // Object Copying
                // ==============================

                DeliveryUtilities.PrintSystemTitle();

                Console.WriteLine("Object Copying");

                Shipment assignedShipment = shipment1;

                Console.WriteLine(
                    $"Original Shipment  : {shipment1.TrackingCode}"
                );

                Console.WriteLine(
                    $"Assigned Shipment  : {assignedShipment.TrackingCode}"
                );

                Console.WriteLine();

                Console.WriteLine(
                    $"Same Object : {ReferenceEquals(shipment1, assignedShipment)}"
                );


                // ==============================
                // Shallow Copy
                // ==============================

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine("Shallow Copy");

                Shipment shallowCopy = shipment1.ShallowCopy();

                Console.WriteLine(
                    $"Original Shipment Address : {shipment1.Destination.City}"
                );

                Console.WriteLine(
                    $"Copied Shipment Address   : {shallowCopy.Destination.City}"
                );

                Console.WriteLine();

                Console.WriteLine("Changing copied shipment address...");

                shallowCopy.Destination.City = "Giza";

                Console.WriteLine();

                Console.WriteLine(
                    $"Original Shipment Address : {shipment1.Destination.City}"
                );

                Console.WriteLine(
                    $"Copied Shipment Address   : {shallowCopy.Destination.City}"
                );

                Console.WriteLine();

                Console.WriteLine(
                    $"Same DeliveryAddress Object : " +
                    $"{ReferenceEquals(shipment1.Destination, shallowCopy.Destination)}"
                );


                // ==============================
                // Deep Copy
                // ==============================

                shipment1.Destination.City = "Cairo";

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine("Deep Copy");

                Shipment deepCopy = shipment1.DeepCopy();

                Console.WriteLine(
                    $"Original Shipment Address : {shipment1.Destination.City}"
                );

                Console.WriteLine(
                    $"Copied Shipment Address   : {deepCopy.Destination.City}"
                );

                Console.WriteLine();

                Console.WriteLine("Changing copied shipment address...");

                deepCopy.Destination.City = "Giza";

                Console.WriteLine();

                Console.WriteLine(
                    $"Original Shipment Address : {shipment1.Destination.City}"
                );

                Console.WriteLine(
                    $"Copied Shipment Address   : {deepCopy.Destination.City}"
                );

                Console.WriteLine();

                Console.WriteLine(
                    $"Same DeliveryAddress Object : " +
                    $"{ReferenceEquals(shipment1.Destination, deepCopy.Destination)}"
                );


                // ==============================
                // Extension Methods
                // ==============================

                DeliveryUtilities.PrintSystemTitle();

                Console.WriteLine("Extension Methods");
                DeliveryUtilities.PrintSeparator();

                Console.WriteLine(shipment1.GetSummary());
                Console.WriteLine(shipment2.GetSummary());
                Console.WriteLine(shipment3.GetSummary());

                Console.WriteLine();

                Console.WriteLine(
                    $"SH001 Is Delivered : {shipment1.IsDelivered()}"
                );

                Console.WriteLine(
                    $"SH003 Is Delivered : {shipment3.IsDelivered()}"
                );


                // ==============================
                // Tracking Status
                // ==============================

                DeliveryUtilities.PrintSystemTitle();

                Console.WriteLine("Tracking Status");
                DeliveryUtilities.PrintSeparator();

                shipment1.UpdateTrackingStatus("Out For Delivery");


                // ==============================
                // Static Utilities
                // ==============================

                DeliveryUtilities.PrintSystemTitle();

                Console.WriteLine("Static Utilities");

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine("Delivery Center");

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine(
                    $"Total Shipments Created : " +
                    $"{Shipment.GetTotalShipmentsCreated()}"
                );


                // ==============================
                // Partial Method
                // ==============================

                DeliveryUtilities.PrintSystemTitle();

                Console.WriteLine("Partial Method");
                DeliveryUtilities.PrintSeparator();

                shipment1.UpdateTrackingStatus("Delivered");


                // ==============================
                // Completed
                // ==============================

                DeliveryUtilities.PrintSystemTitle();

                Console.WriteLine("Assignment Completed");

                DeliveryUtilities.PrintSeparator();
            #endregion
            #endregion
        }
    }
}
