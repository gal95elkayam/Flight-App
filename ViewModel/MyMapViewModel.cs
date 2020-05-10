using FlightSimulatorApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maps.MapControl.WPF;

namespace FlightSimulatorApp.ViewModel
{
    class MyMapViewModel : BaseNotify
    {
       // public event PropertyChangedEventHandler PropertyChanged;
        public MySimModel model;
        public MyMapViewModel(MySimModel model)
        {
            this.model = model;
            model.PropertyChanged += delegate (Object sender, PropertyChangedEventArgs e)
            {
                NotifyPropertyChanged("VM_" + e.PropertyName);

            };

        }


        // the location of the plane on the map
        public Location VM_Location
        {
            get
            {
                return model.Location;
            }
        }
        public double VM_LongitudeT
        {
            get { return model.Longitude; }
        }
        public double VM_LatitudeT
        {
            get { return model.Latitude; }
        }

    }
}
