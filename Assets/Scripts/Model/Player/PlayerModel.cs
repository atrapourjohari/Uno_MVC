using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class PlayerModel
{
    private string _name;

    private bool _isHumane = true;

    private int _id;
    
    public List<CardModel> cardHands = new List<CardModel>();

    public PlayerModel(string name, bool player, int id)
    {
        _name = name;
        _isHumane = player;
        _id = id;
        
    }
    // Get Card 
    /*
     * Add a card from the game to player
     * that mean it have a card parameter
     * that will add it player cards
     */
    public void GetCard(CardModel card)
    {
        cardHands.Add(card);
    }
    
    // Remove Card 
    /*
     * Check player have any card 
     * Remove a card From player cards
     * a return a Card 
     */
    public CardModel RemoveCard(CardModel card)
    {
        if (cardHands.Count > 0)
        {
            cardHands.Remove(card);
        }
        return card;
    }
}
