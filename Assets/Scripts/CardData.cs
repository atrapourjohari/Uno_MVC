using Model.Cards;
using UnityEngine;

[CreateAssetMenu(fileName = "CardData", menuName = "Scriptable Objects/CardData")]
public class CardData : ScriptableObject
{
    public Texture texture;
    public CardType type;
    public CardColor color;
    public int value;
}
