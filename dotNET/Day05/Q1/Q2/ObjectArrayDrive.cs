/*
use the last Acoount Array class and now call the display method using array of object
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ObjArrayDriver
    {
        static void Main(string[] args)
        {
            Account [] acc = new Account[3];
            acc[0] = new Account("omkar", "harishcharda", "sakpal", 1_00_000);
            acc[1] = new Account("sanket", "sanjay", "more", 90_000);
            acc[2]= new Account("sarthak", "shrikrishna", "dargalkar", 1_10_000);

            for(int i = 0; i < acc.Length; i++)
            {
                acc[i].Disp();
            }

        }
    }
}
