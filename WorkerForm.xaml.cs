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
        //CarMaintainanceSystemDataContext dataContext;
        SqlConnection sqlConnection;
        public WorkerForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["CarMaintainanceSystem.Properties.Settings.CyrusDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //private void ShowAllWorker
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            //CyrusDBDataSet.Clear();
            tblWorkerTableAdapter.Fill(CyrusDBDataSet);
        }

        private void ShowAllData()
        {
            string query = "select WorkerId, Name from tblWorker";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            using (sqlDataAdapter)
            {
                DataTable tblWorker = new DataTable();
                sqlDataAdapter.Fill(tblWorker);
                MainDataGrid.DisplayMemberPath = "Name";
                MainDataGrid.SelectedValuePath = "Id";
                MainDataGrid.ItemsSource = tblWorker.DefaultView;
            }
        }

        
    }
}
