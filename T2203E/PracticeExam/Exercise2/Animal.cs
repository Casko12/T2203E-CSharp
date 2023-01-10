using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.PracticeExam.Exercise2
{
    public class Animal
    {
        public string Name { get; set; }
        public int Weight  { get; set; }
        public void Show()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Weight: " + Weight);
        };
        public void SetMe(int Weight, string Name)
        {
            this.Name= Name;
            this.Weight= Weight;
        };
    }
}
