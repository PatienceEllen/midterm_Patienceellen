using System;

namespace CommunityCollege
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor("L12345678", "fritz", "herbert", "psychology");
            Console.WriteLine(professor.ToString());

            professor.FirstName = "Potato";
            Console.WriteLine(professor.ToString());

            try
            {
                professor.LNumber = "123456789";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
