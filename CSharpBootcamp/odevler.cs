using System;
using System.Collections.Generic;

namespace CSharpBootcamp
{
    class odevler
    {
        static void Main(string[] args)
        {
            
            //1.Soru
            /*
            Console.WriteLine("Lütfen son sayıyı giriniz: ");
            string s;
            int bitis, toplam = 0;
            s = Console.ReadLine();
            bitis = Convert.ToInt32(s);

            for (int i = 1; i <= bitis; i++)
                toplam += i;

            Console.WriteLine(bitis + " sayısına kadar olan sayıların toplamı: " + toplam);



            //2.Soru

            Random random = new Random();
            int rastgeleId = random.Next(1, 11);

            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Name = "Semih" });
            users.Add(new User() { Id = 2, Name = "Ahmet" });
            users.Add(new User() { Id = 3, Name = "Mehmet" });
            users.Add(new User() { Id = 4, Name = "Ayşe" });
            users.Add(new User() { Id = 5, Name = "Canan" });
            users.Add(new User() { Id = 6, Name = "Duru" });
            users.Add(new User() { Id = 7, Name = "Doruk" });
            users.Add(new User() { Id = 8, Name = "Ferit" });
            users.Add(new User() { Id = 9, Name = "Ceylin" });
            users.Add(new User() { Id = 10, Name = "Ahu" });

            foreach (var item in users)
            {
                if (item.Id == rastgeleId)
                    Console.WriteLine(rastgeleId + " " + item.Name);
            }
            */


            //Fibonaççi

            int ilksayi = 1;
            int ikincisayi = 1;
            int uzunluk;
            Console.Write("Fibonacci eleman sayısı giriniz = ");
            uzunluk = Convert.ToInt32(Console.ReadLine());
            Console.Write(ilksayi + " " + ikincisayi + " ");
            for (int i = 3; i <= uzunluk; i++)
            {
                int sonrakisayi = ilksayi + ikincisayi;
                Console.Write(sonrakisayi + " ");
                ilksayi = ikincisayi;
                ikincisayi = sonrakisayi;
            }

        }
        class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
