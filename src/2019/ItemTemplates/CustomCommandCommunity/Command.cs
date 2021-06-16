using System;
using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace $rootnamespace$
{
    [Command("<insert guid from .vsct file>", 0x0100)]
    internal sealed class $safeitemname$ : BaseCommand<$safeitemname$>
    {        
        protected override Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            VS.Notifications.ShowMessage("$safeitemname$", "Button clicked");

            return Task.CompletedTask;
        }
    }
}
