namespace app.Tests;

public class UnitTest1
{
    [Fact]
    public void TestProcessInput_WithBasicInput()
    {
        // Arrange
        var processor = new Processor();
        string input = "227#";

        // Act
        string result = processor.ProcessInput(input);

        // Assert
        Assert.Equal("BP", result);
    }

    [Fact]
    public void TestProcessInput_WithDeleteCharacter()
    {
        // Arrange
        var processor = new Processor();
        string input = "227*#";

        // Act
        string result = processor.ProcessInput(input);

        // Assert
        Assert.Equal("B", result);
    }

    [Fact]
    public void TestProcessInput_WithFinalizeCharacter()
    {
        // Arrange
        var processor = new Processor();
        string input = "8 88777444666*664#";

        // Act
        string result = processor.ProcessInput(input);

        // Assert
        Assert.Equal("TURING", result);
    }

    [Fact]
    public void TestProcessInput_WithSpaceCharacter()
    {
        // Arrange
        var processor = new Processor();
        string input = "4433 555 555666#”";

        // Act
        string result = processor.ProcessInput(input);

        // Assert
        Assert.Equal("HELLO", result);
    }
}