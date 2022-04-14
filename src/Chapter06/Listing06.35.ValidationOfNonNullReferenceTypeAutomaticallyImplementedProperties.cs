namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_35
{
    using System;

    #region INCLUDE
    public class Employee
    {
        public Employee(string name)
        {
            #region HIGHLIGHT
            Name = name ?? throw new ArgumentNullException(nameof(name));
            #endregion
        }

        #region HIGHLIGHT
        public string Name { get; }
        #endregion
    }
    #endregion
}
