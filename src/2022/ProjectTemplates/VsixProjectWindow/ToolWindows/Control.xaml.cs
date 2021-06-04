using System.Windows;
using System.Windows.Controls;
using Community.VisualStudio.Toolkit;

namespace $safeprojectname$
{
    public partial class MyToolWindowControl : UserControl
    {
        public MyToolWindowControl(EnvDTE80.DTE2 dte)
        {
            InitializeComponent();

            lblHeadline.Content = $"Visual Studio v{dte.Version}";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            VS.Notifications.ShowMessage("$safeprojectname$", "Button clicked");
        }
    }
}