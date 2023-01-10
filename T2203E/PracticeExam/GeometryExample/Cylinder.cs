using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace T2203E_CSharp.PracticeExam.GeometryExample
{
    public class Cylinder
    {
        public Cylinder() { }
        
        public float BaseArea { get; set; }
        public double Radius { get; set; }
        public float LateralArea { get; set; }
        public double Height { get; set; }
        public float TotalArea { get; set; }
        public float Volume { get; set; }

        public void Process()
        {
            BaseArea = (float)(Radius*Radius*Math.PI);

            LateralArea = (float)(2*Math.PI*Radius*Height);

            TotalArea = (float)(2*Math.PI*Radius*(Height+Radius));

            Volume = (float)(Math.PI*Radius*Radius*Height);

        }

        public void Result()
        {
            Console.WriteLine("Enter the dimensions of the cylinder");
            double Radius = Convert.ToDouble(Console.ReadLine());
            double Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Radius : " +Radius);
            Console.WriteLine("Height : " +Height);
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius : " +Radius + "Height : " +Height);
            Console.WriteLine("Base: " +BaseArea);
            Console.WriteLine("Lateral: " +LateralArea);
            Console.WriteLine("Total: " +TotalArea);
            Console.WriteLine("Volume: " +Volume);

        }

    }
}
