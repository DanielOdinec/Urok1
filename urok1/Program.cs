using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok1
{
    class Program
    {
        static void Main(string[] args)
        {









            //Console.WriteLine("kirjutage oma eesnimi,perekonnanimi ja isanimi");
            //string fio = Console.ReadLine();
            //Console.WriteLine("Mis grupist te olete?");
            //string grupp = Console.ReadLine();
            //Console.WriteLine("Mis variant teil on?");
            //string variant = Console.ReadLine();
            //Console.WriteLine("Kirjutage teie vanus?");
            //string vanus = Console.ReadLine();
            //Console.WriteLine("Mis soost te olete?");
            //string soo = Console.ReadLine();
            //Console.WriteLine("Teie laboratoorse töö number?");
            //string number = Console.ReadLine();
            //Console.WriteLine("Teie laboratoorse töö nimi?");
            //string nimisdf
            //    = Console.ReadLine();



            //StreamWriter filesse = new StreamWriter(@"..\..\andmed.txt", true);
            //filesse.WriteLine("eesnimi,perekonnanimi ja isanimi =>{0}",fio,grupp,variant);
            //filesse.Close();

            





















            //int a = 5;
            //int z = 3;
            //int v = 4;
            //int b = 2;
            //int c = 15 * (a + z) / 11 * (v - 13) * b;
            //Console.WriteLine(c);
            //Console.ReadLine();
            //StreamWriter filesse = new StreamWriter(@"..\..\andmed.txt", true);
            //filesse.WriteLine("Teie vastus=>{0}",c);
            //filesse.Close();

            string[] sonad = new string[7] { "aaa", "bbb", "ccc", "ddd", "eee", "fff", "zzz" };
            foreach (string sona in sonad)
            {
                Console.WriteLine(sona);
            }
            for (int i = 0; i < sonad.Length; i++)
            {
                Console.WriteLine(sonad[1]);
            }

            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Escape");
                key = Console.ReadKey();
            } while (key.Key!=ConsoleKey.Escape);

            double num1 = 8.2948565;
            num1 = Math.Round(num1, 5);
            Console.WriteLine(num1.ToString());
            Console.ReadKey();
            //Console.BackgroundColor = ConsoleColor.Cyan;//изменить цвет фона
            //Console.ForegroundColor = ConsoleColor.DarkMagenta;//изменить цвет букв
            //Console.Clear();
            //Console.WriteLine("Hello world!");//вывести на экран
            //Random rnd = new Random();// функция рандома
            //Console.WriteLine("jah-random, ei-ise sisestan numbri");
            //string soov = Console.ReadLine();
            //int num = 0;
            //if (soov == "jah")
            //{
            //    num = rnd.Next(1, 7);// дни недели 1-7 рандомно

            //}
            //else
            //{
            //    try
            //    {
            //        num = Convert.ToInt32(Console.ReadLine());


            //    }
            //    catch (SystemException)
            //    {
            //    }

            //}
            //Console.WriteLine("Päeva number: {0}", num.ToString());//выводит день 
            //string nimetus = "";
            //switch (num)
            //{
            //    case 1: nimetus = "esmaspäev"; break;
            //    case 2: nimetus = "teisipäev"; break;
            //    case 3: nimetus = "kolmapäev"; break;
            //    case 4: nimetus = "neljapäev"; break;
            //    case 5: nimetus = "reede"; break;
            //    case 6: nimetus = "laupäev"; break;
            //    case 7: nimetus = "pühapäev"; break;
            //    default:
            //        nimetus = "Viga!";
            //        break;
            //}

            //Console.WriteLine(nimetus);
            //StreamWriter filesse = new StreamWriter(@"..\..\andmed.txt", true);
            //filesse.WriteLine("Number oli {0},päev on {1}", num.ToString(), nimetus);
            //filesse.Close();
            //Console.WriteLine("Failis on salvestatud: Number oli" + num.ToString() + "päev on " + nimetus);
            //StreamReader filest = new StreamReader(@"..\..\andmed.txt");
            //string a = filest.ReadToEnd();
            //Console.WriteLine("Failis oli seda:\n" + a);



            //Console.ReadLine();


        }

    }
}
