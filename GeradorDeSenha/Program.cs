Console.WriteLine("** GERADOR DE SENHAS **");

int tamaSenha;
while (true)
{
    Console.Write("\nDigite o tamanho da senha (10 a 20 caracteres): ");
    tamaSenha = int.Parse(Console.ReadLine());

    if (tamaSenha < 10 || tamaSenha > 20)
    {
        Console.WriteLine("\nQuantidade de caracteres inválido." +
            "\nTente novamente...");
    }
    else
    {
        break;
    }
    
}

// Variáveis para armazenar as preferências de inclusão
bool incluirMaiusculas = false;
bool incluirMinusculas = false;
bool incluirNumeros = false;
bool incluirEspeciais = false;


Console.Write("\nDeseja incluir letras maiúsculas? (s/n): ");
incluirMaiusculas = Console.ReadLine().ToLower() == "s";

Console.Write("\nDeseja incluir letras minúsculas? (s/n): ");
incluirMinusculas = Console.ReadLine().ToLower() == "s";

Console.Write("\nDeseja incluir números? (s/n): ");
incluirNumeros = Console.ReadLine().ToLower() == "s";

Console.Write("\nDeseja incluir caracteres especiais? (s/n): ");
incluirEspeciais = Console.ReadLine().ToLower() == "s";


if(!incluirMaiusculas && !incluirMinusculas && !incluirNumeros && !incluirEspeciais)
{
    Console.WriteLine("\nPelo menos uma categoria deve ser selecionada. O programa será encerrado.");
    return; // Encerra o programa
}

// Geração de senha

string caracteres = "";
if (incluirMaiusculas) caracteres += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
if (incluirMinusculas) caracteres += "abcdefghijklmnopqrstuvwxyz";
if (incluirNumeros) caracteres += "012345679";
if (incluirEspeciais) caracteres += "!@#$%^&*()";

Random random = new Random();
char[] senha = new char[tamaSenha];
for (int i = 0; i < tamaSenha; i++)
{
    senha[i] = caracteres[random.Next(caracteres.Length)];
}

Console.WriteLine($"\nSua senha gerada é: {new string(senha)}");