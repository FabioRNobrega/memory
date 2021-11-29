using UnityEngine; 
using System;
using System.Collections;
using System.Collections.Generic;

namespace CardUI {
  public class CardList 
  {
    public List<CardProperties> cards = new List<CardProperties>();

    public void ShowCardList(List<CardProperties> cardList)
    {
        foreach(CardProperties card in cardList)
        {
             Debug.Log( "Card Id: " + card.id + " Card Value: " + card.value);
        }
    }
    public string PrintText(string Text)
    { 
      Debug.Log(Text);

      return Text;
    }

    public bool addCard (
      int id,
      int value,
      string Type,
      float PositionX,
      float PositionY,
      bool CardIsFlipped
    ) {
      cards.Add(new CardProperties{
        id = id,
        value = value,
        Type = Type,
        PositionX = PositionX,
        PositionY = PositionY,
        CardIsFlipped = CardIsFlipped
      });
      return true;
    }
  }
}