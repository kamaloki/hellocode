Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Камила"){
    Console.WriteLine("Урааа, это же КАМИЛА!");
}
else{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}