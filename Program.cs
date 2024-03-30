using System;
using System.Runtime.InteropServices;


inicio:
Menu();


Console.WriteLine("Qual oprecao deseja fazer hoje? \n");
Console.WriteLine("1 - para adicao \n");
Console.WriteLine("2 - para subtracao \n");
Console.WriteLine("3 - para multiplicacao \n");
Console.WriteLine("4 - para Divisao \n");

int resp = int.Parse(Console.ReadLine());

Console.WriteLine("digite o pirmeiro numero \n");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("digite o segundo numero");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Primeiro numero {num1}, segundo {num2}");

Console.WriteLine("digite s - prosseguir e n - para voltar ao menu.");
string pergunta = Convert.ToString(Console.ReadLine());
int resultado; 

if(pergunta == "s" || pergunta == "S")
{


switch (resp)
{
    case 1:
        Console.Clear();
        Thread.Sleep(2000); 
        resultado =  num1 + num2;
        Console.WriteLine($"O resultado da soma entre {num1} e {num2} e: ");
        Resultado();
        break;
    case 2:
        Console.Clear();
        Thread.Sleep(2000);
        resultado =  num1 - num2;
        Console.WriteLine($"O resultado da subtracao entre {num1} e {num2} e: ");
        Resultado();

        break;
    case 3:
        Console.Clear();
        Thread.Sleep(2000);
        resultado =  num1 * num2;
        Console.WriteLine($"O resultado da muktiplicacao entre {num1} e {num2} e: ");
        Resultado();

        break;
    case 4:
        Console.Clear();
        Thread.Sleep(2000);
        resultado =  num1 / num2;
        Console.WriteLine($"O resultado da divisao entre {num1} e {num2} e: ");
        Resultado();

        break;
    default:
        throw new Exception("Voce terminou o programa");
        
}
Thread.Sleep(3000); 
Console.Clear();
Thread.Sleep(1000);    
goto inicio;

}

else{
    Console.Clear();
    throw new Exception("Fim do programa");
}

    void Menu()
    {
        Console.WriteLine("Bem vido a sua Simples Calculadora\n\n");
    }

    void Resultado()
    {
    Thread.Sleep(200);
    Console.Clear();
    Console.WriteLine($"O resultado do seu calculo foi {resultado}");
    }