using Microsoft.AspNetCore.Mvc;

[Route("api/[User]")]
[ApiController]
public class UserController : ControllerBase
{
   
    [HttpGet]
    public IActionResult GetAllUsers()
    {
        UserDataAccess l_UserDataAccess =  new UserDataAccess();
        var users = l_UserDataAccess.GetAllUsers();
        return Ok(users);
    }
}
