using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Csharp
{
    public class Scissors : Choice
    {
        public Scissors()
        {
            this.name = "Scissors";
        }

        public override void Compare(string name)
        {
            if (name == "Paper" || name == "Lizard")
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
