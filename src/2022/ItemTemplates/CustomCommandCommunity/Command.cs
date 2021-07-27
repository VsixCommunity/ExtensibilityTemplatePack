using System;
using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace $rootnamespace$
{
    [Command("<insert guid from .vsct file>", 0x0100)]
    internal sealed class $safeitemname$ : BaseCommand<$safeitemname$>
    {        
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            await VS.MessageBox.ShowWarningAsync("$safeitemname$", "Button clicked");
        }
    }
}
