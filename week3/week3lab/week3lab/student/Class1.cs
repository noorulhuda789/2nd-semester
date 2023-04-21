using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3lab
{
    class Product
    {
        public string name;
        public string category;
        public float price;
        public int quantity;
        public int minimum;
        public float tax;

        public float calculator()
        {
            if(category=="grocery")
            {
                tax =  price*0.1F;
            }
            else if (category == "fruit")
            {
                tax = price * 0.05F;
            }
            else
            {
                tax = price * 0.15F;
            }
            return tax;
        }
    }
    class clockType
    {

        public int hours;
        public int minutes;
        public int seconds;
       
            public clockType(int h)
        {
            hours = h;
        }

        public clockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public clockType(int h, int m)
        {
            hours = h;
            minutes = m;
        }
        public clockType(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public void incrementsecond()
        {
            seconds++;
        }
        public void incrementhour()
        {
            hours++;
        }
        public void incrementminute()
        {
            minutes++;
        }
        public void printtime()
        {
            Console.WriteLine(hours + " " + minutes + " " + seconds);
        }
        public bool isEqual(int h, int m, int s)
        {
            if (hours == h && minutes == m && seconds == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(clockType temp)
        {
            if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int ElapseTime()
        {
            int second = (this.hours * 60 * 60) + (this.minutes * 60) + this.seconds;
            return second;
        }
        public int RemainingTime()
        {
            int secondCurrent = (this.hours * 60 * 60) + (this.minutes * 60) + this.seconds;
            return 86400 - secondCurrent;
        }
        public int Difference(clockType C)
        {
            int second1 = (this.hours * 60 * 60) + (this.minutes * 60) + this.seconds;
            int second2 = (C.hours * 60 * 60) + (C.minutes * 60) + C.seconds;
            int difference = second1 - second2;
            if (difference < 0)
            {
                difference = difference * -1;
            }
            return difference;
        }
        public void formatter(int Time)
        {
            int hours;
            int minutes;
            int second;

            hours = Time / 3600;
            minutes = (Time / 60) % 60;
            second = Time - ((hours * 3600) + (minutes * 60));
            Console.WriteLine(hours + " : " + minutes + " : " + second);
        }
    }
    class Student
    {
        public Student()
        {
            Console.WriteLine("deafult constructor");
            name = "noor";
            matricmarks = 10f;
            fscmarks = 40f;
            ecatmarks = 100f;
            aggregate = 4.5f;
        }
        public Student(string name)
        {
            this.name = name;
        }
        public Student(string name, float matricmarks, float fscmarks, float ecatmarks, float aggregate)
        {
            this.name = name;
            this.matricmarks = matricmarks;
            this.fscmarks = fscmarks;
            this.ecatmarks = ecatmarks;
            this.aggregate = aggregate;
        }


        public string name;
        public float matricmarks;
        public float fscmarks;
        public float ecatmarks;
        public float aggregate;
    }
}

