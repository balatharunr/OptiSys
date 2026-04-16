using System.Threading.Tasks;
using OptiSys.Core.Automation;
using OptiSys.Core.PackageManagers;
using Xunit;

namespace OptiSys.Core.Tests.PackageManagers;

public sealed class PackageManagerInstallerTests
{
    [Fact(Skip = "Integration test")] // skip by default
    public async Task InstallOrRepairAsync_PassesManagerParameter()
    {
        var invoker = new PowerShellInvoker();
        var installer = new PackageManagerInstaller(invoker);

        var result = await installer.InstallOrRepairAsync("winget");

        Assert.True(result.IsSuccess);
    }
}
