using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AdventureText
{
    public class KeyWithChallenge : Key
    {
        public KeyWithChallenge(string color) : base(color)
        {
            
        }

        public override bool IsUnlockApproves()
        {
            return "4" == Game.Instance.AskUser("Hva er 2+2? ");
        }
    }
}
