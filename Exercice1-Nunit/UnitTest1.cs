namespace Exercice1_Nunit;
using NUnit.Framework;
using Exercice1.Bibliotheque;

[TestFixture]
public class GradingCalculatorTests
{
    private GradingCalculator _calculator;


    [Test]
    public void GetGrade_WhenScoreIs95AndAttendanceIs90_ShouldReturnA()
    {
        var  _calculator = new GradingCalculator { Score = 95, AttendancePercentage = 90 };
        var result = _calculator.GetGrade();
        Assert.That(result, Is.EqualTo('A'));
    }
    [Test]
    public void GetGrade_WhenScoreIs85AndAttendanceIs90_ShouldReturnB()
    {
        var _calculator = new GradingCalculator { Score = 85, AttendancePercentage = 90 };
        var result = _calculator.GetGrade();
        Assert.That(result, Is.EqualTo('B'));
    }

    [Test]
    public void GetGrade_WhenScoreIs65AndAttendanceIs90_ShouldReturnC()
    {
        var _calculator = new GradingCalculator { Score = 65, AttendancePercentage = 90 };
        var result = _calculator.GetGrade();
        Assert.That(result, Is.EqualTo('C'));
    }

    [Test]
    public void GetGrade_WhenScoreIs95AndAttendanceIs65_ShouldReturnB()
    {
        var _calculator = new GradingCalculator { Score = 95, AttendancePercentage = 65 };
        var result = _calculator.GetGrade();
        Assert.That(result, Is.EqualTo('B'));
    }
    [Test]
    public void GetGrade_WhenScoreIs95AndAttendanceIs55_ShouldReturnF()
    {
        var _calculator = new GradingCalculator { Score = 95, AttendancePercentage = 55 };
        var result = _calculator.GetGrade();
        Assert.That(result, Is.EqualTo('F'));
    }

    [Test]
    public void GetGrade_WhenScoreIs65AndAttendanceIs55_ShouldReturnF()
    {
        var _calculator = new GradingCalculator { Score = 65, AttendancePercentage = 55 };
        var result = _calculator.GetGrade();
        Assert.That(result, Is.EqualTo('F'));
    }

    [Test]
    public void GetGrade_WhenScoreIs50AndAttendanceIs90_ShouldReturnF()
    {
        var _calculator = new GradingCalculator { Score = 50, AttendancePercentage = 90 };

        var result = _calculator.GetGrade();
        Assert.That(result, Is.EqualTo('F'));
    }
}
