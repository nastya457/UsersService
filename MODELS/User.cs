public class User
{
    private string Name;
    private int Age;
    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public string GetName()
    {
        return Name;
    }
    
    public string SayHello()
    {
        return $"Привет, меня зовут {Name}, мне {Age} лет";
    }
}