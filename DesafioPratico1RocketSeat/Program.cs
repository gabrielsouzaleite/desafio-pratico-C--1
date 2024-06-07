using System.Globalization;

Console.Write("Digite seu primeiro nome:");
string firstName = Console.ReadLine();
Console.WriteLine($"Olá, {firstName}! Seja muito bem-vindo!");
Console.Write("Agora digite o seu sobrenome:");
string lastName = Console.ReadLine();
Console.WriteLine($"Seu nome completo é: {firstName} {lastName}");


double number1 = 2;
double number2 = 4;

Console.WriteLine($"A soma dos numeros é = {number1 + number2}");
Console.WriteLine($"A subtração dos numeros é = {number1 - number2}");
Console.WriteLine($"A multiplicação dos numeros é = {number1 * number2}");
Console.WriteLine($"A divisão dos numeros é = {number1 / number2}");

Console.Write("Digite qualquer palavra:");
string phrase = Console.ReadLine();
int phraseLenght = phrase.Length;
Console.WriteLine($"A frase que você digitou tem {phraseLenght} caracteres");

Console.Write("Digite a placa do seu veículo:");
string vehicleLicensePlate = Console.ReadLine();
int vehicleLicensePlateLenght = vehicleLicensePlate.Length;

if (vehicleLicensePlateLenght > 7)
{
    Console.WriteLine("Você mandou uma placa com caracteres a mais!");
}

string firstThreeDigits = vehicleLicensePlate.Substring(0, 3);
string lastDigits = vehicleLicensePlate.Substring(3, 4);
bool isLetter = true;
bool isDigit = true;

foreach (char c in firstThreeDigits)
{
    if (!char.IsLetter(c))
    {
        isLetter = false;
        break;
    }
}

foreach (char c in lastDigits)
{
    if (!char.IsDigit(c))
    {
        isDigit = false;
        break;
    }
}

if (isLetter && isDigit)
{
    Console.WriteLine("Verdadeiro");
}
else
{
    Console.WriteLine("Falso");
}


DateTime currentDate = DateTime.Now;

Console.WriteLine("Escolha um formato para exibir a data atual:");
Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
Console.WriteLine("2 - Apenas a data no formato \"01/03/2024\"");
Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
Console.WriteLine("4 - A data com o mês por extenso");
Console.Write("Digite o número da opção desejada: ");

string option = Console.ReadLine();

switch (option)
{
    case "1":
        Console.WriteLine("Formato completo:");
        Console.WriteLine(currentDate.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("pt-BR")));
        break;
    case "2":
        Console.WriteLine("Apenas a data no formato \"01/03/2024\"");
        Console.WriteLine(currentDate.ToString("dd/MM/yyyy"));
        break;
    case "3":
        Console.WriteLine("Apenas a hora no formato de 24 horas");
        Console.WriteLine(currentDate.ToString("HH:mm:ss"));
        break;
    case "4":
        Console.WriteLine("A data com o mês por extenso");
        Console.WriteLine(currentDate.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}