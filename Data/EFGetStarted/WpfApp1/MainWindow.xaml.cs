using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EFGetStarted;
using EFGetStartedBusiness;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CRUDManager _crudManager = new CRUDManager();
    
        public MainWindow()
        {
            InitializeComponent();
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            ListBoxUser.ItemsSource = _crudManager.RetrieveAll();
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            _crudManager.UpdateUserDetails(TextId.Text, TextName.Text, TextUsername.Text);
            ListBoxUser.ItemsSource = null;
            
            PopulateListBox();
            ListBoxUser.SelectedItem = _crudManager.SelectedUser;
            PopulateUserFields();
        }
    }
}
