using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week6.BL;
using week6.DL;
namespace week6.UI
{
    class SubjectUI
    {
        public static Subject takeinputforsubject()
        {
            string type, code;
            int credithour, fee;
            Console.WriteLine("Subject Code: ");
            code = Console.ReadLine();

            Console.WriteLine("Subject Type: ");
            type = Console.ReadLine();
            Console.WriteLine("Subject fee: ");
            fee = int.Parse(Console.ReadLine());
            Console.WriteLine("credit our should not increase from 20");
            Console.Write("Subject Credit Hours: ");
            credithour = int.Parse(Console.ReadLine());
            Subject sub = new Subject(code, type, fee, credithour);
            return sub;
        }
        public static void veiwsubject(Student s)
        {
            if (s.registeredDegree != null)
            {
                Console.WriteLine(" sub code\t sub Type");
                foreach (Subject sub in s.registeredDegree.subjects)
                {
                    Console.WriteLine(sub.code + "\t" + sub.name);
                }
            }

        }
        public static void registerSubjects(Student s)
        {
            Console.WriteLine("Enter how many subjects you want to register");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("Enter the subject Code");
                string code = Console.ReadLine();

                bool Flag = false;
                foreach (Subject sub in s.registeredDegree.subjects)
                {
                    if (code == sub.code && !(s.subjects.Contains(sub)))
                    {
                        if (s.registerofsubjects(sub))
                            Flag = true;
                        break;

                    }
                    else
                        Console.WriteLine("A student cannot have more than 9 CH");
                    Flag = true;

                    break;
                    {

                        if (Flag == false)
                        {
                            Console.WriteLine("Enter Valid Course");
                            x--;
                        }
                    }
                }
            }
        }

    }
}



