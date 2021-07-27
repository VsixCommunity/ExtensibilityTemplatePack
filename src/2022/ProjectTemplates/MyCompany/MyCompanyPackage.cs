global using System;
global using Microsoft.VisualStudio.Shell;
global using Task = System.Threading.Tasks.Task;
using System.Runtime.InteropServices;
using System.Threading;

namespace $safeprojectname$
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [Guid(PackageGuids.$safeprojectname$String)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [ProvideBindingPath]
    public sealed class MyCompanyPackage : AsyncPackage
    {
        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);

            UrlCommandFactory factory = await UrlCommandFactory.CreateAsync(this);

            factory.Register(PackageIds.Wiki, "https://example.com?page=wiki");
            factory.Register(PackageIds.BuildServer, "https://example.com?page=buildserver");
            factory.Register(PackageIds.HrPortal, "https://example.com?page=hrportal");
        }
    }
}
