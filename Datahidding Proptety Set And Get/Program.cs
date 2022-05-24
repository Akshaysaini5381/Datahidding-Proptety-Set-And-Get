using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datahidding_Proptety_Set_And_Get
{

    class Data
    {
        private string  name;

        public string show
        {
            set
            {
                this.name = value;
            }
            get
            {
                return name;
            }
        }
      
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Data obj = new Data();
           
            string n = obj.show = "This is my proparty And get set use";
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
