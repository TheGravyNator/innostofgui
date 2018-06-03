using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoStofGUI
{
    [Serializable]
    public class Record
    {
        public int hours;
        public int minutes;
        public int seconds;

        public Record() { }

        public Record(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public void Print()
        {
            Debug.Print("Hours: " + this.hours + " Minutes: " + this.minutes + " Seconds: " + this.seconds);
        }

        public TimeSpan ToTimeSpan()
        {
            return new TimeSpan(this.hours, this.minutes, this.seconds);
        }
    }
}
