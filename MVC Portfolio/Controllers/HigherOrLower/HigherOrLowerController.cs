using System.Web.Mvc;
using System.Web.Providers.Entities;
using MVCPortfolio.Models.HigherOrLower;

namespace MVCPortfolio.Controllers.HigherOrLower
{
    public class HigherOrLowerController : Controller
    {

        //
        // GET: /Home/

        

        public ActionResult Index()
        {
            var deck = new CardDecks();

            //Session["wins"] = deck.Wins;
            //Session["losses"] = deck.Losses;
            //Session["draws"] = deck.Draws;

            var model = deck.RandomCard(deck.OriginalDeck);
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Higher(Card dealtCard, string command)
        {

            var model = new CardDecks();

            var current = new CardsInPlay();

            model.OriginalDeck = model.CreateCardDeck();

            current.DealtCard = dealtCard;
            current.PlayerCard = model.RandomCard(model.OriginalDeck);

            current.CardDisplay = new Card[2];

            current.CardDisplay[0] = current.DealtCard;
            current.CardDisplay[1] = current.PlayerCard;


            switch (CompareCards(current.CardDisplay[0], current.CardDisplay[1], command))
            {
                case 1:
                    current.Message = "It's a tie!:(";
                    break;
                case 2:
                    current.Message = "You win!";
                    break;
                case 3:
                    current.Message = "You lose!";
                    break;
            }

            return View("Higher", current);
        }

        [HttpPost]
        public ActionResult Lower(Card dealtCard, string command)
        {
            var model = new CardDecks();

            var current = new CardsInPlay();

            model.OriginalDeck = model.CreateCardDeck();

            current.DealtCard = dealtCard;
            current.PlayerCard = model.RandomCard(model.OriginalDeck);

            current.CardDisplay = new Card[2];

            current.CardDisplay[0] = current.DealtCard;
            current.CardDisplay[1] = current.PlayerCard;


            switch (CompareCards(current.CardDisplay[0], current.CardDisplay[1], command))
            {
                case 1:
                    current.Message = "It's a tie!:(";
                    break;
                case 2:
                    current.Message = "You win!";
                    break;
                case 3:
                    current.Message = "You lose!";
                    break;
            }

            return View("Lower", current);
        }


        public int CompareCards(Card dealtCard, Card playerCard, string command)
        {
            bool winHigher = (command == "Higher");
            bool winLower = (command == "Lower");

            if (dealtCard.CardValue == playerCard.CardValue)
            {
                return 1;
            }
            if ((dealtCard.CardValue < playerCard.CardValue && winHigher) ||
                (dealtCard.CardValue > playerCard.CardValue && winLower))
            {
                return 2;
            }
            else
            {
                return 3;
            }

        }

    }
}
