public class UserServices 
{
    private static List<User> Users = new List<User>();
    public static string AddUser(string name, int age)
    {
        User user = new User(name, age);
        Users.Add(user);
        return "Пользователь добавлен";
    }
    public static string DeleteUser(string name)
    {
        User user = Users.FirstOrDefault(u => u.GetName().Equals(name));
        if (user == null)
        {
            return "Пользователя не существует";
        }
        Users.Remove(user);
        return "Пользователь удален из списка";
    }
    public static List<User> GetUsers()
    {
        return Users;
    }
    public static string[] SayHello()
    {
        int count = Users.Count;
        string[] result = new string[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = Users[i].SayHello();
        }
        return result;
    }
}