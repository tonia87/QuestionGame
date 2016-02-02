using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionGame___List
{
    class Query
    {
        //private int _id;
        //public int id
        //{
        //    set { _id = value; }
        //    get { return _id; }
        //}

        //private int _played;
        //public int played
        //{
        //    set { _played = value; }
        //    get { return _played; }
        //}

        //private string _quote;
        //public string quote
        //{
        //    set { _quote = value; }
        //    get { return _quote; }
        //}

        public int id { set; get; }
        public int played { set; get; }
        public string quote { set; get; }
        
        public int difficulty;
        public int type;
        public int degrees; 
        public string[] answer;


       //public Query() { Console.WriteLine("Default called"); }

        public Query(){return; }
        public Query(int id,int played,int diff,int t,int deg,string quote, int correct,string a1,string a2,string a3,string a4)
        {
            id = this.id;
            played = this.played;
            difficulty = diff;
            type = t;
            degrees = deg;
            quote = this.quote;
            answer = new string[]{correct.ToString(),a1,a2,a3,a4};
           
            Console.WriteLine("Object "+id+" created");
        }
        ~Query()
        {
            Console.WriteLine("Object "+this.id+" Destructed");
        }

       
        }
}
