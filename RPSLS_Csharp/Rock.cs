using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Csharp
{
    public class Rock : Choice
    {
        public Rock()
        {
            this.name = "Rock";
        }

        public override void Compare(string name)
        {
            if(name == "Scissors" || name == "Lizard")
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
