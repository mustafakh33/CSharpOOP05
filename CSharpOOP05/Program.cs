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

            #endregion
        }
    }
}
