using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_32.Tests;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public void EmployeeConstructor_TwoParameterConstructorSuccess()
    {
        Employee employee = new("Inigo", "Montoya");
        
        Assert.AreEqual("Inigo", employee.FirstName);
        Assert.AreEqual("Montoya", employee.LastName);
    }
}
