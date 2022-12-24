using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.session1
{
    internal class Human
    {
        public string name;
        public int age;
        private int id;
        public static int xyz;
        public Human()
        {

        }
        public void Run()
        {
            Console.WriteLine("Running....");
            this.name = "Pham Duy Hung";
        }
        public void Run(string s)
        {

        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get => name;
            set => name = value; // giong o tren
        }

        public int Age
        {
            get => age;
            set => age = value;
        }
        public static void ScreenShot()
        {

        }
        public void Eat()
        {

        }

    }
}
