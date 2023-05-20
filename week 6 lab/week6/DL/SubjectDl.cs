using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using week6.BL;
namespace week6.DL
{
    class SubjectDL
    {

            public static List<Subject> subjectslist = new List<Subject>();
            public static void addsubjects(Subject s)
            {
                subjectslist.Add(s);
            }
            public static bool readFromFile(string path)
            {
                StreamReader f = new StreamReader(path);
                string record;
                if (File.Exists(path))
                {
                    while ((record = f.ReadLine()) != null)
                    {
                        string[] splittedRecord = record.Split(',');
                        string code = splittedRecord[0];
                        string type = splittedRecord[1];
                        int creditHours = int.Parse(splittedRecord[2]);
                        int subjectFees = int.Parse(splittedRecord[3]);
                        Subject s = new Subject(code, type, creditHours, subjectFees);
                        addsubjects(s);

                    }
                    f.Close();
                    return true;

                }
                else

                {

                    return false;
                }

            }
            public static void storeintoFile(string path, Subject s)
            {
                StreamWriter f = new StreamWriter(path, true);
                f.WriteLine(s.code + "," + s.name + "," + s.credithours + s.fee);

                f.Flush();
                f.Close();


            }
            public static Subject isSubjectExists(string type)
            {
                foreach (Subject s in subjectslist)
                {
                    if (s.name == type)

                    {
                    }
                    return s;
                }
                return null;
            }
        }
    }










