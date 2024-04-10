using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
	public class HomeController : Controller
	{
		[Route("/")]
		public ActionResult Form() { return View(); }
		
		[Route("/story")]
		public ActionResult Story(string word1, string word2, string word3)
		{
			MadLib newStory = new(new[] {word1, word2, word3});
			return View(newStory);
		}
	}
}