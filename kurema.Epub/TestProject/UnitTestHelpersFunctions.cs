using kurema.Epub.Helpers;

namespace TestProject;

public class UnitTestHelpersFunctions
{
    [Fact]
    public void Test1()
    {
        var array = new string[] { "First", "Second" };
        Functions.AddItemsToArray(ref array, "Third", "Forth", "Fifth");
        Assert.Equal(5, array.Length);
        Assert.Equal("Second", array[1]);
        Assert.Equal("Forth", array[3]);
    }

    [Fact]
    public void Test2()
    {
        string[]? array = null;
        Functions.AddItemsToArray(ref array, "First", "Second");
        Assert.Equal(2, array.Length);
        Assert.Equal("First", array[0]);
        Assert.Equal("Second", array[1]);
    }
}
