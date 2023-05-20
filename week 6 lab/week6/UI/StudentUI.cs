using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week6.BL;
using week6.DL;
namespace week6.UI
{
    class StudentUI
    {
        public static void printStudents()
        {
            foreach (Student s in Studentdl.studentList)
            {
                if (s.registeredDegree != null)
                {
                    Console.WriteLine(s.name + " got Admission in " + s.registeredDegree.degreetitle);
                }
                else
                {
                    Console.WriteLine(s.name + " did not get Admission");
                }
            }
        }
        public static void viewStudentInDegree(string degName)
        {

            Console.WriteLine("Name\tFSC\tEcat\tAge");
            foreach (Student s in Studentdl.studentList)
                if (s.registeredDegree != null)
                {

                    if (degName == s.registeredDegree.degreetitle)
                    {
                        Console.WriteLine(s.name + "\t" + s.fsc + "\t" + s.ecat + "\t" + s.age);
                    }
                }
        }
        public static void register()
        {
            Console.WriteLine("Name\tAge\tEcat marks\tFsc");
            foreach (var student in Studentdl.studentList)
            {
                if (student.registeredDegree != null)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", student.name, student.age, student.ecat, student.fsc);
                }
            }
        }
       public  static Student addstudent()
        {

            string name;
            float fsc, ecat;

            string age;
            List<Degree> prefernces = new List<Degree>();
            Console.WriteLine("Enter student name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter student age:");
            age = Console.ReadLine();
            Console.WriteLine("Enter student fsc marks:");
            fsc = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student ecat marks:");
            ecat = int.Parse(Console.ReadLine());
            Console.WriteLine(" how many prefernces:");
            int count = int.Parse(Console.ReadLine());

            Degree s = new Degree();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("enter degree program");
                s.degreetitle = Console.ReadLine();
                prefernces.Add(s);

            }

            Student s1 = new Student(name, age, fsc, ecat, prefernces);
            return s1;

        }
        public static void calculateFeeForAll()
        {
            foreach (Student s in Studentdl.studentList)
            {
                if (s.registeredDegree != null)
                {
                    Console.WriteLine(s.name + s.fee() + "fees");
                }
            }
        }
    }
}
