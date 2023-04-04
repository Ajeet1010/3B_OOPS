namespace _3B_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  1. Constructor  2. Access Modifiers  3. Interfaces  *****");
            Console.Write("Enter ur choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Constructor");
                    Constructor constructor = new Constructor(1, "Aman");
                    Console.WriteLine(constructor.ID  + "  " + constructor.Name);
                    break;
            }
            
        }
    }
}