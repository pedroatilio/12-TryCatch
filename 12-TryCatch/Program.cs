//Exemplo de TryCatch com numerador e denominador
//O bloco Try-Catch em c# permite que vc execute um bloco de codigo
//(try) que pode gerar exceções. Se uma exeções ocorrer, ela irá ser
//Tratada no bloco catch

//Exemplo 1 con numeros inteiros
//try
//{
//Console.Write("Digite o numerador");
//int numerador = int.Parse(Console.ReadLine());

//Console.Write("Digite o denominador: ");
//int denominador = int.Parse(Console.ReadLine());

//int resultado = numerador / denominador;
//Console.WriteLine($"O resultado da divisao é: {resultado}");
//}catch (DivideByZeroException)
//{
//  Console.WriteLine("Erro: Não é possivel dividir por zero");
//}
//catch (FormatException)
//{
//  Console.WriteLine("Erro: Por favor, digite números válidos");
//}

//Exemplo 2 com casas decimais utilizando double e convertendo esses valores com TryParse
using System.Globalization;

try
{
    Console.Write("Digite o numerador");
    double numerador;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out numerador ))
    {
        Console.WriteLine("Digite um numero valido");
        Console.Write("Digite o numerador");
    }
    Console.Write("Digite o denominador: ");
    double denominador;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out denominador))
    {
        Console.WriteLine("Digite um numero valido");
        Console.Write("Digite o denominador");
    }

    if (denominador == 0)
    {
        throw new DivideByZeroException();
    }

    double resultado = numerador / denominador;
    Console.WriteLine($"O resultado da divisao é: {resultado}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Erro: Não é possivel dividir por zero");
}
catch (FormatException)
{
    Console.WriteLine("Erro: Por favor, digite números válidos");
}
Console.ReadKey();