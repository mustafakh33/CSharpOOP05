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
            #endregion
        }
    }
}
