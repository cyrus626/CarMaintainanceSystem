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
using System.Configuration;
namespace CarMaintainanceSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //CarMaintainanceSystemDataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();
            //string connectionString = ConfigurationManager.ConnectionStrings["CarMaintainanceSystem.Properties.Settings.CyrusDBConnectionString"].ConnectionString;
            //dataContext = new CarMaintainanceSystemDataContext(connectionString);
        }
        
        //Opens workerForm
        private void workerForm_Click(object sender, RoutedEventArgs e)
        {
            WorkerForm workerForm = new WorkerForm();
            workerForm.ShowDialog();
        }

        //Exit the app
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Opens Report window
        private void reportForm_Click(object sender, RoutedEventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        //Opens jobDetail window
        private void jobTitleForm_Click(object sender, RoutedEventArgs e)
        {
            JobDetails jobDetails = new JobDetails();
            jobDetails.ShowDialog();
        }

        //Opens customerForm window
        private void customerForm_Click(object sender, RoutedEventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }
    }
}
