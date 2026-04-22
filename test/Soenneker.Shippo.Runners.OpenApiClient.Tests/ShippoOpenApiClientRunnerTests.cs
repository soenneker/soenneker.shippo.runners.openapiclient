using Soenneker.Tests.HostedUnit;

namespace Soenneker.Shippo.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ShippoOpenApiClientRunnerTests : HostedUnitTest
{
    public ShippoOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
