/*
byte idade;
string nome;
Console.Write("Digite seu nome: ");
nome = Console.ReadLine();
Console.Write("Digite sua idade: ");
idade = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Olá " + nome + ". A idade informada foi {0}", idade);// idade = 20
idade *= 2; // idade = idade * 2 
Console.WriteLine($"A nova idade é {idade++}"); //40
Console.WriteLine($"A nova idade é {++idade}"); //42

//altere o programa para que solicite ao usuário informar o seu salário e ao final informe o desconto de IRPF de acordo com o salário informado. Utilize a tabela oficial de descontos de IRPF do Brasil.

try
{
    decimal salario, irpfDevido;
    Console.WriteLine("Informe o salário: ");
    salario = decimal.Parse(Console.ReadLine());


    if (salario <= 2428.8m)
        irpfDevido = 0;
    else if (salario <= 2826.65m)
        irpfDevido = salario * 0.075m - 182.16m;
    else if (salario <= 3751.05m)
        irpfDevido = salario * 0.15m - 394.16m;
    else if (salario <= 4664.68m)
        irpfDevido = salario * 0.225m - 676.49m;
    else
        irpfDevido = salario * 0.275m - 908.73m;

    Console.WriteLine($"Para o salario {salario:C2} o IRPF a ser pago é {irpfDevido:C2}");

}
catch (FormatException)
{
    Console.WriteLine("Digite apenas valores numéricos");
}
catch (Exception e)
{
    Console.WriteLine("Ocorreu um erro. Entre em contato  com o suporte técnico.");
    Console.WriteLine(e.ToString());
}
*/

using ConceitosBasicos.uteis;

SomaDoisNumeros somaDoisNumeros;
somaDoisNumeros =  new SomaDoisNumeros();
somaDoisNumeros.Somar(20, 22);