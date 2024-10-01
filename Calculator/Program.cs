using System;

double num1, num2, result;
char op;

Console.WriteLine("Enter your first number: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter your second number: ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter your operator (+, -, *, /) : ");
op = Convert.ToChar(Console.ReadLine());


switch(op) {
    case '+':
    result = num1+ num2;
    Console.WriteLine($"{num1} + {num2} = {result}");
    break;

    case '-':
    result = num1-num2;
    Console.WriteLine($"{num1} - {num2} = {result}");
    break;

    case '*':
    result = num1*num2;
    Console.WriteLine($"{num1} * {num2} = {result}");
    break;

    case '/':
        if (num2==0) {
            Console.WriteLine("Zero division error ");
        }else {
        result = num1/num2;
        Console.WriteLine($"{num1} / {num2} = {result}");
    }
    break;

    default:
    Console.WriteLine("Invalid operator");
    break;
}


