namespace W3Resources;

class DataTypeExercises
{
    /// <summary>
    /// takes three letters as input and display them in reverse order
    /// </summary>
    public void Exercise1()
    {
        List<Char> characters = new List<char>();
        for (int i = 0; i < 3; i++)
        {
            Console.Out.Write("Enter letter:");
            Char letter = Convert.ToChar(Console.ReadLine());
            characters.Add(letter);
        }

        characters.Reverse();
        foreach (Char character in characters)
        {
            Console.Write(character + " ");
        }
    }

    /// <summary>
    /// takes a number and a width also a number, as input and then displays a triangle of that width, using that number
    /// </summary>
    /// <param name="num">int used to build the triangle</param>
    /// <param name="width">int used for the width of the triangle</param>
    public void Exercise2(int num, int width)
    {
        for (int i = width; i > 0; i--)
        {
            for (int j = i; j > 0; j--)
            {
                if (j == 1)
                {
                    Console.WriteLine(num);
                }
                else
                {
                    Console.Write(num);
                }
            }
        }
    }

    /// <summary>
    /// userid and password as input (type string). After 3 wrong attempts, user will be rejected
    /// </summary>
    public void Exercise3()
    {
        String username = "logisticsmanager@test.nl";
        String savedPassword = "PlainTextPassword";

        Console.Write("Enter username: ");
        String user = Console.ReadLine();
        Console.Write("Enter password: ");
        String pass = Utilities.getpassword();

        for (int i = 2; i > 0; i--)
        {
            if (user == username && pass == savedPassword)
            {
                Console.WriteLine("Congratulations, you have successfully logged in");
                break;
            }
            else
            {
                Console.WriteLine($"sorry combination you have entered is incorrect, you have {i} attempts left");
                Console.Write("Enter username: ");
                user = Console.ReadLine();
                Console.Write("Enter password: ");
                pass = Utilities.getpassword();
            }
        }

        Console.WriteLine(
            "You did not enter a valid email password combination, the authorities have been notified and are closing in on your position");
        Environment.Exit(0);
    }


    /// <summary>
    /// program that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation
    /// </summary>
    public void Exercise4()
    {
        Console.Out.Write("Input first number: ");
        Int16 num1 = Convert.ToInt16(Console.ReadLine());
        Console.Out.Write("Input operator: ");
        Char operatorUsed = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.Out.Write("Input second number: ");
        Int16 num2 = Convert.ToInt16(Console.ReadLine());

        switch (operatorUsed)
        {
            case '+':
                Console.WriteLine($"{num1} {operatorUsed} {num2} = {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"{num1} {operatorUsed} {num2} = {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"{num1} {operatorUsed} {num2} = {num1 * num2}");
                break;
            case '/':
                Console.WriteLine($"{num1} {operatorUsed} {num2} = {num1 / num2}");
                break;
        }
    }

    /// <summary>
    /// takes the radius of a circle as input and calculate the perimeter and area of the circle
    /// </summary>
    public void Exercise5()
    {
        Console.WriteLine("Input the radius of the circle : ");
        Int16 radius = Convert.ToInt16(Console.ReadLine());

        double area = Math.PI * (radius * radius);
        double perimeter = 2 * (radius * Math.PI);

        Console.WriteLine($"Perimeter of Circle : {String.Format("{0:0.00}", area)}");
        Console.WriteLine($"Perimeter of Circle : {String.Format("{0:0.00}", perimeter)}");
    }

    /// <summary>
    /// display certain values of the function x = y2 + 2y + 1 (using integer numbers for y , ranging from -5 to +5)
    /// </summary>
    public void Exercise6()
    {
        Console.Out.WriteLine("x = y² + 2y + 1");
        for (int i = -5; i <= 5; i++)
        {
            double output = (i * i) + (2 * i) + 1;
            Console.WriteLine($"{output} = {i}² +2({i}) + 1");
        }
    }

    /// <summary>
    /// takes distance and time as input and displays the speed in kilometres per hour and miles per hour.
    /// </summary>
    public void Exercise7()
    {
        //input
        Console.Out.Write("Input distance(metres): ");
        double distance = Convert.ToDouble(Console.ReadLine());
        Console.Out.Write("Input timeSec(hours): ");
        double hours = Convert.ToDouble(Console.ReadLine());
        Console.Out.Write("Input timeSec(minutes): ");
        double minutes = Convert.ToDouble(Console.ReadLine());
        Console.Out.Write("Input timeSec(seconds):  ");
        double seconds = Convert.ToDouble(Console.ReadLine());


        double totalSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;
        double mSec = distance / totalSeconds;
        double kmH = mSec * 3.6;
        double mlH = kmH / 1.609344;

        //output
        Console.WriteLine($"Your speed in metres/sec is {mSec}");
        Console.WriteLine($"Your speed in km/h is {kmH}");
        Console.WriteLine($"Your speed in miles/h is {mlH}");
    }

    /// <summary>
    /// takes the radius of a sphere as input and calculate and display the surface and volume of the sphere.
    /// </summary>
    public void Exercise8()
    {
        //volume = (4/3)(PI*(r*r*r) and surfaceArea =4*PI*(r*r)
        Console.Write("Radius: ");
        Int32 radius = Convert.ToInt32(Console.ReadLine());

        double surfaceArea = 4 * Math.PI * (radius * radius);
        double volume = (4f / 3f) * Math.PI * (radius * radius * radius);

        Console.WriteLine(surfaceArea);
        Console.WriteLine(volume);
    }

    /// <summary>
    /// takes a character as input and check the input (lowercase) is a vowel, a digit, or any other symbol
    /// </summary>
    public void Exercise9()
    {
        Console.Out.WriteLine("Input a symbol: ");
        Char symbol = Console.ReadKey().KeyChar;
        Console.WriteLine();
        int asciiKey = (int) symbol;
        if (asciiKey >= 97 && asciiKey <= 122)
        {
            if (asciiKey == 97 || asciiKey == 101 || asciiKey == 105 || asciiKey == 111 || asciiKey == 117)
            {
                Console.Out.WriteLine("its a lowercase vowel");
            }
            else
            {
                Console.Out.WriteLine("its a lowercase consonant");
            }
        }
        else if (asciiKey >= 65 && asciiKey <= 90)
        {
            if (asciiKey == 65 || asciiKey == 69 || asciiKey == 73 || asciiKey == 79 || asciiKey == 85)
            {
                Console.Out.WriteLine("its a uppercase vowel");
            }
            else
            {
                Console.Out.WriteLine("its a uppercase consonant");
            }
        }
        else if (asciiKey >= 48 && asciiKey <= 57)
        {
            Console.Out.WriteLine("its a digit");
        }
    }

    /// <summary>
    /// takes two numbers as input and returns true or false when both numbers are even or odd.
    /// </summary>
    public Boolean Exercise10()
    {
        Console.WriteLine("enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter a number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 % 2 == 0 && num2 % 2 == 0)
        {
            return true;
        }
        else if (num1 % 2 != 0 && num2 % 2 != 0)
        {
            return true;
        }

        return false;
    }
/// <summary>
/// takes a decimal number as input and displays its equivalent in binary form.
/// </summary>
    public void Exercise11()
    {
        Console.WriteLine("enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
    }

    public static void Main()
    {
        DataTypeExercises dataTypeExercises = new DataTypeExercises();
        dataTypeExercises.Exercise11();
    }
}