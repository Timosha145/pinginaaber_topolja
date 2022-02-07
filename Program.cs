using System;

namespace pinginaaber_topolja
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("First person name?");
            //string name1 = Console.ReadLine();
            //Console.WriteLine("Second person name?");
            //string name2 = Console.ReadLine();
            //if (name1=="Artjom" && name2=="Timofei" || name1 == "Artjom" && name2 == "Timofei")
            //{
            //    Console.WriteLine("They sit together");
            //}
            //else if (name1 == "Angelina" && name2 == "Ilja" || name1 == "Angelina" && name2 == "Ilja")
            //{
            //    Console.WriteLine("They sit together");
            //}
            //else if (name1 == "Ilja" && name2 == "Anton" || name1 == "Ilja" && name2 == "Anton")
            //{
            //    Console.WriteLine("They sit together");
            //}
            //else if (name1 == "Artjom" && name2 == "Denis" || name1 == "Artjom" && name2 == "Denis")
            //{
            //    Console.WriteLine("They sit together");
            //}
            //else 
            //{
            //    Console.WriteLine("Don't sit together");
            //}
            Console.WriteLine("Do you want euro remont?");
            string answer = Console.ReadLine();
            if (answer.ToLower()=="yes")
            {
                Console.WriteLine("Length of first wall in meters?");
                double Firstwall = double.Parse(Console.ReadLine());
                Console.WriteLine("Length of second wall in meters?");
                double Secondwall = double.Parse(Console.ReadLine());
                double S = Firstwall * Secondwall;
                Console.WriteLine("How much money for 1 m2?");
                double m2price = double.Parse(Console.ReadLine());
                Console.WriteLine($"Floor price is {S*m2price}£");
            }
            else
            {
                Console.WriteLine("Bye Bye!");
            }
        }
    }
}
