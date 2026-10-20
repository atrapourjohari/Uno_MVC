using System.Collections.Generic;
using Model.Deck;
using Model.Game;
using UnityEngine;

namespace Service
{
    public class GameSetupService
    {
        private DeckService _deckService;
        private List<PlayerModel> _players=new List<PlayerModel>();
        private GameModel _gameModel;
        private DeckModel _deck;
        public GameSetupService(int numberOfPlayers)
        {
            _deckService = new DeckService();
            _deck = _deckService.CreateDeck();
            _gameModel = new GameModel(_deck);
            for (int i = 0; i < numberOfPlayers; i++)
            {
                PlayerModel playerModel=new PlayerModel("Player" + i,true,i);
                _players.Add(playerModel);
                _gameModel.AddPlayer(playerModel);
                
            }

            GetCardToPlay();
        }

        private void GetCardToPlay()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                var player = _players[i];
                for (int j = 0; j < 7; j++)
                {
                  var card=  _gameModel.DrawCard();
                  player.GetCard(card);
                }
            }
        }

        public override string ToString()
        {
            return _gameModel.ToString();
        }
    }
}