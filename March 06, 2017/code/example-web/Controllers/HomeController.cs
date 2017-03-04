using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string response = PageBase();
            string formattedResponse = string.Format(response, "<h1>A basic Home page that doesn't have much</h1>");
            return Content(formattedResponse, "text/html");
            // return View();
        }

        public IActionResult About()
        {
            string response = PageBase();
            string formattedResponse = string.Format(response, "<h1>It's all about the app</h1>");
            return Content(formattedResponse, "text/html");

            // return View();
        }

        public IActionResult Contact()
        {
            string response = PageBase();
            string formattedResponse = string.Format(response, "<h1>page for contacting</h1>");
            return Content(formattedResponse, "text/html");

            // return View();
        }

        public string PageBase() {
            return @"
            <!DOCTYPE html>
            <html>
            <head>
                <meta charset='utf-8' />
                <meta name='viewport' content='width=device-width, initial-scale=1.0' />
                <title>WebApplication</title>
                <link rel='stylesheet' href='https://ajax.aspnetcdn.com/ajax/bootstrap/3.3.6/css/bootstrap.min.css' />
                <link rel='stylesheet' href='/css/site.min.css' /> <!-- provided by dotnet -->
            </head>
            <body>
                <div class='navbar navbar-inverse navbar-fixed-top'>
                    <div class='container'>
                        <div class='navbar-header'>
                            <button type='button' class='navbar-toggle' data-toggle='collapse' data-target='.navbar-collapse'>
                                <span class='sr-only'>Toggle navigation</span>
                                <span class='icon-bar'></span>
                                <span class='icon-bar'></span>
                                <span class='icon-bar'></span>
                            </button>
                            <a href='/' class='navbar-brand'>Example App</a>
                        </div>
                        <div class='navbar-collapse collapse'>
                            <ul class='nav navbar-nav'>
                                <li><a href='/'>Home</a></li>
                                <li><a href='/Home/About'>About</a></li>
                                <li><a href='/Home/Contact'>Contact</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class='container body-content'>
                    {0} <!-- this is where the body is at -->
                    <hr />
                    <footer>
                        <p>&copy; 2016 - WebApplication</p>
                    </footer>
                </div>
                <script src='https://ajax.aspnetcdn.com/ajax/jquery/jquery-2.2.3.min.js'>
                </script>
                <script src='https://ajax.aspnetcdn.com/ajax/bootstrap/3.3.6/bootstrap.min.js'>
                </script>
            </body>
            </html>
            ";
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
