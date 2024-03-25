

using System;
class Program
{
    static void Main(string[] args)
    {
     
        Console.WriteLine("Por favor, digite sua idade:");

   
        if (int.TryParse(Console.ReadLine(), out int idade))
        {
         
            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você não é maior de idade.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, digite uma idade válida.");
        }
    }
}