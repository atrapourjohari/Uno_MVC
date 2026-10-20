
using System.Collections.Generic;
using Model.Cards;
using Model.Deck;

namespace Service
{
    public class DeckService
    {
        public DeckModel CreateDeck()
        {
            List<CardModel> deck = new List<CardModel>();
            for (int i = 0; i < 4; i++)
            {
                deck.Add(new CardModel(CardType.Number,(CardColor)i,0));

                for (int j = 1; j <= 9; j++)
                {
                    deck.Add(new CardModel(CardType.Number,(CardColor)i,j));
                    deck.Add(new CardModel(CardType.Number,(CardColor)i,j));


                }
            }
            DeckModel deckModel = new DeckModel(deck);
            return deckModel;
        }
    }
}