using System.Linq;
using System.Web.Mvc;
using WebAdventureGame.helper;
using WebAdventureGame.Models;

namespace WebAdventureGame.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index(string question, int? locationId)
        {
            GameDTO model = new GameDTO();

            //if (question != null)
            //{
            //    if (question == GameLogic.LastQuestion)
            //    {
            //        ViewBag.GameOver = true;
            //    }
            //    model.Question = question;
            //}
            //else
            if (question == null)
            {
                var item1 = GameLogic.GameItems[0];
                question = item1.question;
                locationId = item1.id;
            }
            model.Question = question;
            model.locationId = locationId;

            if (GameLogic.GameItems.Where(x => x.parentId == locationId).Count()==0)
                ViewBag.GameOver = true;


            return View(model);
        }
        [HttpPost]
        public ActionResult Index(GameDTO model, string Reset)
        {
            if (Reset == null)
            { 
                var item = GameLogic.GetNextQuestion(model.locationId, model.Answer);
                if (item == null)
                {
                    item = GameLogic.GameItems[0];
                }
                return RedirectToAction("Index", new { question = item.question, locationId = item.id });

            }
            else
            {
                return RedirectToAction("Index");

            }
        }
    }
}