using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS
{
    class Program
    {
        static char Menu()
        {
            char op;
            Console.WriteLine("Press 1 to Add Degree");
            Console.WriteLine("Press 2 to Add Student");
            Console.WriteLine("Press 3 to Generate Merit");
            Console.WriteLine("Press 4 to see registered Students");
            Console.WriteLine("Press 5 to view Students of a specific Degree");
            Console.WriteLine("Press 6 to register subjects for a specific Student");
            Console.WriteLine("Press 7 to Calculate Fee for all registered Students");
            Console.WriteLine("Press 8 to EXIT!");
            op = char.Parse(Console.ReadLine());
            return op;
        }
        static List<Subjects> AddSubject()
        {
            int n;
            List<Subjects> offeredSubjecs = new List<Subjects>();
            char op = ' ';
            while (op != 'e' && op != 'E')
            {

                string code, type;
                int CH, fee;

                Console.Write("Enter the Code of Subject: ");
                code = Console.ReadLine();
                Console.Write("Enter the Type of Subject: ");
                type = Console.ReadLine();
                Console.Write("Enter the Credit Hours of Subject: ");
                CH = int.Parse(Console.ReadLine());
                Console.Write("Enter the Fees of Subject: ");
                fee = int.Parse(Console.ReadLine());
                Subjects s = new Subjects(code, CH, type, fee);
                if (s.TotalCH(offeredSubjecs, s) <= 20)
                {
                    offeredSubjecs.Add(s);
                }
                else
                {
                    Console.WriteLine("You cannot add more subjects!!");
                    break;

                }
            }

            return offeredSubjecs;
        }
        static DegreeProgram AddDegree()
        {
            string title, duration;
            int seats;
            Console.Write("Enter the title of degree: ");
            title = Console.ReadLine();
            Console.Write("Enter the Duration of degree: ");
            duration = Console.ReadLine();
            Console.Write("Enter the Total Seats of degree: ");
            seats = int.Parse(Console.ReadLine());

            List<Subjects> offeredSubjecs = AddSubject();

            DegreeProgram degree = new DegreeProgram(title, duration, seats, offeredSubjecs);
            return degree;
        }
        static List<DegreeProgram> AddPreferences(List<DegreeProgram> degree)
        {
            List<DegreeProgram> Preferences = new List<DegreeProgram>();
            foreach (var d in degree)
            {
                d.DisplayDegree();
            }
            int n;
            Console.Write("Enter how many Preferences you want to Apply: ");
            n = int.Parse(Console.ReadLine());
            if (degree.Count < n)
            {
                n = degree.Count;
            }
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Enter the degree name to be added in Preference number " + (j + 1) + ": ");
                string dName = Console.ReadLine();
                foreach (var d in degree)
                {
                    if (d.title == dName)
                    {
                        Preferences.Add(d);
                        break;
                    }
                }
            }
            return Preferences;
        }
        static Student AddStudent(List<DegreeProgram> degree)
        {
            string name;
            int age;
            float Fmarks, Emarks;
            Console.Write("Enter your Name: ");
            name = Console.ReadLine();
            Console.Write("Enter your Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter marks obtained in FSC: ");
            Fmarks = float.Parse(Console.ReadLine());
            Console.Write("Enter marks obtained in ECAT: ");
            Emarks = float.Parse(Console.ReadLine());
            List<DegreeProgram> Preferences = AddPreferences(degree);
            Student s = new Student(name, age, Fmarks, Emarks, Preferences);
            return s;

        }
        static int GetStudent(List<Student> s)
        {
            Console.WriteLine("Enter the name of student whose subjects you want to register: ");
            string name = Console.ReadLine();
            int idx = 0;
            for (int i = 0; i < s.Count; i++)
            {
                if (name == s[i].name)
                {
                    if (s[i].RegisteredDegree != null)
                    {
                        idx = i;
                    }
                    else
                    {
                        idx = -1;
                    }
                }
            }
            return idx;
        }
        static void RegisterSubjects(List<Student> s)
        {
            int idx = GetStudent(s);

            if (idx != -1)
            {
                foreach (var sub in s[idx].RegisteredDegree.OfferedSubjects)
                {
                    sub.Display();
                    Console.Write("Do you want to register in this subject: (Press Y to register) ");
                    char sure = char.Parse(Console.ReadLine());
                    if (sub.TotalCH(s[idx].RegisteredSubjects, sub) <= 9)
                    {
                        if (sure == 'Y' || sure == 'y')
                        {
                            s[idx].RegisteredSubjects.Add(sub);
                        }

                    }
                    else
                    {
                        Console.WriteLine("You cannot add more subjects!!");
                    }
                }
            }
            else
            {
                Console.WriteLine("This student cannot Register any subject as he didn\'t got admission in any degree Program");
            }
        }
        static void FeeDisplay(List<Student> students)
        {
            float fee;
            foreach (var s in students)
            {
                fee = s.GenerateFee();
                if (fee != -1)
                {
                    Console.WriteLine("Student name: " + s.name + " fee: " + fee);
                }
            }
        }
        static void ViewRegisteredStudent(List<Student> students)
        {
            foreach (var stu in students)
            {
                if (stu.RegisteredStudent())
                {
                    Console.WriteLine("Student name: " + stu.name + " got Admission in: " + stu.RegisteredDegree.title);
                }
            }
        }
        static void ViewRegisteredStudentOfDegree(string degreeName, List<Student> students)
        {
            foreach (var stu in students)
            {
                if (stu.RegisteredStudentOfDegree(degreeName))
                {
                    Console.WriteLine("Student name: " + stu.name);
                }
            }
        }
        static void MeritList(List<Student> students)
        {
            students.Sort((x, y) => x.merit.CompareTo(y.merit));
            students.Reverse();
            foreach (var s in students)
            {
                if (s.IsApplicable() == true)
                {
                    Console.WriteLine("Student name: " + s.name + " got Admission in: " + s.RegisteredDegree.title);
                }
                else
                {
                    Console.WriteLine("Student name: " + s.name + " did not  got Admission ");
                }
            }
        }
        static void Main(string[] args)
        {
            List<DegreeProgram> OfferedDegree = new List<DegreeProgram>();
            List<Student> students = new List<Student>();
            char op;
            while (true)
            {
                Console.Clear();
                op = Menu();
                if (op == '1')
                {
                    OfferedDegree.Add(AddDegree());
                }
                else if (op == '2')
                {
                    if (OfferedDegree.Count > 0)
                    {
                        students.Add(AddStudent(OfferedDegree));
                    }
                    else
                    {
                        Console.WriteLine("You cannot add Student as there are no degree Pregrams added plz add one first");
                    }
                }
                else if (op == '3')
                {
                    if (students.Count > 0)
                    {
                        MeritList(students);
                    }
                }
                else if (op == '4')
                {
                    if (students.Count > 0)
                    {
                        ViewRegisteredStudent(students);
                    }
                }
                else if (op == '5')
                {
                    if (students.Count > 0)
                    {
                        Console.Write("Enter the name of degree: ");
                        string name = Console.ReadLine();
                        ViewRegisteredStudentOfDegree(name, students);
                    }
                }
                else if (op == '6')
                {
                    if (students.Count > 0)
                    {
                        RegisterSubjects(students);
                    }

                }
                else if (op == '7')
                {
                    FeeDisplay(students);
                }
                else if (op == '8')
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
    }
}