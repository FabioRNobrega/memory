using UnityEngine; 
using System;
using System.Collections;
using System.Collections.Generic;

namespace CardUI
{
  public class CardBehavior : MonoBehaviour
  {
    public CardList cardList;
    void Start(){
      cardList = new CardList();

      for (int i = 0; i < 9; i++) 
      {
        Debug.Log(i+1);
        cardList.addCard((i+1), (10 * i+1), "Type", (i * 100),(i * 100),false);
      } 

      cardList.ShowCardList(cardList);
    }
  }
}
