// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
var numbers = "0123456789".ToCharArray();
var symbols = "!#$%&()*+".ToCharArray();

Console.WriteLine("Welcome to the C# Password Generator!");
Console.Write("How many letters would you like in your password?\n");
int nrLetters = Convert.ToInt32(Console.ReadLine());
Console.Write("How many symbols would you like?\n");
int nrSymbols = Convert.ToInt32(Console.ReadLine());
Console.Write("How many numbers would you like?\n");
int nrNumbers = Convert.ToInt32(Console.ReadLine());

var passwordList = new List<char>();
Random rand = new Random();

for (int i = 0; i < nrLetters; i++)
{
    passwordList.Add(letters[rand.Next(letters.Length)]);
}

for (int i = 0; i < nrSymbols; i++)
{
    passwordList.Add(symbols[rand.Next(symbols.Length)]);
}

for (int i = 0; i < nrNumbers; i++)
{
    passwordList.Add(numbers[rand.Next(numbers.Length)]);
}

var shuffledPassword = passwordList.OrderBy(x => rand.Next()).ToArray();
string password = new string(shuffledPassword);

Console.WriteLine($"Your password is: {password}");
