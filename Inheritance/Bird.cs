using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class
        public Bird()
        {
            IsAlive = true;
                                 
        }
        public string Color { get; set; }
        public bool Migrate { get; set; }
        public bool CanTalk { get; set; }
        public bool CanFly { get; set; }
    }
}
