
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIG.UIP.HW4.ConditionsArrays
{
    class Program
    {
        static void Main(string[] args)
        {       


           
            Notebook notebookFirst = new Notebook("Philips", 4, 2.56f);            
            Notebook notebookSecond = new Notebook("Asahi", 8, 5.24f);
            Server serverFirst = new Server("HP", 100, 24);
            Server serverSecond = new Server("DTS", 250, 128);

            Notebook[] notebooks= new Notebook[2] {notebookFirst, notebookSecond};
            for (int i =0; i<=notebooks.Length-1;i++)
            {                
                
                notebooks[i].DDR = 20;
                notebooks[i].printProperty();
            }
                
            
            




            Console.ReadLine();
        }

    }

    internal class Computers
    {
      

    }

    internal class Notebook
    {
        private string model;
        private int ddr;
        private float waight;
        public Notebook(string Model, int DDR, float Waight)
        {
            this.model = Model;
            this.ddr = DDR;
            this.waight = Waight;
            //Console.WriteLine(Model + " Notebook  " + DDR + " " + Waight);
        }
        public int DDR
        {
            set
            {
                ddr = ddr;
            }

        }
        public void printProperty()
        {
            Console.WriteLine(" Notebook  "+ model +" Value= " + ddr + "Gb RAM "+ " Waight=" + waight+"kg");
        }

       
       

    }
    internal class Server
    {
        private string name;
        private int hdd;
        private int countProcessors;
        internal Server (string Name, int HDD, int CountProcessors)
            {
            this.name = Name;
            this.hdd = HDD;
            this.countProcessors = CountProcessors;
            //Console.WriteLine("Server "+name+  "  Hard drive="+HDD+"Gb "+"Processors="+countProcessors);
            }
        public void printProperty()
        {
            Console.WriteLine("Server " + name + "  Hard drive=" + hdd + "Gb " + "Processors=" + countProcessors);
        }

    }

    internal class Tv
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void printName()
        {
            Console.WriteLine(name);
        }

    }
             

}