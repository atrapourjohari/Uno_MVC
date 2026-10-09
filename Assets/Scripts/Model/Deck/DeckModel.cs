using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Model.Deck
{
    public class DeckModel
    {
      private   List<CardModel> _cardDeck = new List<CardModel>();

      public DeckModel(List<CardModel> cardDeck)
      {
          _cardDeck = cardDeck;
          Shuffle();
      }
      public void AddCard(CardModel card)
      {
          _cardDeck.Add(card);
      }

      public CardModel DrawCard()
      {
          CardModel cardModel = _cardDeck.First();
          _cardDeck.Remove(cardModel);
          return cardModel;
      }

      private void Shuffle()
      {
          int n = _cardDeck.Count;
          while (n > 1)
          {
              n--;
              int k = UnityEngine.Random.Range(0, n + 1);
              CardModel card = _cardDeck[k];
              _cardDeck[k] = _cardDeck[n];
              _cardDeck[n] = card;
          }
      }
    }
}