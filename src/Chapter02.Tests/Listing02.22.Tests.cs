using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_22.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_WriteOverflowExample()
    {
        const string expected = "-2147483648";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
