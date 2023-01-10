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
        public float Radius { get; set; }
        public float LateralArea { get; set; }
        public float Height { get; set; }
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

        }


    }
}
