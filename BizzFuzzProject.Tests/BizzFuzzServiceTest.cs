using BizzFuzzProject;
using NUnit.Framework;

namespace BizzFuzzProject.Tests;

[TestFixture]
[TestOf(typeof(BizzFuzzService))]
public class BizzFuzzServiceTest
{

    [Test]
    public void Return_Number()
    {
        BizzFuzzService service = new BizzFuzzService();
        var result = BizzFuzzService.Query(1);
        Assert.That("1", Is.EqualTo(result));
    }

    [Test]
    public void Return_Bizz()
    {
        var result = BizzFuzzService.Query(3);
        Assert.That(result, Is.EqualTo("Bizz"));
    }
}