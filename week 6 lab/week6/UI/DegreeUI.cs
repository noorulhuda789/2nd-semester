using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week6.BL;
using week6.DL;
namespace week6.UI
{
    class DegreeUI
    {
        public static Degree takeInputForDegree()
        {
            string degreeName;
            float degreeDuration;
            int seats;
            Console.Write("Enter Degree Name: ");
            degreeName = Console.ReadLine();
            Console.Write("Enter Degree Duration: ");
            degreeDuration = float.Parse(Console.ReadLine());
            Console.Write("Enter Seats for Degree: ");
            seats = int.Parse(Console.ReadLine());
            Degree degProg = new Degree(degreeName, degreeDuration, seats);
            Console.Write("Enter How many Subjects to Enter: ");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Subject s = SubjectUI.takeinputforsubject();
                if (degProg.Addsubject(s))
                {
                    if ((SubjectDL.subjectslist.Contains(s)))
                    {
                        SubjectDL.addsubjects(s);
                        SubjectDL.storeintoFile("subject.txt", s);
                    }

                    Console.WriteLine("Subject Added");
                }

                else
                {
                    Console.WriteLine("Subject Not Added");
                    Console.WriteLine("20 credit hour limit exceeded");
                    x--;
                }
            }

            return degProg;
        }
        public static void veiwdegree()
        {
            foreach (Degree sub in DegreeDL.programList)
            {
                Console.WriteLine(sub.degreetitle);
            }
        }

    }
}

