using System.Windows;
using Лабораторная_1.Model;
using Лабораторная_1.ViewModel;

namespace Лабораторная_1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowNewRole.xaml
    /// </summary>
    public partial class WindowNewRole : Window
    {
        public WindowNewRole()
        {
            InitializeComponent();
        }
        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

    }
}
