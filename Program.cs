// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
bool showMenu = true;
while (showMenu)
{
    showMenu = MainMenu();
}

static bool MainMenu()
{
    Console.Clear();
    Console.WriteLine("Select Option to Perform an Operation");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Substract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Modulo");
    Console.WriteLine("0. Exit");

    bool isContinue = true;

    Console.WriteLine("Select an option");

    int input = CaptureInput();

    switch (input)
    {
            case 0:
                isContinue = false;
                break;
            case 1:
                Add();
                break;
            case 2:
                Substract();
                break;
            case 3:
                Multiply();
                break;
            case 4:
                Divide();
                break;
            case 5:
                Modulo();
                break;
        default:
            Console.WriteLine("Invalid option selected, please select between 0 and 5");
                break;
    }
    
    return isContinue;
  
}

static void Add() {
    int a = CaptureInput();
    int b = CaptureInput();
    Console.WriteLine("The sum of {0} and {1} is: {2}", a, b, a+b);
    HookScreen();
}
static void Substract() {
    int a = CaptureInput();
    int b = CaptureInput();
    Console.WriteLine("The subtraction of {0} from {1} is: {2}", b, a, a - b);
    HookScreen();
}
static void Multiply() { 
    int a = CaptureInput();
    int b = CaptureInput();
    Console.WriteLine("The multiplication of {0} and {1} is: {2}", a, b, a * b); 
    HookScreen();
}
static void Divide() {
    int a = CaptureInput();
    int b = CaptureInput();
    if(a != 0 && b != 0)
    {
        Console.WriteLine("The division of {0} and {1} is: {2}", a, b, a / b);
        HookScreen();
    }    
}
static void Modulo() {
    int a = CaptureInput();
    int b = CaptureInput();
    if (a != 0 && b != 0)
    {
        Console.WriteLine("The remainder of {0} divided by {1} is: {2}", a, b, a % b);
    }
    HookScreen();
}
static int CaptureInput()
{
    Console.WriteLine("Input a number");
    if(int.TryParse(Console.ReadLine(), out int input))
    {
        return input;
    }
    else
    {
        Console.WriteLine("Invalid input, Only numbers are allowed");
    }
    return 0;        
}

static void HookScreen()
{
    Console.WriteLine("Press enter key to continue...");
    Console.ReadKey();
}
