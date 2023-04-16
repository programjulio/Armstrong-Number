using System;

namespace Armstrong_Number
{
    class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            int num, temp, sum = 0, rem;
            Console.WriteLine("Escolha um número : ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num; 
            while(num>0)
            {
                rem = num % 10;
                sum = sum + rem * rem * rem;
                num = num / 10;
            }
            
            if(temp==sum)
            {
                Console.WriteLine("Número Narcisista.");
            }
            else
            {
                Console.WriteLine("Não é Narcisista.");
            }
            Console.ReadLine();
        }
    }
}
