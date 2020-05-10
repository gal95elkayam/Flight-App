using FlightSimulatorApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorApp.ViewModel
{
    class MyJoystickViewModel : BaseNotify
    {
        public new event PropertyChangedEventHandler PropertyChanged;
        public MySimModel model;
        public MyJoystickViewModel(MySimModel model)
        {
            this.model = model;
            model.PropertyChanged += delegate (Object sender, PropertyChangedEventArgs e)
              {
                  NotifyPropertyChanged("VM_" + e.PropertyName);

              };

        }
        public new void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {


                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        // 4 properties that set to the simulator
        public double VM_Rudder
        {
            get
            {




                return this.model.Rudder;
            }
            set
            {
                this.model.Rudder = value;
            }
        }
        public double VM_Elevator
        {
            get
            {
                return this.model.Elevator;
            }
            set
            {
                this.model.Elevator = value;
            }
        }
        public double VM_Aileron
        {
            get
            {
                return this.model.Aileron;
            }
            set
            {
                this.model.Aileron = value;
            }
        }
        public double VM_Throttle
        {
            get
            {
                return this.model.Throttle;
            }
            set
            {
                this.model.Throttle = value;
            }
        }

    }
}
