
public class UnitTest1
{
    [Fact]
    public void FullName_ReturnsExpectedFormat()
    {
        Person person = new Person("Yufei", "Wang", 20);

        string result = person.FullName();

        Assert.Equal("Wang, Yufei", result);
    }

    [Fact]
    public void IsAdult_ReturnsTrue_WhenAge18OrMore()
    {
        Person person = new Person("Yufei", "Wang", 20);

        bool result = person.IsAdult();

        Assert.True(result);
    }
}