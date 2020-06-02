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
            Console.Write("Hva er 2+2? ");
            var answer = Console.ReadLine();
            return answer == "4";
        }
    }
}
