/*Create the class and define the user define Exception 
*/

namespace ExceptionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgeCheker ageCheker = new AgeCheker();
            ageCheker.CheckAge(190);
        }
    }
}
