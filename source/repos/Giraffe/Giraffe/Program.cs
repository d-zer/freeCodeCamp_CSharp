using System;

namespace Giraffe
{
    class Program // code container
    {
        static void Main(string[] args)
        {
            /*
            // 1
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");

            Console.ReadLine();

            // 2
            string characterName = "Tom"; // kolayca degistirilebilir
            int characterAge;
            characterAge = 25; // depoda kullanmak istedigin bilgi
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike"; // degisken güncellenebilir
            Console.WriteLine("He really liked the name " + characterName);
            
            // 3
            string phrase = "Giraffe Academy";
            char grade = 'A'; // bir tane tek karakter kullanılabilir
            int age = -30;
            // float, double, decimal -> money // ondalıklı sayıları temsil eden veri tipleri, kesinlik sırasi
            double gpa = 3.3;
            bool isMale = false;

            Console.WriteLine(30); // degiskene atanmadan kullanilan degerler -> constant
            
            // 4
            string phrase = "Giraffe Academy" + " is cool";
            string phrase1 = "Giraffe Academy";
            Console.WriteLine(phrase1.Length);
            Console.WriteLine(phrase1.Contains("Academies")); // metoda erisim -> .ToUpper()
            Console.WriteLine(phrase1[2]);
            Console.WriteLine(phrase1.IndexOf("Academy")); // A nerede, index olarak
            Console.WriteLine(phrase1.IndexOf('f')); // ilk f nin indexi
            Console.WriteLine(phrase1.IndexOf('z')); // -1 -> karakter yok
            Console.WriteLine(phrase1.Substring(8, 3)); // Aca -> (baslangıc index, alınacak karakter sayisi)
            
            // 5
            Console.WriteLine(5.0 + 8.1); // 13.1
            Console.WriteLine(5 + 8.1); // 13.1
            Console.WriteLine(5 / 2); // 2
            Console.WriteLine(5 / 2.0); // 2.5

            int num = 6;
            num++; // 7
            num--; // 6
            Console.WriteLine(num);
            Console.WriteLine(Math.Pow(3.8, 2)); // 14.44
            Console.WriteLine(Math.Sqrt(36)); // 6
            Console.WriteLine(Math.Max(2, 90)); // 90
            Console.WriteLine(Math.Min(2, 90)); // 2
            Console.WriteLine(Math.Round(4.3)); // 4
            Console.WriteLine(Math.Round(4.6)); // 5
            
            // 6
            // Console.ReadLine(); // kullanici metin girer
            Console.Write("Enter your name: "); //yeni satıra gecmez
            string name = Console.ReadLine();
           
            Console.Write("Enter your age: "); //yeni satıra gecmez
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);
            
            // 7
            int num = Convert.ToInt32("45"); // icinde sayi olmalı "asd" deseydik hata alırdık
            Console.WriteLine(num + 6);

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); // sadece tamsayı girilebilir

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.Write("Enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine()); // ondalıklı sayı girilebilir

            Console.Write("Enter another number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num3 + num4);
            
            // 8
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);
            
            // 9
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
            string[] friends = new string[10]; // 10 degeri olacak olan bos dizi
            friends[0] = "Jim";
            friends[1] = "Kelly";

            luckyNumbers[1] = 900; // eleman degeri degistirme

            Console.WriteLine(luckyNumbers[0]); // ilk eleman
            
            // 10
            SayHi("Dilan", 23);
            SayHi("John", 56);
            SayHi("Tom", 35); // tekrar kullanilabilir -> metot

            Console.ReadLine(); 
            
            // 11
            Console.WriteLine(cube(5));
            Console.ReadLine();

            int cubeNumber = cube(3);
            Console.WriteLine(cubeNumber);
            
            // 12
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } 
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            } 
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not male but you are tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");
            }
            
            // 13
            Console.WriteLine(GetMax(20, 10, 40));

            Console.ReadLine();
            
            // 14
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            } else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            } else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            } else
            {
                Console.WriteLine("Invalid Operator");
            }
            
            // 15
            Console.WriteLine(GetDay(0));
            Console.ReadLine();
            
            // 16
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            int index2 = 6;
            do
            {
                Console.WriteLine(index2);
                index2++;
            } while (index2 <= 5);
            
            // 17
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessLimit > guessCount)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } 
                else
                {
                    outOfGuesses = true; // boolean flag
                }
            }

            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.Write("You Win!");
            }
            
            // 18
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int[] luckyNumbers = { 0, 1, 2, 3, 4, 5 };
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
            
            // 19
            Console.WriteLine(GetPow(3, 2));
            Console.ReadLine();
            
            // 20
            int[,] numberGrid = {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };
            int[,] myArray = new int[2, 3];

            Console.WriteLine(numberGrid[1, 1]);
            
            // 21
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Okay");
            }
            
            // 22 - class & object, constructor
            Book book1 = new Book("Harry Potter", "JK Rowling", 400); // Book object, constructor
            // book1.title = "Harry Potter";
            // book1.author = "JK Rowling";
            // book1.pages = 400;

            Book book2 = new Book("Lord Of the Rings", "Tolkein", 700); // object, constructor
            // book2.title = "Lord Of the Rings";
            // book2.author = "Tolkein";
            // book2.pages = 700;

            book2.title = "The Hobbit"; // guncellenme

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.author);
            
            // 23 -> object methods
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            
            // 24 -> getter, setter
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord Of the Rings", "Tolkein", 700);
            // 25 -> static class attributes
            Song holiday = new Song("Holiday", "Green Day", 200); // object
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);

            Console.WriteLine(kashmir.title);
            Console.WriteLine(kashmir.getSongCount());
            
            // 26 -> static class

            Console.WriteLine(Math.Sqrt(144)); // object olmadan metoda erisim
            UsefulTools.SayHi("dilan");
            */
            // 27 -> Inheritance
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish(); // virtual ile tanımlanan metod

            ItalianChef italianchef = new ItalianChef();
            italianchef.MakeChicken();
            italianchef.MakePasta();
            italianchef.MakeSpecialDish(); // override ile tanımlanan metod



        }
        /*
        // 10
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
        
        // 11
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
        
        // 13
        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 &&  num1 >= num3)
            {
                result = num1;
            } 
            else if (num2 >= num3 && num2 >= num1)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
        
        // 15
        static string GetDay(int dayNum)
        {
            string dayName;
            
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break ;
                case 1:
                    dayName = "Monday";
                    break ;
                case 2:
                    dayName = "Tuesday";
                    break ;
                case 3:
                    dayName = "Wednesday";
                    break ;
                case 4:
                    dayName = "Thursday";
                    break ;
                case 5:
                    dayName = "Friday";
                    break ;
                case 6:
                    dayName = "Saturday";
                    break ;
                default: // yukardakiler olmazsa
                    dayName = "Invalid Day Number"; // error mesajı
                    break ;
            }
            return dayName;
        }
        
        // 19
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            
            for (int i = 0; i < powNum; i++)
            { 
                result *= baseNum;
            }

            return result;
        }
        */

        }
    }
