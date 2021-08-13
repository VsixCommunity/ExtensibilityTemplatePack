using System.Windows;
using System.Windows.Controls;

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
            VS.MessageBox.Show("$safeitemname$", "Button clicked");
        }
    }
}
