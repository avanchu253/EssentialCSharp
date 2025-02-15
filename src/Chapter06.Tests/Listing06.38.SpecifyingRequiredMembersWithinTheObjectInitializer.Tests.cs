using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_38.Tests;

#if NET7_0_OR_GREATER
[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task NotSpecifyingRequiredMembersWithinTheObjectInitializer()
    {
        await CompilerAssert.CompileAsync(
            new string[]{"Listing06.38.SpecifyingRequiredMembersWithinTheObjectInitializer.cs", "Listing06.37.RequiredProperties.cs"},
            new string[] { "CS9035" });
    }
}
#endif // NET7_0_OR_GREATER