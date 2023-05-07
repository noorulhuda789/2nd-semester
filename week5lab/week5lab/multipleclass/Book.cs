using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5lab.multipleclass
{

    class Book
    {
        public string name;
        public int pagenumber;
        public string chaptername;
        public List<string> chapter = new List<string>();
        public int bookmark;
        public int price;

        public Book(string name, int pagenumber, int bookmark, int price)
        { 
            this.name = name;
            this.pagenumber = pagenumber;
            this.bookmark = bookmark;
            this.price = price;
            //this. chapter = chapter;


        }
        public Book()
            {

            }
           public int getbookmark()
        {
            Console.WriteLine(bookmark);
            return bookmark;
        }
        public void  getbookmark(int num)
        {
            this.bookmark = num;
        }
        public int priceis()
        {
            return price;
        }
        public void newprice(int num)
        {
            this.price = num;
        }
        public string chapternameis(int p)
        {
            string chap="";
            if(p<chapter.Count)
            {
               
                 chap = chapter[p-1];
                
            }
            return chap;
        }

    }
}
