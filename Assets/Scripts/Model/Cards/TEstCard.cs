namespace Model.Cards
{
    public class TEstCard
    {
        public void CreateCard()
        {
            CardModel cardModel = new CardModel(CardType.Number, CardColor.Blue, 1);
        }
    }
}