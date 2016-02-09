using Nancy;
using Triangles.Objects;
using System.Collections.Generic;

namespace Triangles
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["form_page.cshtml"];
      Post["/results_page"] = _ => {
        Triangle newTriangle = new Triangle(Request.Form["newSide1"],Request.Form["newSide2"],Request.Form["newSide3"]);
        return View["results_page.cshtml", newTriangle];
      };
    }
  }
}
