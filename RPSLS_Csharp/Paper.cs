using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Csharp
{
    public class Paper : Choice
    {
        public Paper()
        {
            this.name = "Paper";
        }

        public override void Compare(string name)
        {
            if (name == "Rock" || name == "Spock")
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
