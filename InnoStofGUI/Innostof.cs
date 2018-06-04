using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;


namespace InnoStofGUI {
    public partial class Innostof : Form {
        private Arduinocommands arduinocommands = new Arduinocommands();

        TimeSpan elapsedTime;
        DateTime activatedTime;
        bool isActive = false;

        public Innostof() {
            InitializeComponent();
            recordtimeLabel.Text = LoadRecord().ToTimeSpan().ToString();
            timeLabel.Text = "00:00:00";
        }

        private void powerbutton_Click(object sender, EventArgs e) {
            if (powerbutton.Text == "A A N")
            {
                arduinocommands.sendCommand("on");
                powerbutton.Text = "U I T";
                isActive = true;
                activatedTime = DateTime.Now;
            } else if (powerbutton.Text == "U I T")
            {
                arduinocommands.sendCommand("off");
                powerbutton.Text = "A A N";
                isActive = false;
                timeLabel.Text = "00:00:00";
                SaveScore(elapsedTime);
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if(isActive)
            {
                elapsedTime = DateTime.Now - activatedTime;
                timeLabel.Text = string.Format("{0:hh\\:mm\\:ss}", elapsedTime);
            }
        }

        private void Innostof_Load(object sender, EventArgs e){
            
        }

        private void SaveScore(TimeSpan record)
        {
            Record time = new Record(record.Hours, record.Minutes, record.Seconds);
            time.Print();
            if (!File.Exists("record.dat"))
            {
                File.WriteAllText("record.dat", new JavaScriptSerializer().Serialize(time));
            }
            else
            {
                Record currentRecord = LoadRecord();
                currentRecord.Print();
                if (time.hours >= currentRecord.hours && time.minutes >= currentRecord.minutes && time.seconds > currentRecord.seconds)
                {
                    Debug.Print("Greater than");
                    File.WriteAllText("record.dat", new JavaScriptSerializer().Serialize(time));
                    recordtimeLabel.Text = time.ToTimeSpan().ToString();
                }
            }
            
        }

        private Record LoadRecord()
        {
            if (File.Exists("record.dat"))
            {
                Debug.Print("Exists");
                Record record = new JavaScriptSerializer().Deserialize<Record>(File.ReadAllText("record.dat"));
                return record;
            }
            else
            {
                Debug.Print("Doesn't exist");
                return new Record();
            } 
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
