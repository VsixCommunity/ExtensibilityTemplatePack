using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;
using System.Windows;
using Community.VisualStudio.Toolkit;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Imaging;
using Task = System.Threading.Tasks.Task;

namespace $rootnamespace$
{
    public class $safeitemname$ : BaseToolWindow<$safeitemname$>
    {
        public override string GetTitle(int toolWindowId) => "$safeitemname$";

        public override Type PaneType => typeof(Pane);

        public override Task<FrameworkElement> CreateAsync(int toolWindowId, CancellationToken cancellationToken)
        {
            return Task.FromResult<FrameworkElement>(new $safeitemname$Control());
        }

        [Guid("$guid1$")]
        public class Pane : ToolWindowPane
        {
            public Pane()
            {
                BitmapImageMoniker = KnownMonikers.StatusInformation;
            }
        }
    }
}
