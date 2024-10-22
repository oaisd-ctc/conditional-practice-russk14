
using System.Reflection.PortableExecutable;

public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
        //Testing CheckForPositiveNegativeZero
        CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
        CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"

        //Testing FindMinimum
        FindMinimum(1, 2, 3);
        FindMinimum(2, 1, 3);
        FindMinimum(3, 2, 1);
        FindMinimum(3, 3, 3);

        //Testing FindMaximum
        FindMaximum(1, 2, 3);
        FindMaximum(2, 1, 3);
        FindMaximum(3, 2, 1);
        FindMaximum(1, 1, 1);

        //Testing IsDivisibleBy5
        IsDivisibleBy5(5);
        IsDivisibleBy5(6);

        //Testing CheckEvenOrOdd
        CheckEvenOrOdd(2);
        CheckEvenOrOdd(3);

        //Testing CheckVowelOrConsonant
        CheckVowelOrConsonant('e');
        CheckVowelOrConsonant('E');
        CheckVowelOrConsonant('s');
        CheckVowelOrConsonant('S');

        //Testing DisplayDayOfWeek
        DisplayDayOfWeek(0);
        DisplayDayOfWeek(3);
        DisplayDayOfWeek(6);



        // DisplayDayOfWeek(0); // This should output: "Thursday"

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:

    public static void CheckForPositiveNegativeZero(int number){
        if (number < 0){
            Console.WriteLine("Your number is negative");
        } else if (number > 0){
            Console.WriteLine("Your number is positive");
        } else if (number == 0){
            Console.WriteLine("Your number is zero");
        }
    }

    public static void FindMinimum(int num1, int num2, int num3){
        if (num1 < num2 && num1 < num3){
            Console.WriteLine("The minimum value is " + num1);
        } else if (num2 < num1 && num2 < num3){
            Console.WriteLine("The minimum value is " + num2);
        } else if (num3 < num1 && num3 < num2){
            Console.WriteLine("The minimum value is " + num3);
        } 
        else {
            Console.WriteLine("All the numbers are equivalent to " + num1 + "!");
        }
    }

    public static void FindMaximum(int num1, int num2, int num3){
        if (num1 > num2 && num1 > num3){
            Console.WriteLine("The maximum value is " + num1);
        } else if (num2 > num1 && num2 > num3){
            Console.WriteLine("The maximum value is " + num2);
        } else if (num3 > num1 && num3 > num2){
            Console.WriteLine("The maximum value is " + num3);
        }
        else {
            Console.WriteLine("All the numbers are equivalent to " + num1 + "!");
        }
    }

    public static void IsDivisibleBy5(int number){
        if (number % 5 == 0){
            Console.WriteLine($"{number} is divisible by 5.");
        } else {
            Console.WriteLine($"{number} is not divisible by 5.");
        }
    }

    public static void CheckEvenOrOdd(int number){
        if (number % 2 == 1){
            Console.WriteLine($"{number} is an odd number.");
        } else if (number % 2 == 0){
            Console.WriteLine($"{number} is an even number.");
        }
    }

    public static void CheckVowelOrConsonant(char letter){
        switch (letter){
            case 'a':
            case 'A': // It is possible to add another line and use two cases like this, told courtesy of ChatGPT 4o mini.
                Console.WriteLine("a is a vowel.");
                break;
            case 'e':
            case 'E':
                Console.WriteLine("e is a vowel.");
                break;
            case 'i':
            case 'I':
                Console.WriteLine("i is a vowel.");
                break;
            case 'o':
            case 'O':
                Console.WriteLine("o is a vowel.");
                break;
            case 'u':
            case 'U':
                Console.WriteLine("u is a vowel.");
                break;
            case 'y':
            case 'Y':
                Console.WriteLine("y might be a vowel, or not.");
                break;
            default:
                Console.WriteLine($"{letter} is a consonant");
                break;
        }
    }

    public static void DisplayDayOfWeek(int dayCode){
        switch(dayCode){
            case 0:
                Console.WriteLine("Sunday");
                break;
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
        }
    }
}
