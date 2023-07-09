Console.Write("Введите имя ");
string username = Console.ReadLine();

if(username.ToLower() == "оля")
{
    Console.WriteLine("Люблю тебя :) ");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}