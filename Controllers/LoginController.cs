using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Dashboard.Controllers;

public class LoginController : Controller
{
    // 
    // GET: /Login/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}