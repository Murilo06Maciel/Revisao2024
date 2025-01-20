using System.IO;

	using (StreamWriter escrever = new StreamWriter("bkp.txt"))
	{
char[] Letras_Maiusculas = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ç'};
char[] Letras_Minusculas = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'ç'};
char[] NumerosArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
char[] SimbolosArray = { '.', ',', ';', ':', '!', '@', '#', '$', '%', '&', '*', '(', ')', '-', '_', '+', '=' };

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n===============================================");
escrever.WriteLine("\n===============================================");
Console.WriteLine("   Gerador de Senha - Personalize a sua senha  ");
escrever.WriteLine("   Gerador de Senha - Personalize a sua senha  ");
Console.WriteLine("===============================================");
escrever.WriteLine("===============================================");
Console.ResetColor();

int quantidade;
bool incluirNumeros = false, incluirLetras = false, incluirSimbolos = false;
bool opcaoValida = false;

do
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\nDefina a quantidade de caracteres que irão conter na senha:");
    escrever.WriteLine("\nDefina a quantidade de caracteres que irão conter na senha:");
    Console.ResetColor();
    if (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nPor favor, insira um número válido.");
        Console.ResetColor();
    }
} while (quantidade <= 0);

do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("===============================================");
    Console.WriteLine("       Selecione os tipos de caracteres:      ");
    Console.WriteLine("===============================================");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Deseja incluir números?");
    Console.WriteLine("S - Sim | N - Não");
    if (Console.ReadLine().ToUpper() == "S")
    {
        incluirNumeros = true;
    }

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\nDeseja incluir letras (maiúsculas e minúsculas)?");
    Console.WriteLine("S - Sim | N - Não");
    if (Console.ReadLine().ToUpper() == "S")
    {
        incluirLetras = true;
    }
    
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\nDeseja incluir símbolos?");
    Console.WriteLine("S - Sim | N - Não");
    if (Console.ReadLine().ToUpper() == "S")
    {
        incluirSimbolos = true;
    }

    if (incluirNumeros || incluirLetras || incluirSimbolos)
    {
        opcaoValida = true;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nVocê precisa selecionar pelo menos uma opção (números, letras ou símbolos).");
        Console.ResetColor();
        incluirNumeros = false;
        incluirLetras = false;
        incluirSimbolos = false;
    }

} while (!opcaoValida);

string caracteresDisponiveis = "";
if (incluirNumeros) caracteresDisponiveis += new string(NumerosArray);
if (incluirLetras) caracteresDisponiveis += new string(Letras_Maiusculas) + new string(Letras_Minusculas);
if (incluirSimbolos) caracteresDisponiveis += new string(SimbolosArray);

Random rand = new Random();
string senha = "";
for (int i = 0; i < quantidade; i++)
{
    int indiceAleatorio = rand.Next(caracteresDisponiveis.Length);
    senha += caracteresDisponiveis[indiceAleatorio];
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("===============================================");
Console.WriteLine("            Senha Gerada com Sucesso!       ");
Console.WriteLine("===============================================");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nSua senha gerada é: ");
Console.WriteLine($"         {senha}");
Console.ResetColor();
    }