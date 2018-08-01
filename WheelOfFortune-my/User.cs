using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune_my
{
    public class User
    {
        public string Name  { get; set; }
        private bool Playing { get; set; }
        
        public User(string name)
        {
            Name = name;
            Playing = true;
        }

    }
}
