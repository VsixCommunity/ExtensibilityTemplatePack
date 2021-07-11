using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Imaging;
using Microsoft.VisualStudio.Shell;

namespace $rootnamespace$
{
    public class $safeitemname$ : BaseToolWindow<$safeitemname$>
    {
        public override string GetTitle(int toolWindowId) => "$safeitemname$";

        public override Type PaneType => typeof(Pane);

        public override async Task<FrameworkElement> CreateAsync(int toolWindowId, CancellationToken cancellationToken)
        {
            Version vsVersion = await VS.Shell.GetVsVersionAsync();
            return new $safeitemname$Control(vsVersion);
        }

        [Guid("$guid1$")]
        internal class Pane : ToolWindowPane
        {
            public Pane()
            {
                BitmapImageMoniker = KnownMonikers.ToolWindow;
            }
        }
    }
}
