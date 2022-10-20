// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("-----------------------");
Console.WriteLine("[1] - saudação");
Console.WriteLine("-----------------------");

Console.Write("escolha uma opção: ");
int opc = Convert.ToInt32(Console.ReadLine());

if(opc == 1)
{
    Console.WriteLine("qual e o nome?");
    string nome = Console.ReadLine();

    Console.WriteLine("ola" + nome + "!");
}