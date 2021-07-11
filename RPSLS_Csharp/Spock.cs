using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Csharp
{
    public class Spock : Choice
    {
        public Spock()
        {
            this.name = "Spock";
        }

        public override void Compare(string name)
        {
            if (name == "Scissors" || name == "Rock")
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
