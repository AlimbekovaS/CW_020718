using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CW_020718
{
    class Program
    {
        static void Main(string[] args)
        {
            Exm106();
            //try
            //{
            //    try
            //    {
            //        Exm04();
            //    }
            //    catch (IndexOutOfRangeException ie)
            //    {
            //        Console.WriteLine(ie.Message);
            //        Console.WriteLine(ie.Source);
            //        Console.WriteLine(ie.StackTrace);
            //        Console.WriteLine(ie.TargetSite);
            //        Console.WriteLine("--------------");
            //        //sent Email
            //        //повторное создание исключения
            //        throw new SmtpException(message: "Не удалось отправить почту");

            //    }

            //    catch (Exeption ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.Source);
            //    Console.WriteLine(ex.StackTrace);
            //    Console.WriteLine(ex.TargetSite);

            //}
        }

        static void Exm01()
        {
            int y = 0;
            int x = 56;
            if (y != 0)
                x = 56 / y;
            else
                x = 56 / 1;
            try
            {


            }
            catch 
            {

                Console.WriteLine("Exeption");
            }
        }

        static void Exm02()
        {
            try
            {
                Console.Write("Vvedite chislo tipa byte:");
                byte b = byte.Parse(Console.ReadLine());

                int[] myArray = new int[] { 1, 2, 1, 10, 12, 24 };
                Console.WriteLine("Исходный массив:");
                for (int p = 0; p < myArray.Length; p++)
                {
                    Console.WriteLine("{0}\t", myArray[p]);

                }
                //foreach (int item in myArray)
                    //Console.WriteLine("{0}\t", myArray);

                int i = 120;
                Console.WriteLine("\nДелим на число: \n");
                foreach (int item in myArray)
                    Console.WriteLine(i/item);

            }

            catch (OverflowException oe)
            {

                Console.WriteLine("Данное число не входит в диапазон 0 255");
                Console.WriteLine(oe.Message);
            }
            catch(DivideByZeroException de)
            {
                Console.WriteLine(" Деление но 0 нельзя");
                Console.WriteLine(de.Message);
            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine("Выход за пределы масива");
                Console.WriteLine(ie.Message);
            }
            finally
            {
                Console.WriteLine("-end-");
            }
        }

        //Фильтр исключении
        static void Exm03()
        {
            int X = 1;
            int Y = 0;
            try
            {
                int result = X / Y;

            }
            catch (Exception ex) when (Y==0) // этот кейтч отработает при условии в when 
            {
                Console.WriteLine("y не должен быть равен 0");
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void Exm04()
        {
            Exm05(11, 1989, 1);
            Exm05(y: 2018, m: 12, d: 01);
            throw new IndexOutOfRangeException(message: "УПС )))");
        }
        static void Exm05(int m, int y, int d)

        {

        }        
    }

    static void Exm06()
    {
        int[] val = { 10, 7 };
        foreach (var item in val)
        {

            try
            {
                Console.WriteLine("{0} divide by 2 is {1)", item, DbyT(item));

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("{0}:{1}", ae.GetType().Name, ae.Message);
            }
        }
    }
    static int DbyT(int num)
    {
        if ((num & 1) == 1)
            throw new ArgumentException(string.Format("{0} is not even number", num), "num");
        return num / 2;
    }

    static void Em107()
    {
        try
        {

        }
        catch (DirectoryNotFoundExeption ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
        
    

}
