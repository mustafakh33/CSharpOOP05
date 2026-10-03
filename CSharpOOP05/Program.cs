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
            #endregion
        }
    }
}
