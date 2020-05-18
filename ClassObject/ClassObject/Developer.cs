using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    //inheretance
    class Developer : Person
    {
        public int Experience;
        public string[] Knowledge;

        public Developer(string name,string surname):base(name,surname)
        {
                
        }

        //polymorphithm
        public override string GetFullInfo()
        {
            return $"{base.GetFullInfo()} experience : {Experience}";
        }
    }
}
