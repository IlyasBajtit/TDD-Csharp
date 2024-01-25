using Bibliotheque.EX2;
namespace EX2.Test_Xunit;
public class FibTests
{

    [Fact]
    public void GetFibSeries_WhenCalled_ShouldNotReturnEmptyList()
    {
    
        var fib = new Fib(1);

      
        var result = fib.GetFibSeries();

       
        Assert.NotEmpty(result);
    }
    [Fact]
    public void GetFibSeries_WhenRangeIs1_ShouldReturnListWithOnlyZero()
    {
        var fib = new Fib(1);

        var result = fib.GetFibSeries();

        Assert.Single(result);
        Assert.Equal(0, result[0]);
    }

    [Fact]
    public void GetFibSeries_WhenRangeIs6_ShouldContainNumberThree()
    {
        var fib = new Fib(6);

        var result = fib.GetFibSeries();

        Assert.Contains(3, result);
    }

    [Fact]
    public void GetFibSeries_WhenRangeIs6_ShouldHaveSixElements()
    {
        var fib = new Fib(6);

        var result = fib.GetFibSeries();

        Assert.Equal(6, result.Count);
    }

    [Fact]
    public void GetFibSeries_WhenRangeIs6_ShouldNotContainNumberFour()
    {
        var fib = new Fib(6);

        var result = fib.GetFibSeries();

        Assert.DoesNotContain(4, result);
    }

    [Fact]
    public void GetFibSeries_WhenRangeIs6_ShouldReturnExpectedList()
    {
        var fib = new Fib(6);
        var expected = new List<int> { 0, 1, 1, 2, 3, 5 };

        var result = fib.GetFibSeries();

        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetFibSeries_WhenRangeIs6_ShouldBeSortedAscending()
    {
        var fib = new Fib(6);

        var result = fib.GetFibSeries();

        Assert.Equal(result, result.OrderBy(x => x));
    }


}