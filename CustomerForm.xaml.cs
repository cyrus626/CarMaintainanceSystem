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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CarMaintainanceSystem
{
    /// <summary>
    /// Interaction logic for CustomerForm.xaml
    /// </summary>
    public partial class CustomerForm : Window
    {
        SqlConnection sqlConnection;
        public CustomerForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["CarMaintainanceSystem.Properties.Settings.CyrusDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }

        private void ErrorrChecker()
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
            
        
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            ErrorrChecker();
            // saving all data
            try
            {
                string query = "insert into tblCustomer (CarNo, Name, Address, Make)" +
                " Values(@CarNo, @Name, @address, @Make)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@CarNo", editCarNo.Text);
                sqlCommand.Parameters.AddWithValue("@Name", editName.Text);
                sqlCommand.Parameters.AddWithValue("@Address", editAddress.Text);
                sqlCommand.Parameters.AddWithValue("@Make", editMake.Text);
                sqlCommand.ExecuteScalar();
                MessageBox.Show("values added to datbase");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            ErrorrChecker();
            try
            {
                string query = "Update tblCustomer " +
                    "set Name = @Name, Address = @Address, Make = @Make " +
                    "Where CarNO = @CarNo";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Name", editName.Text);
                sqlCommand.Parameters.AddWithValue("@Address", editAddress.Text);
                sqlCommand.Parameters.AddWithValue("@Make", editMake.Text);
                sqlCommand.Parameters.AddWithValue("@CarNo", editCarNo.Text);
                sqlCommand.ExecuteScalar();
                MessageBox.Show("Update Successful", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
            
        }

        //private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        //{
        //    btnPrevious.BindingContext[CyrusDBDataSet, "tblCustomer"].Postion -= 1; //CyrusDBDataSet.
        //}
    }
}
