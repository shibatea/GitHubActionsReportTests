namespace GitHubActionsReportTests.Tests;

using Xunit;

public class SampleClassTests
{
    private readonly SampleClass _sampleClass;

    public SampleClassTests()
    {
        _sampleClass = new SampleClass();
    }

    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange
        int a = 2;
        int b = 3;

        // Act
        int result = _sampleClass.Add(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    public void IsEven_ShouldReturnTrue_ForEvenNumbers(int number)
    {
        // Act
        bool result = _sampleClass.IsEven(number);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void IsEven_ShouldReturnFalse_ForOddNumbers(int number)
    {
        // Act
        bool result = _sampleClass.IsEven(number);

        // Assert
        Assert.False(result);
    }
}
