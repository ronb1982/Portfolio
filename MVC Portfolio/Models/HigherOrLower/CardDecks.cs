using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPortfolio.Models.HigherOrLower
{
    public class CardDecks
    {
        public List<Card> OriginalDeck { get; set; }
        
        public List<Card> Discard { get; set; }
        public Card Card { get; set; }

        public Card SelectedCard { get; set; }

        
        


        public CardDecks()
        {
            CreateCardDeck();
        }

        public List<Card> CreateCardDeck()
        {
        
            OriginalDeck = new List<Card>()
            {
                new Card() {CardValue = 2, FileName = "~/Content/2_of_clubs.png", CardId=1},
                new Card() {CardValue = 3, FileName = "~/Content/3_of_clubs.png", CardId=2},
                new Card() {CardValue = 4, FileName = "~/Content/4_of_clubs.png", CardId=3},
                new Card() {CardValue = 5, FileName = "~/Content/5_of_clubs.png", CardId=4},
                new Card() {CardValue = 6, FileName = "~/Content/6_of_clubs.png", CardId=5},
                new Card() {CardValue = 7, FileName = "~/Content/7_of_clubs.png", CardId=6},
                new Card() {CardValue = 8, FileName = "~/Content/8_of_clubs.png", CardId=7},
                new Card() {CardValue = 9, FileName = "~/Content/9_of_clubs.png", CardId=8},
                new Card() {CardValue = 10, FileName = "~/Content/10_of_clubs.png", CardId=9},
                new Card() {CardValue = 11, FileName = "~/Content/jack_of_clubs2.png", CardId=10},
                new Card() {CardValue = 12, FileName = "~/Content/queen_of_clubs2.png", CardId=11},
                new Card() {CardValue = 13, FileName = "~/Content/king_of_clubs2.png", CardId=12},
                new Card() {CardValue = 14, FileName = "~/Content/ace_of_clubs.png", CardId=13},
                
                new Card() {CardValue = 2, FileName = "~/Content/2_of_hearts.png", CardId=14},
                new Card() {CardValue = 3, FileName = "~/Content/3_of_hearts.png", CardId=15},
                new Card() {CardValue = 4, FileName = "~/Content/4_of_hearts.png", CardId=16},
                new Card() {CardValue = 5, FileName = "~/Content/5_of_hearts.png", CardId=17},
                new Card() {CardValue = 6, FileName = "~/Content/6_of_hearts.png", CardId=18},
                new Card() {CardValue = 7, FileName = "~/Content/7_of_hearts.png", CardId=19},
                new Card() {CardValue = 8, FileName = "~/Content/8_of_hearts.png", CardId=20},
                new Card() {CardValue = 9, FileName = "~/Content/9_of_hearts.png", CardId=21},
                new Card() {CardValue = 10, FileName = "~/Content/10_of_hearts.png", CardId=22},
                new Card() {CardValue = 11, FileName = "~/Content/jack_of_hearts2.png", CardId=23},
                new Card() {CardValue = 12, FileName = "~/Content/queen_of_hearts2.png", CardId=24},
                new Card() {CardValue = 13, FileName = "~/Content/king_of_hearts2.png", CardId=25},
                new Card() {CardValue = 14, FileName = "~/Content/ace_of_hearts.png", CardId=26},

                new Card() {CardValue = 2, FileName = "~/Content/2_of_spades.png", CardId=27},
                new Card() {CardValue = 3, FileName = "~/Content/3_of_spades.png", CardId=28},
                new Card() {CardValue = 4, FileName = "~/Content/4_of_spades.png", CardId=29},
                new Card() {CardValue = 5, FileName = "~/Content/5_of_spades.png", CardId=30},
                new Card() {CardValue = 6, FileName = "~/Content/6_of_spades.png", CardId=31},
                new Card() {CardValue = 7, FileName = "~/Content/7_of_spades.png", CardId=32},
                new Card() {CardValue = 8, FileName = "~/Content/8_of_spades.png", CardId=33},
                new Card() {CardValue = 9, FileName = "~/Content/9_of_spades.png", CardId=34},
                new Card() {CardValue = 10, FileName = "~/Content/10_of_spades.png", CardId=35},
                new Card() {CardValue = 11, FileName = "~/Content/jack_of_spades2.png", CardId=36},
                new Card() {CardValue = 12, FileName = "~/Content/queen_of_spades2.png", CardId=37},
                new Card() {CardValue = 13, FileName = "~/Content/king_of_spades2.png", CardId=38},
                new Card() {CardValue = 14, FileName = "~/Content/ace_of_spades.png", CardId=39},

                new Card() {CardValue = 2, FileName = "~/Content/2_of_diamonds.png", CardId=40},
                new Card() {CardValue = 3, FileName = "~/Content/3_of_diamonds.png", CardId=41},
                new Card() {CardValue = 4, FileName = "~/Content/4_of_diamonds.png", CardId=42},
                new Card() {CardValue = 5, FileName = "~/Content/5_of_diamonds.png", CardId=43},
                new Card() {CardValue = 6, FileName = "~/Content/6_of_diamonds.png", CardId=44},
                new Card() {CardValue = 7, FileName = "~/Content/7_of_diamonds.png", CardId=45},
                new Card() {CardValue = 8, FileName = "~/Content/8_of_diamonds.png", CardId=46},
                new Card() {CardValue = 9, FileName = "~/Content/9_of_diamonds.png", CardId=47},
                new Card() {CardValue = 10, FileName = "~/Content/10_of_diamonds.png", CardId=48},
                new Card() {CardValue = 11, FileName = "~/Content/jack_of_diamonds2.png", CardId=49},
                new Card() {CardValue = 12, FileName = "~/Content/queen_of_diamonds2.png", CardId=50},
                new Card() {CardValue = 13, FileName = "~/Content/king_of_diamonds2.png", CardId=51},
                new Card() {CardValue = 14, FileName = "~/Content/ace_of_diamonds.png", CardId=52},
            };
            Discard = new List<Card>();

            return OriginalDeck;
        }

       public Card RandomCard(List<Card> deck)
        {
            Random r = new Random();
            var randomId = r.Next(1, deck.Count) + 1;
            SelectedCard = deck.FirstOrDefault(c => c.CardId == randomId);

            return SelectedCard;
        }

        //public void AddCardToDrawn(List<Card> drawn, Card dealtCard)
        //{
        //    drawn.Add(dealtCard); // passed-in argument from caller on controller
        //}

        //public void RemoveCardFromDeck(List<Card> deck, Card dealtCard)
        //{
        //    deck.RemoveAll(c => c.CardId == dealtCard.CardId);
        //}
    }
}