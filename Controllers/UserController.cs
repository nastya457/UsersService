using Microsoft.AspNetCore.Mvc;

public class UserController : ControllerBase 
{
    [HttpGet("users")]
    public List<User> GetAll()
    {
        return UserServices.GetUsers();
    }
    [HttpPost("users/add")]
    public string Adduser(string name, int age)
    {
        return UserServices.AddUser(name, age);
    }
    [HttpDelete ("users/delete")]
    public string DeleteUser(string name)
    {
        return UserServices.DeleteUser(name);
    }
    [HttpGet ("users/hello")]
    public string[] SayHello()
    {
        return UserServices.SayHello();
    }
}