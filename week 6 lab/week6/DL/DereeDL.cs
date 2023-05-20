using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week6.BL;
using System.IO;
namespace week6.DL
{
    class DegreeDL
    {
        public static List<Degree> programList = new List<Degree>();
        public static void addIntoDegree(Degree Program)
        {
            programList.Add(Program);
        }

        public static Degree isDegreeExists(string degreeName)
        {
            foreach (Degree d in programList)
            {
                if (d.degreetitle == degreeName)
                {
                    return d;
                }
            }
            return null;
        }
        public static void storeintoFile(string path, Degree d)
        {
            StreamWriter f = new StreamWriter(path, true);
            string SubjectNames = "";
            for (int x = 0; x < d.subjects.Count; x++)
            {
                SubjectNames = SubjectNames + d.subjects[x].name + ";";
            }
            SubjectNames = SubjectNames + d.subjects[d.subjects.Count - 1].name;

            f.WriteLine(d.degreetitle + "," + d.degreeduration + "," + d.seats + SubjectNames);
            f.Flush();
            f.Close();

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

                    string degreeName = splittedRecord[0];
                    float degreeDuration = float.Parse(splittedRecord[1]);
                    int seats = int.Parse(splittedRecord[2]);
                    string[] splittedRecordForSubject = splittedRecord[3].Split(';');
                    Degree d = new Degree(degreeName, degreeDuration, seats);
                    for (int x = 0; x < splittedRecordForSubject.Length; x++)
                    {
                        Subject s = SubjectDL.isSubjectExists(splittedRecordForSubject[x]);
                        if (s != null)
                        {
                            d.Addsubject(s);
                        }
                    }

                    addIntoDegree(d);
                }
                f.Close();
                return true;
            }
            else
            {

                return false;
            }
        }
    }
}

