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
using System.Data;

namespace StudentInformationSystem
{
    /// <summary>
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : Window
    {
        DataTable dataTable;
        public Report()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var ds = new DataSet();
                ds.ReadXml("StudentDetails.xml");
                dataTable = ds.Tables[0];
                dataTable.DefaultView.Sort = "StudentName ASC";
                DataGridReport.DataContext = dataTable.DefaultView;

                MessageBox.Show("Student Report is generated.", "Report Generated", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerateByDate_Click(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    var ds = new DataSet();
                    ds.ReadXml("StudentDetails.xml");
                    dataTable = ds.Tables[0];
                    dataTable.DefaultView.Sort = "StudentRegistrationDate ASC";
                    DataGridReport.DataContext = dataTable.DefaultView;

                    MessageBox.Show("Student Report is generated.", "Report Generated", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnGenerateReport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml("StudentDetails.xml");
                DataView dv = new DataView();
                dv = ds.Tables[0].DefaultView;
                this.DataGridReport.ItemsSource = dv;

                MessageBox.Show("Student details report is generated.", "Report Generated!!!", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
