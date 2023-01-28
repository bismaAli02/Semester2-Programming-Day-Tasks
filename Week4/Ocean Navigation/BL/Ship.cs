using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation;
namespace Ocean_Navigation.BL
{
    class Ship
    {
        public Ship(string number, Angle latitude, Angle longitude)
        {
            this.number = number;
            this.latitude = latitude;
            this.longitude = longitude;
        }
        public string number;
        public Angle latitude;
        public Angle longitude;
        public void DisplaySerial()
        {
            Console.WriteLine("Ship\'s Serial number is: " + number);
        }
        public void DisplayPosition()
        {
            Console.WriteLine("The Ship is at: " + latitude.Position() + " and " + longitude.Position());
        }
    }
}