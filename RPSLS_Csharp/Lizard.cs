using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Csharp
{
    public class Lizard : Choice
    {
        public Lizard()
        {
            this.name = "Lizard";
        }

        public override void Compare(string name)
        {
            if (name == "Spock" || name == "Paper")
            {
                this.win = true;
            }
            else
            {
                this.win = false;
            }
        }
    }
}
