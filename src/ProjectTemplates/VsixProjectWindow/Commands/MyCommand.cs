using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace $safeprojectname$
{
    internal sealed class MyToolWindowCommand : BaseCommand<MyToolWindowCommand>
{
        public MyToolWindowCommand()
            : base(PackageGuids.CommandSet, PackageIds.MyCommand) { }

        protected override Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            return MyToolWindow.ShowAsync();
        }
    }
}
