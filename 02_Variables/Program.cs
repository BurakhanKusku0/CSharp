using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region double variables
            //double number;
            //number = 1.84;
            //Console.WriteLine(number);

            //Console.WriteLine("Price List");
            //Console.WriteLine();

            //double  orangePrice, tomatoPrice, strawberryPrice, potatoPrice, applePrice, bananaPrice ;

            //orangePrice = 5.2;
            //tomatoPrice = 5.75;
            //strawberryPrice = 7.2;
            //potatoPrice = 1.25;
            //applePrice = 3.28;
            //bananaPrice = 0.89;

            //Console.WriteLine("Orange unit price : " + orangePrice + " Euro");
            //Console.WriteLine("Tomato unit price : " + tomatoPrice + " Euro");
            //Console.WriteLine("Strawberry unit price : " + strawberryPrice + " Euro");
            //Console.WriteLine("Potato unit price : " + potatoPrice + " Euro");
            //Console.WriteLine("Apple unit price : " + applePrice + " Euro");
            //Console.WriteLine("Banana unit price : " + bananaPrice + " Euro");

            //double orangeGram, tomatoGram, strawberryGram, potatoGram , appleGram, bananaGram ;

            //orangeGram = 2.485;
            //tomatoGram = 1.842;
            //strawberryGram = 0.875;
            //potatoGram = 3.450;
            //appleGram = 1.891;
            //bananaGram = 4.819;

            //double orangeTotalPrice = orangePrice * orangeGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double appleTotalPrice = applePrice * appleGram;
            //double bananaTotalPrice = bananaPrice * bananaGram;
            //Console.WriteLine();

            //Console.WriteLine("Product Received : Orange --- " + "Unit Price : " + orangePrice + " --- Gramaj : " + orangeGram + " --- Total Price : " + orangeTotalPrice); Console.WriteLine();
            //Console.WriteLine("Product Received : Tomato --- " + "Unit Price : " + tomatoPrice + " --- Gramaj : " + tomatoGram + " --- Total Price : " + tomatoTotalPrice); Console.WriteLine();
            //Console.WriteLine("Product Received : Strawberry --- " + "Unit Price : " + strawberryPrice + " --- Gramaj : " + strawberryGram + " --- Total Price : " + strawberryTotalPrice); Console.WriteLine();
            //Console.WriteLine("Product Received : Potato --- " + "Unit Price : " + potatoPrice + " --- Gramaj : " + potatoGram + " --- Total Price : " + potatoTotalPrice); Console.WriteLine();
            //Console.WriteLine("Product Received : Apple --- " + "Unit Price : " + applePrice + " --- Gramaj : " + appleGram + " --- Total Price : " + appleTotalPrice); Console.WriteLine();
            //Console.WriteLine("Product Received : Banana --- " + "Unit Price : " + bananaPrice + " --- Gramaj : " + bananaGram + " --- Total Price : " + bananaTotalPrice); Console.WriteLine();

            //double TotalPrice = 0;

            //TotalPrice = orangeTotalPrice + tomatoTotalPrice + strawberryTotalPrice + potatoTotalPrice + appleTotalPrice + bananaTotalPrice;

            //Console.WriteLine("Total Price : " + TotalPrice + " Euro");

            #endregion

            #region Char variables

            //char symbol;
            //symbol = 't';
            //Console.WriteLine(symbol);

            #endregion

            #region string data entry from keyboard

            //Console.WriteLine("Airline Passenger Information");
            //Console.WriteLine();

            //string passangerId, passangerName, passangerSurname , passangerDistinct, passangerCity, passangerAge;


            //Console.Write("Enter Passenger ID : ");
            //passangerId = Console.ReadLine();

            //Console.Write("Enter Passenger Name : ");
            //passangerName = Console.ReadLine();

            //Console.Write("Enter Passenger Surname : ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("Enter Passenger Distinct : ");
            //passangerDistinct = Console.ReadLine();

            //Console.Write("Enter Passenger City : ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Enter Passenger Age : ");
            //passangerAge = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------");
            //Console.WriteLine("Passenger ID : " + passangerId);
            //Console.WriteLine("Passenger Name : " + passangerName + " " + passangerSurname) ;
            //Console.WriteLine("Passenger Address : " + passangerDistinct + passangerCity) ;
            //Console.WriteLine("Passenger Age : " + passangerAge) ;

            #endregion

            #region integer inputs and conversions from the keyboard

            //int carWashSwab, carSmell, carTire, carWashFoam;

            //carWashSwab = 120;
            //carSmell = 180;
            //carTire = 4250;
            //carWashFoam = 240;

            //int SwabCount, SmellCount, TireCount, FoamCount;

            //Console.WriteLine("Please Enter How Many Car Wash Swab You Purchased : ");
            //SwabCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter How Many Car Smell Yuo Purchased : ");
            //SmellCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter How Many Car Tire Yuo Purchased : ");
            //TireCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter How Many Car Wash Foam Yuo Purchased : ");
            //FoamCount = int.Parse(Console.ReadLine());

            //int totalPrice = carWashSwab * SwabCount + carSmell * SmellCount + carTire * TireCount + carWashFoam * FoamCount;


            //Console.WriteLine();

            //Console.WriteLine("Total Price : " + totalPrice);
            #endregion

            #region decimal number operations from the keyboard

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Please Enter The 1st Exam Grade : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter The 2st Exam Grade : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter The 3st Exam Grade : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Your Course Average : " + result);

            #endregion

            #region character input from keyboard

            //char gender;
            //Console.Write("Please Enter Your Gender : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Gender of your choice : " + gender);
            #endregion

            Console.Read();
        }
    }
}
