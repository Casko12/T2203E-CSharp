using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.PracticeExam.Exercise2
{
    public class Lion : Animal
    {
        public Lion() {}
        
        public override void Show()
        {
            
        }
        public override void SetMe(int Weight, string Name)
        {
            Name = "Lion";
            Weight = 200;
        }
    }
}
