using Community.VisualStudio.Toolkit;
using System;
using System.Windows;
using System.Windows.Controls;

namespace $safeprojectname$
{
    public partial class MyToolWindowControl : UserControl
    {
        public MyToolWindowControl(Version vsVersion)
        {
            InitializeComponent();

            lblHeadline.Content = $"Visual Studio v{vsVersion}";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            VS.MessageBox.Show("$safeprojectname$", "Button clicked");
        }
    }
}