using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.BL;

namespace Ocean_Navigation
{
    public class Program
    {
        static void Header()
        {
            Console.Clear();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("**                                                                                 **");
            Console.WriteLine("**                             OCEAN NAVIGATION SYSTEM                             **");
            Console.WriteLine("**                                                                                 **");
            Console.WriteLine("*************************************************************************************\n\n");
        }
        static void Main(string[] args)
        {
            List<Ship> ships = new List<Ship>();
            while (true)
            {
                char op = Menu();
                Header();
                if (op == '1')
                {
                    ships.Add(AddShip());
                }
                else if (op == '2')
                {
                    Console.Write("Enter the ship\'s Serial Number whose position you want to View: ");
                    string serial = Console.ReadLine();
                    DisplayPosition(serial, ships);
                }
                else if (op == '3')
                {
                    DisplaySerial(ships);
                }
                else if (op == '4')
                {
                    Console.Write("Enter the ship\'s Serial Number whose position you want to change: ");
                    string serial = Console.ReadLine();
                    ChangeAngle(serial, ships);
                }
                else if (op == '5')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!!");
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }

        static char Menu()
        {
            Header();
            char op;
            Console.WriteLine("Press 1 to Add Ship");
            Console.WriteLine("Press 2 to View Ship\'s Position");
            Console.WriteLine("Press 3 to View Ship\'s Serial Number");
            Console.WriteLine("Press 4 to Change Ship\'s Position");
            Console.WriteLine("Press 5 to EXIT");
            Console.Write("\n>> ");
            op = char.Parse(Console.ReadLine());
            return op;
        }
        static Angle AddPosition(int degreeRange, char D1, char D2)
        {
            int degree;
            float minutes;
            char direction;
            Console.Write("Enter the Direction in Degrees: ");
            degree = int.Parse(Console.ReadLine());
            while (degree > degreeRange)
            {
                Console.WriteLine("You Entered Wrong Degrees (It must be between 0 and {0})", degreeRange);
                Console.Write("Enter the Direction in Degrees: ");
                degree = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter minutes: ");
            minutes = float.Parse(Console.ReadLine());
            while (minutes > 60)
            {
                Console.WriteLine("You Entered Wrong Minutes (It must be between 0 and 60)");
                Console.Write("Enter minutes: ");
                minutes = float.Parse(Console.ReadLine());
            }
            Console.Write("Enter the Direction: ");
            direction = char.Parse(Console.ReadLine());
            while (direction != D1 && direction != D2)
            {
                Console.WriteLine("Incorrect Direction");
                Console.Write("Enter the Direction: ");
                direction = char.Parse(Console.ReadLine());
            }
            Angle position = new Angle(degree, minutes, direction);
            return position;
        }
        static Ship AddShip()
        {
            string number;
            Console.Write("Enter the serial number of Ship: ");
            number = Console.ReadLine();
            Console.WriteLine("Enter Ship Latitude: ");
            Angle latitude = AddPosition(90, 'N', 'S');
            Console.WriteLine("Enter Ship Longitude: ");
            Angle longitude = AddPosition(180, 'E', 'W');
            Ship s = new Ship(number, latitude, longitude);
            return s;
        }

        static void DisplaySerial(List<Ship> ships)
        {
            Angle p1, p2;
            Console.WriteLine("Enter the latitude: ");
            p1 = AddPosition(90, 'N', 'S');
            Console.WriteLine("Enter the longitude: ");
            p2 = AddPosition(180, 'E', 'W');
            bool found = false;
            foreach (var s in ships)
            {
                if (s.longitude.Position() == p2.Position() && s.latitude.Position() == p1.Position())
                {
                    s.DisplaySerial();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No Ship is at that position");
            }
        }
        static int FindShip(string serial, List<Ship> s)
        {
            for (int i = 0; i < s.Count; i++)
            {
                if (serial == s[i].number)
                {
                    return i;
                }
            }
            return -1;
        }
        static void DisplayPosition(string serial, List<Ship> ships)
        {
            int idx = FindShip(serial, ships);
            if (idx != -1)
            {
                ships[idx].DisplayPosition();
            }
        }
        static void Angle(Angle position, int degreeRange, char D1, char D2)
        {
            int degree;
            float minutes;
            char direction;
            Console.Write("Enter the Direction in Degrees: ");
            degree = int.Parse(Console.ReadLine());
            while (degree > degreeRange)
            {
                Console.WriteLine("You Entered Wrong Degrees (It must be between 0 and {0})", degreeRange);
                Console.Write("Enter the Direction in Degrees: ");
                degree = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter minutes: ");
            minutes = float.Parse(Console.ReadLine());
            while (minutes > 60)
            {
                Console.WriteLine("You Entered Wrong Minutes (It must be between 0 and 60)");
                Console.Write("Enter minutes: ");
                minutes = float.Parse(Console.ReadLine());
            }
            Console.Write("Enter the Direction: ");
            direction = char.Parse(Console.ReadLine());
            while (direction != D1 && direction != D2)
            {
                Console.WriteLine("Incorrect Direction");
                Console.Write("Enter the Direction: ");
                direction = char.Parse(Console.ReadLine());
            }
            position.ChangeAngle(degree, minutes, direction);
        }
        static void ChangeAngle(string serial, List<Ship> ships)
        {
            int idx = FindShip(serial, ships);
            if (idx != -1)
            {
                Console.WriteLine("Enter Ship Latitude: ");
                Angle(ships[idx].latitude, 90, 'N', 'S');
                Console.WriteLine("Enter Ship Longitude: ");
                Angle(ships[idx].longitude, 180, 'W', 'E');
            }

        }
    }
}