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
using CarMaintainanceSystem.CyrusDBDataSetTableAdapters;

namespace CarMaintainanceSystem
{
    /// <summary>
    /// Interaction logic for WorkerForm.xaml
    /// </summary>
    
    class WorkersInfo
    {
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
    }
    public partial class WorkerForm : Window
    {
        CarMaintainanceSystemDataContext dataContext;
        SqlConnection sqlConnection;
        public WorkerForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["CarMaintainanceSystem.Properties.Settings.CyrusDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            dataContext = new CarMaintainanceSystemDataContext(connectionString);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //private void ShowAllWorker
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            ShowAllData();
        }

        private void ShowAllData()
        {
            //string query = "select WorkerId, Name from tblWorker";
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            //using (sqlDataAdapter)
            //{
            //    DataTable tblWorker = new DataTable();
            //    sqlDataAdapter.Fill(tblWorker);
            //    MainDataGrid.DisplayMemberPath = "Name";
            //    MainDataGrid.SelectedValuePath = "Id";
            //    MainDataGrid.ItemsSource = tblWorker.DefaultView;
            //}

            var getAllData = (from workerData in dataContext.tblWorkers
                              select new WorkersInfo
                              {
                                  WorkerName = workerData.Name,
                                  WorkerId = workerData.WorkerId
                              }).ToList();
            MainDataGrid.ItemsSource = getAllData;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "UPDATE tblWorkers " +
                "SET Name = @Name" +
                "WHERE WorkerId = @WorkerId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Name", MainDataGrid.DisplayMemberPath);
                sqlCommand.Parameters.AddWithValue("@WorkerId", MainDataGrid.SelectedValuePath);
                sqlCommand.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
            


            //tblWorkers.WorkerId = eachWorkerData.WorkerId;
            //tblWorkers.WorkerName = eachWorkerData.WorkerName;


            MessageBox.Show("Working in progress", "Caution!");
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            //CyrusDBDataSet.Clear();
            MessageBox.Show("Working in progress", "Caution!");
        }
    }
}
