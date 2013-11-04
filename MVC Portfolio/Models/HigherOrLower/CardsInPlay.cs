namespace MVCPortfolio.Models.HigherOrLower
{
    public class CardsInPlay
    {
        public Card DealtCard { get; set; }
        public Card PlayerCard { get; set; }
        public Card[] CardDisplay { get; set; }
        public string Message { get; set; }
     

    }
}
