namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Original Code
            /*int answer = 4;
            string response;
            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + " is greater than or equal to nine";
            }*/

            var answer = 4;
            var response = (answer < 9) ? " is less than nine" : " is greater than or equal to nine";

            Console.WriteLine($"{answer}{response}");
        }
    }
}
