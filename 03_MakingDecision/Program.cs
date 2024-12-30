using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //Console.Write("Please Enter Password : ");
            //String password;
            //password = Console.ReadLine();
            //if (password == "pass")
            //{
            //    Console.WriteLine("Password Correct ");
            //}
            //else
            //{
            //    Console.WriteLine("Password is Wrong ");
            //}


            //----------------------------------------------


            //string capital, country;

            //Console.Write("Please Enter the Capital : ");
            //capital = Console.ReadLine();

            //Console.Write("Please Enter the Country : ");
            //country = Console.ReadLine();

            //if(capital == "London" & country == "England")
            //{
            //    Console.WriteLine("Information is Correct ");
            //}
            //else
            //{
            //    Console.WriteLine("Information is Wrong");
            //}


            //----------------------------------------------


            //int number;
            //Console.Write("Please Enter the Number : ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 10)
            //{
            //    Console.WriteLine("Number is Correct ");
            //}
            //else
            //{
            //    Console.WriteLine("Number is False ");
            //}


            //----------------------------------------------


            //int exam1 , exam2 , exam3 , average ;
            //string result = "Error !";

            //Console.Write("Please Enter your Exam 1 : ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Please Enter your Exam 2 : ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Please Enter your Exam 3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Average of Exams : " + average);

            //if (average > 0 & average <= 50 )
            //{
            //    result = "You Failed the Course" ;
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "You Passed the Course";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "You Passed the Course with a good GPA";
            //}
            //if (average > 84 & average < 100)
            //{
            //    result = "You passed the course perfectly";
            //}

            //Console.WriteLine(result);


            //----------------------------------------------



            //string city;
            //Console.Write("Please Enter Your City : ");
            //city = Console.ReadLine();

            //if (city == "London" | city == "Manchester" | city == "Liverpool" | city == "Birmingham")
            //{
            //    Console.WriteLine("City available");           
            //}
            //else
            //{
            //    Console.WriteLine("City not available");
            //}



            //----------------------------------------------

            //Console.Write("Please Enter Username : ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("This username is unacceptable");
            //}
            //else 
            //{
            //    Console.Write("Welcome " + username);
            //}



            #endregion

            #region Mode Operations

            //int number;
            //number = 25;
            //int result = number % 2;
            //Console.WriteLine(result);

            //**********************************************


            //Console.Write("Please Enter Number 1 : ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Please Enter Number 2 : ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("remainder from dividing the 1st number by the 2nd number : " + result);


            //**********************************************


            //Console.Write("Please Enter Number : ");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("the number is even");
            //}

            //else
            //{
            //    Console.WriteLine("the number is odd");
            //}

            #endregion

            #region Decision Structures with Char Variables
            //char team;

            //Console.Write("Please enter your team symbol : ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'L' | team == 'l')
            //{
            //    Console.Write("Liverpool");
            //}
            //if (team == 'c' | team == 'C')
            //{
            //    Console.Write("Manchester City");
            //}
            //if (team == 'u' | team == 'U')
            //{
            //    Console.Write("Manchester United");
            //}



            #endregion

            #region Sample Project

            //Console.WriteLine("********   Restaurant   *********");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("1- Main Dishes");
            //Console.WriteLine("2- Soups");
            //Console.WriteLine("3- Pizzas");
            //Console.WriteLine("4- Drinks");
            //Console.WriteLine("5- Sweets");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine();


            //string choose;
            //Console.Write("Select the menu you want to see the details of : ");
            //choose = Console.ReadLine();

            //if(choose == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------   1- Main Dishes --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Cedar-Plank Salmon");
            //    Console.WriteLine("2- Braised Chicken Legs With Grapes and Fennel");
            //    Console.WriteLine("3- Seared Scallops With Brown Butter and Lemon Pan Sauce");
            //    Console.WriteLine("4- Double-Stack Mushroom and Chicken Cheeseburgers");
            //    Console.WriteLine("5- Quick Potato Gnocchi");
            //    Console.WriteLine("------------   1- Main Dishes --------------");

            //    Console.WriteLine();
            //}

            //if (choose == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------   Soups --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Leek & potato soup");
            //    Console.WriteLine("2- Spiced carrot & lentil soup");
            //    Console.WriteLine("3- Tomato soup");
            //    Console.WriteLine("4- Pumpkin soup");
            //    Console.WriteLine("------------   Soups --------------");

            //    Console.WriteLine();
            //}

            //if (choose == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------   Pizzas --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Neapolitan pizza");
            //    Console.WriteLine("2- Chicago pizza");
            //    Console.WriteLine("3- Pizza al taglio");
            //    Console.WriteLine("4- Quad City Pizza");
            //    Console.WriteLine("5- Pizza tonda romana");
            //    Console.WriteLine("6- New Haven pizza");
            //    Console.WriteLine("7- Fried pizza");
            //    Console.WriteLine("------------   Pizzas --------------");

            //    Console.WriteLine();
            //}

            //if (choose == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------   Drinks --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Cider");
            //    Console.WriteLine("2- Tea");
            //    Console.WriteLine("3- Water");
            //    Console.WriteLine("4- Coffee");
            //    Console.WriteLine("5- Milkshake");
            //    Console.WriteLine("6- Smoothie");
            //    Console.WriteLine("7- Mocktails");
            //    Console.WriteLine("8- Diet soda");
            //    Console.WriteLine("------------   Drinks --------------");

            //    Console.WriteLine();
            //}

            //if (choose == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------   Desserts --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Cheesecake");
            //    Console.WriteLine("2- Apple pie");
            //    Console.WriteLine("3- Cobbler");
            //    Console.WriteLine("4- Ice cream");
            //    Console.WriteLine("5- Pudding");
            //    Console.WriteLine("6- Tiramisu");
            //    Console.WriteLine("------------   Desserts --------------");

            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.Write("Please Enter Month : ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch(monthNumber)
            //{
            //    case 1:Console.Write("January"); break;
            //    case 2:Console.Write("Fabruary"); break;
            //    case 3:Console.Write("March"); break;
            //    case 4:Console.Write("April"); break;
            //    case 5:Console.Write("May"); break;
            //    case 6:Console.Write("June"); break;
            //    case 7:Console.Write("July"); break;
            //    case 8:Console.Write("August"); break;
            //    case 9:Console.Write("September"); break;
            //    case 10:Console.Write("October"); break;
            //    case 11:Console.Write("November"); break;
            //    case 12:Console.Write("December"); break;
            //    default: Console.Write("Incorrect data entry");break;
            //}

            #endregion

            #region Switch Case Calculator

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Please Enter Number 1 : ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Please Enter Number 2 : ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the action you want to make : ");
            //symbol = char.Parse(Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Addition : " + result) ;
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Subtraction : " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Multiplication : " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Division : " + result);
            //        break;
            //}

            #endregion

            
            Console.ReadKey();

        }
    }
}
