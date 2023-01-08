// See https://aka.ms/new-console-template for more information
using Membership;
Console.WriteLine("Hello, World!");

Console.WriteLine("**** Welcome *****");

Console.WriteLine("Enter email address");
string email=Console.ReadLine();

Console.WriteLine("Enter Password address");
string pass=Console.ReadLine();

//AuthManager.Validate(email,pass)
Console.WriteLine(AuthManager.Validate(email,pass));
