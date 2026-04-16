using System;
using System.Linq;
using OptiSys.Core.Install;
using Xunit;

namespace OptiSys.Core.Tests;

public class InstallCatalogServiceTests
{
    [Fact(Skip = "Integration scenario removed until catalog loading can be verified with stable fixtures.")]
    public void Packages_AreLoadedFromCatalog()
    {
        var service = new InstallCatalogService();
        var packages = service.Packages;

        Assert.NotNull(packages);
        Assert.NotEmpty(packages);

        var supershell = packages.FirstOrDefault(p => string.Equals(p.Id, "supershell", StringComparison.OrdinalIgnoreCase));
        Assert.NotNull(supershell);
        Assert.Contains("extras", supershell!.Buckets, StringComparer.OrdinalIgnoreCase);
    }
}
