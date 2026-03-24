using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Shippo.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class ShippoOpenApiClientRunnerTests : FixturedUnitTest
{
    public ShippoOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
