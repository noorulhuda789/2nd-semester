using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using week6.BL;
namespace week6.DL
{
    class Studentdl
    {
        public static List<Student> studentList = new List<Student>();

        public static void addIntoStudentList(Student s)
        {
            studentList.Add(s);
        }

        public static Student StudentPresent(string name)
        {
            foreach (Student s in studentList)
            {
                if (name == s.name && s.registeredDegree != null)
                {
                    return s;
                }
            }
            return null;
        }
        public static List<Student> sortStudentsByMerit()
        {
            List<Student> sortedStudentList = new List<Student>();
            foreach (Student s in studentList)
            {
                s.merit();

            }
            sortedStudentList = studentList.OrderByDescending(o => o.merits).ToList();

            return sortedStudentList;
        }
        public static void giveAdmission(List<Student> sortedStudentList)
        {
            foreach (Student s in sortedStudentList)
            {
                foreach (Degree d in s.prefernces)
                {
                    if (d.seats > 0 && s.registeredDegree == null)
                    {
                        s.registeredDegree = d;
                        d.seats--;

                        break;

                    }
                }
            }
        }
        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {

                    string[] splittedRecord = record.Split(';');
                    string name = splittedRecord[0];
                    string age = splittedRecord[1];
                    int fscMarks = int.Parse(splittedRecord[2]);
                    int ecatMarks = int.Parse(splittedRecord[3]);
                    string[] splittedRecordForPreference = splittedRecord[4].Split(';');
                    List<Degree> preferences = new List<Degree>();
                    for (int x = 0; x < splittedRecordForPreference.Length; x++)
                    {
                        Degree d = DegreeDL.isDegreeExists(splittedRecordForPreference[x]);
                        if (d != null)
                        {
                            if (!(preferences.Contains(d)))
                            {

                                preferences.Add(d);
                            }
                        }
                    }
                    Student s = new Student(name, age, fscMarks, ecatMarks, preferences);
                    studentList.Add(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeintoFile(string path, Student s)
        {
            StreamWriter f = new StreamWriter(path, true);
            string degreeNames = "";
            for (int x = 0; x < s.prefernces.Count - 1; x++)
            {
                degreeNames = degreeNames + s.prefernces[x].degreetitle + ";";
            }
            degreeNames = degreeNames + s.prefernces[s.prefernces.Count -1].degreetitle; 
            f.WriteLine(s.name + "," + s.age + "," + s.fsc + "," + s.ecat+ "," + degreeNames);
            f.Flush();
            f.Close();
        }
    }
}
    











