using System;

using System.Linq;

using System.Windows;
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

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //private void ShowAllWorker
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            ShowAllData();
        }

        private void ShowAllData()
        {
            string query = "select WorkerId, Name from tblWorker";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            using (sqlDataAdapter)
            {
                DataTable tblWorker = new DataTable();
                sqlDataAdapter.Fill(tblWorker);
                //MainDataGrid.DisplayMemberPath = "Name";
                //MainDataGrid.SelectedValuePath = "Id";
                MainDataGrid.ItemsSource = tblWorker.DefaultView;
            }
            

        }

        //saves a new file
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            /*
             Main data grid will show all data then when selected a new for will 
            pop up and allow users to enter their individual records
            Then the user can click update to update old records
            New goal create using this information...
             */
            
            try
            {
                tblWorkerTableAdapter tableAdapter = new tblWorkerTableAdapter();
                tableAdapter.Fill((CyrusDBDataSet.tblWorkerDataTable)MainDataGrid.ItemsSource);

                //string query = "UPDATE tblWorkers " +
                //"SET Name = @Name" +
                //" WHERE WorkerId = @WorkerId";
                //SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //sqlConnection.Open();
                //sqlCommand.Parameters.AddWithValue("@Name", MainDataGrid.SelectedCells.ToString());
                //sqlCommand.Parameters.AddWithValue("@WorkerId", Convert.ToInt32(MainDataGrid.SelectedCells));
                //sqlCommand.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                ShowAllData();
                //sqlConnection.Close();
            }
            


            //tblWorkers.WorkerId = eachWorkerData.WorkerId;
            //tblWorkers.WorkerName = eachWorkerData.WorkerName;


            //MessageBox.Show("Working in progress", "Caution!");
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            //CyrusDBDataSet.Clear();
            MessageBox.Show("Working in progress", "Caution!");
        }

        private void MainDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string query = "select WorkerId, Name from tblWorker " +
                "Where WorkerId = @WorkerId";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            using (sqlDataAdapter)
            {
                DataTable tblWorkerDataTable = new DataTable();
                
                sqlCommand.Parameters.AddWithValue("@WorkerId", MainDataGrid.SelectedCells);
                sqlCommand.Parameters.AddWithValue("@Name", MainDataGrid.SelectedCells);
                //MainDataGrid.DisplayMemberPath = "Name";
                //MainDataGrid.SelectedValuePath = "Id";
                sqlDataAdapter.Fill(tblWorkerDataTable);
                var id = tblWorkerDataTable.Rows[0]["Name"];
                myTextBox.Text = id.ToString();
                //myTextBox.Text = tblWorkerDataTable.Rows[id]["NAME"].ToString();
            }
            
        }
    }
}
