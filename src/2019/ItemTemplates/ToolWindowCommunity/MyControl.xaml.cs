using System.Windows;
using System.Windows.Controls;
using Community.VisualStudio.Toolkit;

namespace $rootnamespace$
{
    public partial class $safeitemname$ : UserControl
    {
        public $safeitemname$()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            VS.Notifications.ShowMessage("Button clicked");
        }
    }
}