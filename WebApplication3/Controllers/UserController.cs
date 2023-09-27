using Microsoft.AspNetCore.Mvc;
using WebApplication3.Model;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
   
    [HttpGet]
    public IActionResult Fnc_GetAllUsers()
    {
        UserDataAccess l_UserDataAccess =  new UserDataAccess();
        List<ModUser> l_ListUsers = l_UserDataAccess.GetAllUsers();
        return Ok(l_ListUsers);
    }
}
