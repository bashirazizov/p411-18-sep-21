using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region datatypes
            //decimal number = 120.85M;
            //string[] list = { "mamed", "nicat" };

            //string names = "mamed";
            //char[] name = { 'm', 'a', 'm', 'e', 'd' };


            // var / dynamic / datatype

            //var data = "salam";

            //System.Console.WriteLine(data);

            //data = "sagol";

            //System.Console.WriteLine(data);


            //dynamic data = 10;

            //data = "asdas";
            #endregion

            #region condition
            //int day = 10;

            //if (age>16)
            //{
            //    Console.WriteLine("Tez cagir prizive");
            //}else if(age == 16){
            //    Console.WriteLine("Yavas cagir prizive");
            //}
            //else
            //{
            //    Console.WriteLine("Hele vaxti var");
            //}

            //switch (day) {
            //    case 1:
            //        Console.WriteLine("monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("tue");
            //        break;
            //    case 3:
            //        Console.WriteLine("wed");
            //        break;
            //    case 4:
            //        Console.WriteLine("thru");
            //        break;
            //    case 5:
            //        Console.WriteLine("fri");
            //        break;
            //    case 6:
            //        Console.WriteLine("sat");
            //        break;
            //    case 7:
            //        Console.WriteLine("sun");
            //        break;
            //    default:
            //        Console.WriteLine("problem");
            //        break;
            //}
            #endregion

            #region loops
            int max = 20;
            int min = 15;

            //int i = 0;
            //while (i<=max)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int i = max; i > min ; i--)
            //{
            //    Console.Write(i+"/");
            //}

            //do
            //{
            //    Console.WriteLine(min);
            //    min++;
            //} while (min<max);

            //int[] scores = {10, 94, 412, 123, 531 };
            //int sum = 0;

            //foreach (int score in scores)
            //{
            //    sum += score;
            //}

            //int average = sum / scores.Length;
            //Console.WriteLine(average);
            #endregion

            //Console.Write("Maasinizi daxil edin: ");
            //int salary = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Cekmek istediyiniz krediti daxil edin: ");
            //int creditAmount = Convert.ToInt32(Console.ReadLine());

            //if (salary*12*6/10>creditAmount)
            //{
            //    Console.WriteLine("Pulu al.");
            //}
            //else
            //{
            //    Console.WriteLine("Pul dusmur.");
            //}


            //Console.Write("birinci ededi daxil edin: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("ikinci ededi daxil edin: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("ucuncu ededi daxil edin: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int average = (num1 + num2 + num3) / 3;

            //if (average % 6 == 0)
            //{
            //    Console.WriteLine("Bolunur");
            //}
            //else
            //{
            //    Console.WriteLine("Bolunmur");
            //}


            Console.Write("ikireqemli eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num>9&&num<100)
            { 
                int teklik = num % 10;
                int onluq = (num - teklik)/10;

                if (onluq>teklik)
                {
                    Console.WriteLine("onluq boyukdur");
                }
                else if (onluq == teklik)
                {
                    Console.WriteLine("beraber");

                }
                else
                {
                    Console.WriteLine("teklik boyukdur");

                }
            }
            else
            {
                Console.WriteLine("ikireqemli deyil");
            }
        }

    }
}
