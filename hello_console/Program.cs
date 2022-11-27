Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "саша"){
 Console.Write("Ура, это Саша!");
} else {
 Console.Write("Привет, ");
 Console.Write(username);
}