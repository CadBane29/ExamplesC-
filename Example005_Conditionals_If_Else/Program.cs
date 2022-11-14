Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine()!;

if(username.ToLower() == "анна") // для того чтобы ToLower работала, имя нужно записать с маленькой буквы
{
    Console.Write("Как я по вам скучала, Анна!");
}
else
{
    Console.Write("Привет, " + username);
}