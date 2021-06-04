using System.Windows;
using System.Windows.Controls;
using Community.VisualStudio.Toolkit;

namespace $rootnamespace$
{
    public partial class $toolWindowControl$ : UserControl
    {
        public $toolWindowControl$()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            VS.Notifications.ShowMessage("commandName", "Button clicked");
        }
    }
}