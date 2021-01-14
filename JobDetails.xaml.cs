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
    /// Interaction logic for JobDetails.xaml
    /// </summary>
    public partial class JobDetails : Window
    {
        public JobDetails()
        {
            InitializeComponent();
        }

        private void editCarNO_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (editCarNO.Text == "")
            {
                MessageBox.Show("Please specify the value for the car number", "Error in input");
                editCarNO.Focus();
            }

        }

        private void editName_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (editName.Text == "")
            {
                MessageBox.Show("Can't leave field empty", "Null value");
                editName.Focus();
            }
        }

        private void editKMs_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (editKMs.Text == "")
            {
                MessageBox.Show("Can't leave field empty", "Null value");
                editKMs.Focus();
            }
            int editKMsInt;
            bool editKMsFlag = int.TryParse(editKMs.Text, out editKMsInt);
            if (editKMsFlag == false)
            {
                MessageBox.Show("Please specify the value for the KMs", "Error in input");
                editKMs.Focus();
            }

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (editCarNO.Text.Length < 6)
            {
                MessageBox.Show("Please specify a valid car number", "Incomplete car number");
                editCarNO.Focus();
                return;
            }
            try
            {
                if (Convert.ToInt32(editName.Text) < 1)
                {
                    MessageBox.Show("Please specify a valid worker ID");
                    editName.Focus();
                    return;
                }
                if (Convert.ToDateTime(dateTimePicker1) > DateTime.Today)
                {
                    MessageBox.Show("Please specify a valid date");
                    dateTimePicker1.Focus();
                    return;
                }
            }
            catch (Exception execption)
            {
                MessageBox.Show(execption.Message);
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
