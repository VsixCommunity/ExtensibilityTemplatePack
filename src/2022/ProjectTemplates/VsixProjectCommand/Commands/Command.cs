using Microsoft.VisualStudio.Shell;
using Community.VisualStudio.Toolkit;
using Task = System.Threading.Tasks.Task;

namespace $safeprojectname$
{
    [Command(PackageIds.MyCommand)]
    internal sealed class MyCommand : BaseCommand<MyCommand>
    {
        protected override Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            VS.Notifications.ShowMessage("MyCommand", "Button clicked");

            return Task.CompletedTask;
        }
    }
}
