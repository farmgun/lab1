using System;

namespace lb1
{
    public class Money
    {

      
   
        public int count;
        public int much;

        public Money(int count) : this(count, 100)
        {
        }
        public Money(int count, int much)
        {
            this.count = count;
            this.much = much;
        }

        public void GetInfo()
        {
            Console.WriteLine($"номинал: {count}  количество: {much}");
        }
        
            
       
        public void Main(string[] args)
        {
            Console.Write("Введите количество купюр 10: ");
            int n10 = Convert.ToInt32(Console.ReadLine());
            if (n10 < 0)
            {
                Console.WriteLine("количество должно быть больше нуля");
            }
            else
            {
                int n = 25;
                n = n10;
            }


            Console.Write("Введите количество купюр 20: ");
            int n20 = Convert.ToInt32(Console.ReadLine());
            if (n20 < 0)
            {
                Console.WriteLine("количество должно быть больше нуля");
            }
            else
            {
                int n = 25;
                n = n20;
            }


            Console.Write("Введите количество купюр 50: ");
            int n50 = Convert.ToInt32(Console.ReadLine());
            if (n50 < 0)
            {
                Console.WriteLine("количество должно быть больше нуля");
            }
            else
            {
                int n = 25;
                n = n50;
            }


            Console.Write("Введите количество купюр 100: ");
            int n100 = Convert.ToInt32(Console.ReadLine());
            if (n100 < 0)
            {
                Console.WriteLine("количество должно быть больше нуля");
            }
            else
            {
                int n = 25;
                n = n100;
            }
            Money ten = new Money(10, n10);
            ten.GetInfo();
            Money twenty = new Money(20, n20);
            twenty.GetInfo();
            Money fifteen = new Money(50, n50);
            fifteen.GetInfo();
            Money hundreet = new Money(100, n100);
            hundreet.GetInfo();






            int sums = ten.count * ten.much + twenty.count * twenty.much + fifteen.count * fifteen.much + hundreet.count * hundreet.much;


            Console.Write("Введите суму покупки: ");
            int byu = Convert.ToInt32(Console.ReadLine());

            double byucount = sums / byu;
            if (byucount > 1)
            {
                Console.WriteLine($"кількість одиниць товару які ви можете придбати:{byucount}");
            }
            else
            {
                Console.WriteLine("вам не вистає грошей на покупку");
            }

           

        }

      
    }
        


    }


