using Community.VisualStudio.Toolkit;
using System;
using System.Windows;
using System.Windows.Controls;

namespace $rootnamespace$
{
    public partial class $safeitemname$ : UserControl
    {
        public $safeitemname$(Version vsVersion)
        {
            InitializeComponent();

            lblHeadline.Content = $"Visual Studio v{vsVersion}";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            VS.MessageBox.Show("$safeitemname$", "Button clicked");
        }
    }
}
