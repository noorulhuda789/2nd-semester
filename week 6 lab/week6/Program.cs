using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week6.DL;
using week6.BL;
using week6.UI;
namespace week6
{

    public class Program
    {
        static void Main(string[] args)
        {
            string subjectPath = "C:\\Users\\hp\\Documents\\2nd semester\\opp and pd\\Subject.txt";
            string degreePath = "C:\\Users\\hp\\Documents\\2nd semester\\opp and pd\\Degree.txt"; 
            string studentPath = "C:\\Users\\hp\\Documents\\2nd semester\\opp and pd\\Student.txt";
            if (SubjectDL.readFromFile(subjectPath))
            {
                Console.WriteLine("Subject Data Loaded Successfully");
            }
            if (DegreeDL.readFromFile(degreePath))
            {
                Console.WriteLine("Degree Program Data Loaded Successfully");
            }
            if (Studentdl.readFromFile(studentPath))
            {
            }
            Console.WriteLine("Student Data Loaded Successfully");
            string option;
            do
            {
                option = MenuUI.menu(); MenuUI.clearScreen();
                if (option == "1")
                {
                    
                        Student s = StudentUI.addstudent();
                        Studentdl.addIntoStudentList(s);
                        Studentdl.storeintoFile(studentPath, s);
                    
                }
                else if (option == "2")
                {
                    Degree d = DegreeUI.takeInputForDegree();
                    DegreeDL.addIntoDegree(d);
                    DegreeDL.storeintoFile(degreePath, d);
                }
                else if (option == "3")
                {
                    List<Student> sortedStudentList = new List<Student>();
                    sortedStudentList = Studentdl.sortStudentsByMerit();
                    Studentdl.giveAdmission(sortedStudentList);
                    StudentUI.printStudents();
                }
                else if (option == "4")
                {
                    StudentUI.register();
                }
                else if (option == "5")
                {
                    string degName;
                    Console.Write("Enter Degree Name: ");
                    degName = Console.ReadLine();
                    StudentUI.viewStudentInDegree(degName);

                }
                else if (option == "6")
                {
                    Console.Write("Enter the Student Name: ");
                    string name = Console.ReadLine();
                    Student s = Studentdl.StudentPresent(name);
                    if (s != null)
                    {
                        SubjectUI.veiwsubject(s);
                        SubjectUI.registerSubjects(s);
                    }
                    else if (option == "7")
                        StudentUI.calculateFeeForAll();
                }
                MenuUI.clearScreen();
            }
            while (option != "8");
        }
    }
}

