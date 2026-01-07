using Northwind.DataContext;
using Northwind.EntityModels; // To use NorthwindContext and Product.

namespace Northwind.Tests;

public class NorthwindEntityModelsTests
{
    [Fact]
    public void DatabaseConnectTest()
    {
        using NorthwindContext db = new();
        Assert.True(db.Database.CanConnect());
    }

    [Fact]
    public void CategoryCountTest()
    {
        using NorthwindContext db = new();
        const int expected = 8;
        var actual = db.Categories.Count();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ProductId1IsChaiTest()
    {
        using NorthwindContext db = new();
        const string expected = "Chai";
        Product? product = db?.Products?.Single(p => p.ProductId == 1);
        var actual = product?.ProductName ?? string.Empty;
        Assert.Equal(expected, actual);
    }
}
