using System;

namespace Assignment_1Oop
{


    //Q1
    public enum WeekDays
    {
        Monday =0,
        Tuesday =1,
        Wednesday =2,
        Thursday=3,
        Friday=4,
        Saturday=5,
        Sunday=6
    }
    //Q3
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    //Q4
    public enum Permissions
    {
        Read,
        write,
        Delete,
        Execute
    }
    public class Employee
    {
        public int id;
        public String name;
        public int age;
        public Permissions MyPermissions;
    }

    //Q5
    enum Colors
    {
        Red,
        Green,
        Blue
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            #region Q1
            WeekDays day;
            for (int i = 0; i <7; i++)
            {
                day = (WeekDays)i;
                Console.WriteLine(day);

            }
            #endregion

            */

            /*
            #region Q2
            //Q2




            Person[] people = new Person[3];
            people[0] = new Person("Ahmed", 23);
            people[1] = new Person("Mohamed", 55);
            people[2] = new Person("Saleh", 70);

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("Name: " + people[i].Name + ", Age: " + people[i].Age);
            }

            #endregion
            */



            /*
            #region Q3
         
            Console.Write("Enter a season (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();
            

            if (Enum.TryParse<Season>(input, true, out Season Myseason))
            {
                switch (Myseason)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input ,please Enter Correct Data");
            }
            #endregion
            */
            /*
            #region Q4

            Employee emp = new Employee();
            Employee emp2 = new Employee();
            emp.id = 111;
            emp.name = "Ahmed";
            emp.age = 23;
            emp.MyPermissions = (Permissions)0;


            emp2.id = 222;
            emp2.name = "Mohamed";
            emp2.age = 54;
            emp.MyPermissions = Permissions.write;
            Console.WriteLine($"My Name is :{emp.name} , And My Age is : {emp.age} , And My Permissions : {emp.MyPermissions}  ");
            Console.WriteLine($"My Name is :{emp2.name},  And My Age is : {emp2.age},  And My Permissions : {emp2.MyPermissions}  ");

            #endregion
            */

            /*
            #region Q5
            Console.Write("Enter a Color (Red, Green, Blue):");
            string input = Console.ReadLine();


            if (Enum.TryParse<Colors>(input, true, out Colors MYColor))
            {
                switch (MYColor)
                {
                    case Colors.Red:
                    case Colors.Green:
                    case Colors.Blue:
                        Console.WriteLine($"{MYColor} : is a primary color");
                        break;
                }
            }
            else
            {
                Console.WriteLine(" is a Not primary color ..");
            }
            #endregion
            */

            /*
             
             
             */

            /*

            #region Q6
            Console.Write("Please Enter X1 of the first point: ");
            Console.Write("Please Enter Y1 of the first point: ");
            int X1 = int.Parse(Console.ReadLine());
            Console.Write("Please Enter Y1 of the first point: ");
            int Y1 = int.Parse(Console.ReadLine());

            Point point1 = new Point(X1, Y1);
            Console.WriteLine("==================================================");
            Console.Write("Please Enter X2 of the second point: ");
            int X2 = int.Parse(Console.ReadLine());
            Console.Write("Please Enter Y2 of the second point: ");
            int Y2 = int.Parse(Console.ReadLine());

            Point point2 = new Point(X2, Y2);

            int Difference_X1_X2 = point1.X - point2.X;
            int Difference_Y1_Y2 = point1.Y - point2.Y;
            Console.WriteLine("==================================================");
            Console.WriteLine($"The difference in X coordinates is: {Difference_X1_X2}");
            Console.WriteLine($"The difference in Y coordinates is: {Difference_Y1_Y2}");
            Console.WriteLine($"the distance between the Two point is:({Difference_X1_X2},{Difference_Y1_Y2})");



            #endregion

            */

            /*

            #region Q7
            PersonQ7[] people = new PersonQ7[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Please enter the name of person {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Please enter the age of person {i + 1}: ");
                int age = int.Parse(Console.ReadLine());

                people[i] = new PersonQ7(name, age);
            }

            PersonQ7 oldestPerson = people[0];

            for (int i = 1; i < people.Length; i++)
            {
                if (people[i].Age > oldestPerson.Age)
                {
                    oldestPerson = people[i];
                }
            }

            Console.WriteLine($"The oldest person is {oldestPerson.Name} with the age of {oldestPerson.Age}.");



            #endregion

            */


        }
    }
}
