using AlbumPrinter.Domain.Commands;
using AutoFixture;
using FluentAssertions;

namespace AlbumPrinter.Domain.UnitTests.Commands;

public class CreateOrderCommandTests
{
    private Fixture _fixture;

    [SetUp]
    public void Setup()
    {
        _fixture = new Fixture();
    }

    [Test]
    public void GivenValidRequestShouldCreateCommand()
    {
        var orderId = _fixture.Create<string>();
        var productType = _fixture.Create<string>();
        var quantity = _fixture.Create<int>();

        var command = CreateOrderCommand.Create(orderId, productType, quantity);

        command.OrderId.Should().Be(orderId);
        command.ProductType.Should().Be(productType);
        command.Quantity.Should().Be(quantity);
    }

    [TestCaseSource(nameof(NullOrWhiteSpaceStrings))]
    public void GivenInvalidOrderIdShouldThrowException(string orderId)
    {
        var productType = _fixture.Create<string>();
        var quantity = _fixture.Create<int>();

        var act = () => CreateOrderCommand.Create(orderId, productType, quantity);

        act.Should().Throw<ArgumentException>();
    }

    public static IEnumerable<string> NullOrWhiteSpaceStrings => new List<string> { "", null, " " };
}