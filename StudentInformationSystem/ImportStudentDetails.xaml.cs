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
using System.IO;
using Microsoft.Win32;
using System.Xml.Serialization;

namespace StudentInformationSystem
{
    /// <summary>
    /// Interaction logic for ImportStudentDetails.xaml
    /// </summary>
    public partial class ImportStudentDetails : Window
    {
        public ImportStudentDetails()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "CSV|*csv", ValidateNames = true };

                if (openFileDialog.ShowDialog() == true)
                {
                    var streamReader = new StreamReader(new FileStream(openFileDialog.FileName, FileMode.Open));
                    String line;

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        String[] data = line.Split(',');

                        Data details = new Data();
                        details.StudentRegistrationID = data[0];
                        details.StudentRegistrationDate = data[1];
                        details.StudentID = data[2];
                        details.StudentName = data[3];
                        details.StudentAddress = data[4];
                        details.StudentContact = data[5];
                        details.StudentCourse = data[6];

                        XMLData.RecordData(details, "StudentDetails.xml");
                    }

                    streamReader.Close();
                }
               
                MessageBox.Show("Student is successfully enrolled.", "Enroll Sucessful!!!", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }


        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
