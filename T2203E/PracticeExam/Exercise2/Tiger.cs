using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.PracticeExam.Exercise2
{
    public class Tiger : Animal
    {
        public Tiger() {}
        
        public override void Show()
        {
            
        }
        public override void SetMe(int weight, string name)
        {
            Name = "Tiger";
            Weight = 100;
        }
    }
}
