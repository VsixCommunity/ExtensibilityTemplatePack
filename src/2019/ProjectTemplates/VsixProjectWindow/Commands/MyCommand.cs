using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace $safeprojectname$
{
    [Command(PackageIds.MyCommand)]
    internal sealed class MyToolWindowCommand : BaseCommand<MyToolWindowCommand>
    {
        protected override Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            return MyToolWindow.ShowAsync();
        }
    }
}
