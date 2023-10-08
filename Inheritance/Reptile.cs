using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class
    public class Reptile : Animal
    {
        public Reptile() 
        {
         IsColdBlooded = true;
         IsScaly = true;
        }
        public bool IsColdBlooded { get; set; }
        public string LivingSpace { get; set; }
        public bool IsScaly { get; set; }
        public string Color { get; set; }



    }
}
