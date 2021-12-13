using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/madlibs")]
    public ActionResult MadLibs(string color, 
                                string supurlative, 
                                string adjective1, 
                                string bodypart1, 
                                string bodypart2, 
                                string noun, 
                                string animal, 
                                string adjective2, 
                                string adjective3, 
                                string adjective4)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Color = color;
      myMadLibVariable.Superlative = supurlative;
      myMadLibVariable.Adjective1 = adjective1;
      myMadLibVariable.BodyPart1 = bodypart1;
      myMadLibVariable.BodyPart2 = bodypart2;
      myMadLibVariable.Noun = noun;
      myMadLibVariable.Animal = animal;
      myMadLibVariable.Adjective2 = adjective2;
      myMadLibVariable.Adjective3 = adjective3;
      myMadLibVariable.Adjective4 = adjective4;
      return View(myMadLibVariable);
    }
  }
}