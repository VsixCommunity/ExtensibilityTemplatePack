using System;
using Microsoft.VisualStudio.Shell;
using Community.VisualStudio.Toolkit;
using Task = System.Threading.Tasks.Task;

namespace $safeprojectname$
{
    internal sealed class MyCommand : BaseCommand<MyCommand>
{
        public MyCommand() : base(new Guid("$guid4$"), 0x0100)
        { }

        protected override Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            VS.Notifications.ShowMessage("MyCommand", "Button clicked");

            return Task.CompletedTask;
        }
    }
}
