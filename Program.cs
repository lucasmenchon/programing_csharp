
Console.WriteLine("Vamos ver os tipos mais comuns");
Console.WriteLine("------------------------------");

Console.WriteLine("bool: representa true ou false");

Console.WriteLine("char: 1 caractere utf 16 de uma string");

Console.WriteLine("byte: nao representa numeros negativos 0 a 255");

Console.WriteLine("int: representa numeros inteiros grandes -2 bilhoes + 2 bi");

Console.WriteLine("long: 64 bits absurdamentes grandes");

Console.WriteLine("float: ponto flutuantes, numeros quebrados");

Console.WriteLine("double: dobro do tamanho de float");

Console.WriteLine("decimal: para moedas, maior precisao");

Console.WriteLine("string: sequencia de caracteres");

string[] names = {"a","b" };
Console.WriteLine(names[0] + names[1]);

for (int contador = 0; contador < 2; contador++)
{
    Console.WriteLine(names[contador]);
}

for (int contador = 0; contador < names.Length; contador++)
{
    Console.WriteLine(names[contador]);
}

if (string.Equals(names[0], "A", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("ok");
}
else
{
    Console.WriteLine("Precisa colocar StringComparison.OrdinalIgnoreCase C# é sensitive case então string a não pode ter valor A maiusculo");
}
Console.ReadKey();

foreach (var name in names)
{
    Console.WriteLine(name);
}