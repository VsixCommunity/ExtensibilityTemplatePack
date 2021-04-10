using Community.VisualStudio.Toolkit;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace $rootnamespace$
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    // %if% defined $packageAttribute1$
    [$packageAttribute1$]
    // %endif%
    // %if% defined $packageAttribute2$
    [$packageAttribute2$]
    // %endif%
    [Guid("$packageGuid$")]
    public sealed class $packageName$ : ToolkitPackage
    {
        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
            // %if% defined $packageInitStatement$
            $packageInitStatement$
            // %endif%
        }
    }
}
