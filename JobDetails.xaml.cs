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
using System.Configuration;
using System.Data.SqlClient;

namespace CarMaintainanceSystem
{
    /// <summary>
    /// Interaction logic for JobDetails.xaml
    /// </summary>
    public partial class JobDetails : Window
    {
        SqlConnection sqlConnection;
        public JobDetails()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["CarMaintainanceSystem.Properties.Settings.CyrusDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }



        private void editCarNO_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (editCarNO.Text == "")
            {
                MessageBox.Show("Please specify the value for the car number", "Error in input");
                editCarNO.Focus();
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            ErrorChecker();

            // Saving new data
            try
            {
                //SQL query
                string query = "insert into tblJobDetails(CarNo, JobDate, WorkerId" +
                ", KMs, Tuning, Alignment, Balancing, Tires, Weights, OilChanged" +
                ", OilQty, OilFilter, GearOil,GearOilQty, Point, Condenser, Plug, PlugQty" +
                ", FuelFilter, AirFilter, Remarks)" +
                "Values(@CarNo, @JobDate, @WorkerId" +
                ", @KMs, @Tuning, @Alignment, @Balancing, @Tires, @Weights, @OilChanged" +
                ", @OilQty, @OilFilter, @GearOil, @GearOilQty, @Point, @Condenser, @Plug, @PlugQty" +
                ", @FuelFilter, @AirFilter, @Remarks)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@CarNO", editCarNO.Text);
                sqlCommand.Parameters.AddWithValue("@JobDate", dateTimePicker1.SelectedDate);
                sqlCommand.Parameters.AddWithValue("@WorkerId", Convert.ToInt32(editName.Text));
                sqlCommand.Parameters.AddWithValue("@KMs", Convert.ToInt32(editKMs.Text));
                sqlCommand.Parameters.AddWithValue("@Tuning", Convert.ToInt32(editTuning.Text));
                sqlCommand.Parameters.AddWithValue("@Alignment", Convert.ToInt32(editAlignment.Text));
                sqlCommand.Parameters.AddWithValue("@Balancing", Convert.ToInt32(editBalancing.Text));
                sqlCommand.Parameters.AddWithValue("@Tires", Convert.ToInt32(editTires.Text));
                sqlCommand.Parameters.AddWithValue("@Weights", Convert.ToInt32(editWeights.Text));
                sqlCommand.Parameters.AddWithValue("@OilChanged", Convert.ToInt32(editOilChanged.Text));
                sqlCommand.Parameters.AddWithValue("@OilQty", Convert.ToInt32(editOilQty.Text));
                sqlCommand.Parameters.AddWithValue("@OilFilter", Convert.ToInt32(editOilFilter.Text));
                sqlCommand.Parameters.AddWithValue("@GearOil", Convert.ToInt32(editGearOil.Text));
                sqlCommand.Parameters.AddWithValue("@GearOilQty", Convert.ToInt32(editGearOilQty.Text));
                sqlCommand.Parameters.AddWithValue("@Point", Convert.ToInt32(editPoint.Text));
                sqlCommand.Parameters.AddWithValue("@Condenser", Convert.ToInt32(editCondenser.Text));
                sqlCommand.Parameters.AddWithValue("@Plug", Convert.ToInt32(editPlug.Text));
                sqlCommand.Parameters.AddWithValue("@PlugQty", Convert.ToInt32(editPlugQty.Text));
                sqlCommand.Parameters.AddWithValue("@FuelFilter", Convert.ToInt32(editFuelFilter.Text));
                sqlCommand.Parameters.AddWithValue("@AirFilter", Convert.ToInt32(editAirFilter.Text));
                sqlCommand.Parameters.AddWithValue("@Remarks", editRemarks.Text);
                sqlCommand.ExecuteScalar();
                MessageBox.Show("Data added Successfully", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Could not add to database");
            }
            finally
            {
                sqlConnection.Close();
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

        private void ErrorChecker()
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
                if (dateTimePicker1.SelectedDate > DateTime.Today)
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

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            ErrorChecker();

            try
            {
                //SQL query
                string query = "update tblJobDetails " +
                    "set (CarNo = @CarNo, JobDate = @JobDate, WorkerId = @WorkerId" +
                ", KMs = @KMs, Tuning = @Tuning, Alignment = @Alignment, Balancing = @Balancing, " +
                "Tires = @Tires, Weights = @Weights, OilChanged = @OilChanged, OilQty = @OilQty, " +
                "OilFilter = @OilFilter, GearOil = @GearOil, GearOilQty = @GearOilQty, " +
                "Point = @Point, Condenser = @Condenser, Plug = @Plug, PlugQty = @PlugQty" +
                ", FuelFilter = @FuelFilter, AirFilter = @AirFilter, Remarks = @Remarks)" +""
                ;
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@CarNO", editCarNO.Text);
                sqlCommand.Parameters.AddWithValue("@JobDate", dateTimePicker1.SelectedDate);
                sqlCommand.Parameters.AddWithValue("@WorkerId", Convert.ToInt32(editName.Text));
                sqlCommand.Parameters.AddWithValue("@KMs", Convert.ToInt32(editKMs.Text));
                sqlCommand.Parameters.AddWithValue("@Tuning", Convert.ToInt32(editTuning.Text));
                sqlCommand.Parameters.AddWithValue("@Alignment", Convert.ToInt32(editAlignment.Text));
                sqlCommand.Parameters.AddWithValue("@Balancing", Convert.ToInt32(editBalancing.Text));
                sqlCommand.Parameters.AddWithValue("@Tires", Convert.ToInt32(editTires.Text));
                sqlCommand.Parameters.AddWithValue("@Weights", Convert.ToInt32(editWeights.Text));
                sqlCommand.Parameters.AddWithValue("@OilChanged", Convert.ToInt32(editOilChanged.Text));
                sqlCommand.Parameters.AddWithValue("@OilQty", Convert.ToInt32(editOilQty.Text));
                sqlCommand.Parameters.AddWithValue("@OilFilter", Convert.ToInt32(editOilFilter.Text));
                sqlCommand.Parameters.AddWithValue("@GearOil", Convert.ToInt32(editGearOil.Text));
                sqlCommand.Parameters.AddWithValue("@GearOilQty", Convert.ToInt32(editGearOilQty.Text));
                sqlCommand.Parameters.AddWithValue("@Point", Convert.ToInt32(editPoint.Text));
                sqlCommand.Parameters.AddWithValue("@Condenser", Convert.ToInt32(editCondenser.Text));
                sqlCommand.Parameters.AddWithValue("@Plug", Convert.ToInt32(editPlug.Text));
                sqlCommand.Parameters.AddWithValue("@PlugQty", Convert.ToInt32(editPlugQty.Text));
                sqlCommand.Parameters.AddWithValue("@FuelFilter", Convert.ToInt32(editFuelFilter.Text));
                sqlCommand.Parameters.AddWithValue("@AirFilter", Convert.ToInt32(editAirFilter.Text));
                sqlCommand.Parameters.AddWithValue("@Remarks", editRemarks.Text);
                sqlCommand.ExecuteScalar();
                MessageBox.Show("Update Successfull", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Could not add to database");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
