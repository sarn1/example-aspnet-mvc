# example-aspnet-mvc
https://teamtreehouse.com/library/aspnet-mvc-basics

### Setup ###
- ASP.NET Web Application for Visual C#
- Leave	**Create directory for solution** unchecked.
- Create new **Git repository** checked.
- Select Empty template.
- Select **MVC** for **Add folders and core references for**.

### Adding a Controller ###
- Right click `Controllers` folder in the project > Add > Class
- Filename for a controller class must end in **Controller** so Visual Studio can distinguish controllers from regular classes.
- Our controller must inherit from the MVC controller base class and include using `System.Web.Mvc`
- Controller must be public so its accessible.
- See Controller/ComicBooksController.cs

### Adding Action Method ###
- Methods need to be public so its accessible.
- http://localhost:62466/ComicBooks/Detail via **ComicBooksController.cs**
- http://localhost:62466/Sarn/Test via **Sarn.Controller.cs**
```csharp
    public class ComicBooksController : Controller
    {
        public string Detail()
        {
            return "Hello";
        }
    }
```
- URL routing is controller/action
- `ContentResult`, `ViewResult`, and `RedirectResult` are a type of action result type.
- Had to modify the return type to `ActionResult`.  In order to find out that was the correct type to return that works for both `ContentResult` and `RedirectResult` you can hover over those types and click on F12 (to view the code) or ALT+F12 (to peek the code).

### Adding View ###
- In **View** folder right click Add > MVC 5 View Page (Razor) to add a view.
- You may need to create a folder for each controller and have the view be inside that folder. See **View/ComicBooks/Detail.cshtml**
- **Razor** is a view language allowing you to create views by combining C# and HMTL.
- For Razor, you can edit without having to recompile.

