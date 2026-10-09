using Model.Cards;
using UnityEngine;

public class CardModel
{
    private CardType _cardType;
    private CardColor _cardColor;
    private int _cardValue;

    public CardModel(CardType cardType, CardColor cardColor, int cardValue)
    {
        _cardType = cardType;
        _cardColor = cardColor;
        _cardValue = cardValue;
        
    }
}
