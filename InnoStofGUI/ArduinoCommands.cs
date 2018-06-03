using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoStofGUI {
    class Arduinocommands {
        private string[] ports;
        private SerialPort arduino;
        private bool isConnected = false;

        public Arduinocommands() {
            connectToArduino();
        }

        public void sendCommand(string s) {
            arduino.Open();
            arduino.Write(s);
            arduino.Close();
        }

        private void connectToArduino() {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports) {
                arduino = new SerialPort(port, 9600);
            }
        }
    }
}
