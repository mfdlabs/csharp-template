namespace Template.Unit;

#pragma warning disable CA1707 // Identifiers should not contain underscores

public class TemplateTest
{
    [Fact]
    public void HelloWorld_ShouldReturnMessage()
    {
        var result = Example.HelloWorld();

        result.Should().Be("Hello, World!");
    }
}

#pragma warning restore CA1707 // Identifiers should not contain underscores
