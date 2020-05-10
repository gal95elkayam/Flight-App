using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

namespace FlightSimulatorApp.Views
{
    /// <summary>
    /// Interaction logic for MyConnect.xaml
    /// </summary>
    public partial class MyConnect : Window
    {
        MySimModel model;

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propName)
        {


            if (this.PropertyChanged != null)
            {

                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }

        }

        public MyConnect(MySimModel model)
        {

            InitializeComponent();

            this.model = model;


        }
        public string Err { get; set; }


        private void b2_Click(object sender, RoutedEventArgs e)
        {


            model.UpdateTelnet(ipVal.Text, portVal.Text);
            if (model.validateIp && model.validateIp)
            {
                model.Connect();
            }
            else
            {


            }

            this.Close();
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            string defaultPort = ConfigurationManager.AppSettings["port"].ToString();
            string defaultIP = ConfigurationManager.AppSettings["ip"].ToString();
            model.UpdateTelnet(defaultIP, defaultPort);
            model.Connect();
            this.Close();

        }
    }




}
