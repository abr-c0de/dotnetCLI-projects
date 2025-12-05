

Console.WriteLine("Enter first number :");

double FirstNum;

while (!double.TryParse(Console.ReadLine(), out FirstNum)) 
{
    Console.WriteLine("Invalid Input Try again");
}

Console.WriteLine("Enter second number :");

double SecondNum;

while (!double.TryParse(Console.ReadLine(), out SecondNum))
{
    Console.WriteLine("Invalid Input Try again");
}

Console.WriteLine(" \n Add -> + \n Sub -> - \n Div -> / \n Mul -> *");
Console.WriteLine("\n Choose the Operation :");

string fun = Console.ReadLine();

double result = 0.0;

switch (fun)
{
    case "+": result = FirstNum + SecondNum; break;
    case "-": result = FirstNum - SecondNum; break;
    case "*": result = FirstNum * SecondNum; break;
    case "/": result = FirstNum / SecondNum; break;
    default: Console.WriteLine("Invalid Operator");
    break;

}

Console.WriteLine($"The result is {result}");