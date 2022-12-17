public class Userclass
{
    public string Username = "Anushervon";
    public string Password = "paskod";
    public void Introduce()
    {
        System.Console.WriteLine($"I am {Username}");
    }
    public void Login(string username, string password)
    {
        if (Username==username && Password==password)
        {
            System.Console.WriteLine("Welcome");
        }
        else
        {
            System.Console.WriteLine("Wrong password");
        }
    }
}