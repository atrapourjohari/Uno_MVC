using System.Collections.Generic;
using Model.Cards;
using Model.Deck;
using Model.Game;
using UnityEngine;

public class GameModel
{
    //Players 
    private List<PlayerModel> _players = new List<PlayerModel>();
    
    //Deck
    public DeckModel Deck;
    
    //GameState 
    private GameState _gameState;
    //Player Turn 
    public PlayerModel currentPlayer;
    public CardColor currentCardColor;
    public PlayerModel winner;
    // Rules
    //Table 
    public GameModel(DeckModel deck)
    {
      Deck = deck;
        _gameState = GameState.Waiting;
    }

    public void AddPlayer(PlayerModel player)
    {
        _players.Add(player);
    }

    public void PlayerACard(CardModel card)
    {
        currentPlayer.RemoveCard(card);
    }

    public void AddCard(CardModel card)
    {
        currentPlayer.GetCard(card);
    }

    public void AdvanceTurn(int nextPlayerIndex)
    {
        currentPlayer = _players[nextPlayerIndex];
    }
    
    public CardModel DrawCard()
    {
        return Deck.DrawCard();
    }

    public override string ToString()
    {
        string opt = "";
        opt = "Player List \n";
        for (int i = 0; i < _players.Count; i++)
        {
         opt=opt+_players[i].ToString()+"\n";   
        }

        opt = opt + "\n Deck Data "+Deck.ToString();
        return opt;
        
    }
}
