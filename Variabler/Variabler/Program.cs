using System;

string name;
string password = "kolakaka";
float factor1; 
float factor2;
float randomNumber;
string operators;

Console.WriteLine("Hej! Vad heter du??");

name = Console.ReadLine();

Console.WriteLine("Hej " + name + ", vad fint namn du har!");

Console.WriteLine();

Console.WriteLine("Jag är bra på matte! jag kan bevisa det, ge mig två tal att multiplicera.");

factor1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Vad ska jag multiplicera " + factor1 + " med?");

factor2 = Int32.Parse(Console.ReadLine());

Console.WriteLine(factor1 + " * " + factor2 + " = " + factor1 * factor2);

Console.WriteLine();

Console.WriteLine("För att låsa upp min fulla potential måste du skriva lösenordet!");

while (true)
{
    if(Console.ReadLine() == password)
    {
        Console.WriteLine("Rätt lösenord!");
        break;
    }
    else
    {
        Console.WriteLine("Fel lösenord, försök igen!");
    }
}

Console.WriteLine();
Console.WriteLine("Du " + name + ", ge mig ett slumpmässigt tal så ska jag berätta lite fakta om det.");

randomNumber = Int32.Parse(Console.ReadLine());

if (randomNumber < 100)
{
    Console.WriteLine("Det talet är mindre än 100!");
}else if(randomNumber > 100){
    Console.WriteLine("Det talet är större än 100!");
}
else
{
    Console.WriteLine("Det talet är = 100");
}

Console.WriteLine("Hälften av talet är " + randomNumber / 2 + "!");
Console.WriteLine("Dubblar man talet får man " + randomNumber * 2 + "!");

Console.WriteLine();
Console.WriteLine("Ge mig ännu ett tal!");

factor1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Nu ge mig en räknesymbol såsom +, -, * eller /");
operators = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Nu vill jag ha ett till tal som jag ska använda i denna ekvationen.");

factor2 = Int32.Parse(Console.ReadLine());


while(true){
    switch (operators)
    {
        case "+":
            Console.WriteLine(factor1 + " + " + factor2 + " = " + (factor1 + factor2));
            break;
        case "-":
            Console.WriteLine(factor1 + " - " + factor2 + " = " + (factor1 - factor2));
            break;
        case "*":
            Console.WriteLine(factor1 + " * " + factor2 + " = " + (factor1 * factor2));
            break;
        case "/":
            Console.WriteLine(factor1 + " / " + factor2 + " = " + (factor1 / factor2));
            break;
        default:
            Console.WriteLine("Det där är inte en matematisk symbol >:(");
            Console.WriteLine("Skriv en annan!");
            operators = Console.ReadLine();
            continue;
           
    }
    break;
}

Console.WriteLine();
Console.WriteLine("GE MIG ETT TILL NUMMER!!!");

int numberSum = 0;

while (Int32.TryParse(Console.ReadLine(), out int number)){
    numberSum += number;
    Console.WriteLine(numberSum);
    Console.WriteLine("MEEEER!!!!");

}

Console.WriteLine("Nu behöver du inte ge mig mer nummer ;)");


