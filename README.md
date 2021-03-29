# FlightSimulatorWPF
## About Our Application:
The Application provides a simple and clean GUI for fly an airplane (with a flight simulator).

The app follows the MVVM design for WPF applications and is written mainly in C# and the Observer design pattern is used widely and in many ways along the code.

The **ViewModels** and the **Model** are initialized at the startup of the program at App.xaml and are independent.

**The Model**: The model is responsible to make a connection with the simulator server and get information about the Dashboard. There is only one model.

**The Views**: Each View is an Observer, and gets their information from 3 independent view models. Each View is also a Subject and sends updates to the relevant view Model.

**The View Models**: There are 3 view models, each one is responsible to different matter. DashBoardViewModel- is responsible for the Dashboard component. MyJoystickViewModel - is responsible for the Joystick component. MyMapViewModel - is responsible for the Map component.
