using Microsoft.AspNetCore.Mvc;
using DotnetSocialMedia.Models;

namespace DotnetSocialMedia.Controllers;

public class MainController : Controller
{

    public IActionResult homepage()
    {
        return View();
    }

    public IActionResult CreatePost()
    {
        return View();
    }

    public IActionResult MyPosts()
    {
        return View();
    }

    public IActionResult Profile(){

return View();

}

public IActionResult EditPost(Post post){

return View(post);

}

}