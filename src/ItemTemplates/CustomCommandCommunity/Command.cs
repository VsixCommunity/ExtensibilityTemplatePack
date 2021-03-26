using System;
using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace $rootnamespace$
{
    internal sealed class $commandName$ : BaseCommand<$commandName$>
    {
        public $commandName$() : base(new Guid("$cmdSetGuid$"), $commandIdValue$)
        { }
        
        protected override Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            VS.Notifications.ShowMessage("commandName", "Button clicked");

            return Task.CompletedTask;
        }
    }
}
