using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uams.BL;
namespace uams
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            List<Degree> degree = new List<Degree>();
            int i;
            do
            {
                i = menu();
                if (i >= 1 && i <= 7)
                {
                    Console.Clear();
                    if (i == 1)
                    {
                        Student s = addstudent(students);
                        s.addstudent(students, s);
                    }
                    else if (i == 2)
                    {
                        adddegree(degree);
                    }
                    else if (i == 3)
                    {
                        genratemerit(students);
                    }
                    else if (i == 4)
                    {
                        ViewRegisteredStudents(students);
                    }
                    else if (i == 5)
                    {
                        ViewSpecificProgram(degree,students);
                    }
                    else if (i == 6)
                    {
                        register(students);
                    }
                    else if (i == 7)
                    {
                        calculatefee(students);
                    }
                    Console.WriteLine("press any key to continue......");

                }
                else
                {
                    Console.WriteLine("invalid input");
                }

                Console.ReadKey();
            } while (i != 7);
        }
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1.add student");
            Console.WriteLine("2. Add degree");
            Console.WriteLine("3.calculate merit");
            Console.WriteLine("4. Veiw registerd students");
            Console.WriteLine("5. veiw  register for specific program");
            Console.WriteLine("6. Register subject for specific student");
            Console.WriteLine("7. Calculate fee for all Registered students");
            Console.WriteLine("8. Exit");
            int num = int.Parse(Console.ReadLine());
            return num;
            ;
        }
        static Student addstudent(List<Student> students)
        {

            string name;
            float fsc, ecat;
            int prefernce;
            string age;
            Console.WriteLine("Enter student name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter student age:");
            age = Console.ReadLine();
            Console.WriteLine("Enter student fsc marks:");
            fsc = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student ecat marks:");
            ecat = int.Parse(Console.ReadLine());
            Console.WriteLine(" how many prefernces:");
            prefernce = int.Parse(Console.ReadLine());
            Student s1 = new Student(name, age, fsc, ecat, prefernce);
            Degree s = new Degree();
            for (int i = 0; i < prefernce; i++)
            {
                Console.WriteLine("enter degree program");
                s.degreetitle = Console.ReadLine();
                s1.prefernceadd(s);

            }
           
            return s1;

        }
        static void adddegree(List<Degree> degree)
        {
            Subject s = new Subject();
            Degree degreeis = new Degree();
            string degreename, type;
            int seats, degreeduration, num, code, credithour, fee;
            Console.WriteLine("Enter Program name:");
            degreename = Console.ReadLine();
            Console.WriteLine("Enter degree duration:");
            degreeduration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many subjects:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enterseats number :");
            seats = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {

                Console.WriteLine("Subject Code: ");
                code = int.Parse(Console.ReadLine());

                Console.WriteLine("Subject Type: ");
                type = Console.ReadLine();
                Console.WriteLine("Subject fee: ");
                fee = int.Parse(Console.ReadLine());
                Console.WriteLine("credit our should not increase from 20");
                Console.Write("Subject Credit Hours: ");
                credithour = int.Parse(Console.ReadLine());
                if (credithour + s.credithour() < 20)
                {
                    Subject s1 = new Subject(type, code, fee, credithour);
                    degreeis.addsubject(s1);
                }
                else
                {
                    Console.WriteLine("only 20 credit hours can  aadded");
                }


            }
            degreeis.adddegree(degree, new Degree(degreename, degreeduration, seats));

        }
        static void genratemerit(List<Student> students)
        {
            Student s = new Student();
            for (int i = 0; i < students.Count; i++)
            {
                s.merit();

            }

            students.Sort((a, b) => a.meritis.CompareTo(b.meritis));
            students.Reverse();

            foreach (var student in students)
            {
                foreach (var preference in student.prefernces)
                {
                    Console.WriteLine(preference.seats);
                    if (preference.seats > 0)
                    {
                        student.registeredDegree = preference;
                        preference.seats--;
                        break;
                    }
                }
                if (student.registeredDegree == null)
                {
                    Console.WriteLine("{0} Did Not Got Admission", student.name);
                }
                else
                {
                    Console.WriteLine("{0} Got Admission in {1}", student.name, student.registeredDegree.degreetitle);
                }
            }
        }
        static void calculatefee(List<Student> students)
        {
            Console.WriteLine("Name\tFees");
            foreach (var student in students)
            {
                if (student.registeredDegree != null)
                {
                    Console.WriteLine("{0}\t{1}", student.name, student.fee());
                }
            }

        }
        static void register(List<Student> students)
        {
            Console.WriteLine("Name\tAge\tEcat marks\tFsc");
            foreach (var student in students)
            {
                if (student.registeredDegree != null)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", student.name, student.age, student.ecat, student.fsc);
                }
            }
        }
        static void ViewSpecificProgram(List<Degree> degree, List<Student> students)
        {
            Console.Clear();
            Console.Write("Degree Program: ");
            string Degree = Console.ReadLine();
            if (degree.Find(d => d.degreetitle == Degree) != null)
            {
                foreach (var student in students)
                {
                    if (student.registeredDegree != null)
                    {
                        if (student.registeredDegree.degreetitle == Degree)
                        {
                            Console.WriteLine(student.name);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Degree Program Does Not Exists");
            }
        }
        static void ViewRegisteredStudents(List<Student> students)
        {
            Console.Clear();
            Console.WriteLine("Name\tFsc\teCAT\tAge\n");
            foreach (var student in students)
            {
                if (student.registeredDegree != null)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", student.name, student.fsc, student.ecat, student.age);
                }
            }
            
        }
    }
}
