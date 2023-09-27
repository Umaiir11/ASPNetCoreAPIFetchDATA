using Microsoft.AspNetCore.Mvc;
using WebApplication3.Model;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
   
    [HttpGet]
    public IActionResult GetAllUsers()
    {
        try
        {
            UserDataAccess l_UserDataAccess = new UserDataAccess();
            List<ModUser> l_ListUsers = l_UserDataAccess.Fnc_GetAllUsers();
            return Ok(l_ListUsers);
        }
        catch (Exception e)
        {

            return BadRequest("panga ho gya bhai");
        }
    }
}
