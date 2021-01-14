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
using System.Windows.Shapes;

namespace CarMaintainanceSystem
{
    /// <summary>
    /// Interaction logic for CustomerForm.xaml
    /// </summary>
    public partial class CustomerForm : Window
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (editName.Text == "")
            {
                MessageBox.Show("Please specify Your name", "Error in input");
                editName.Focus();
                return;
            }
            if (editMake.Text == "")
            {
                MessageBox.Show("Please specify the valid text", "Error in input");
                editMake.Focus();
                return;
            }
            if (editCarNo.Text == "")
            {
                MessageBox.Show("Please specify a valid car number", "Error in input");
                editCarNo.Focus();
                return;
            }
            if (editCarNo.Text.Length < 6)
            {
                MessageBox.Show("Incomplete car number", "Error in input");
                editCarNo.Focus();
                return;
            }
            if (editAddress.Text == "")
            {
                MessageBox.Show("Please specify a valid car number", "Error in input");
                editAddress.Focus();
                return;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
