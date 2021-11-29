using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardUI
{
  public class CardBehavior : MonoBehaviour
  {
    #region Variables
    public CardList cardBehaviorList;

    #endregion
    void Start(){
      cardBehaviorList = new CardList();
    
      for (int i = 0; i < 9; i++) 
      {
        cardBehaviorList.addCard((i+1), (10 * i+1), "Type", (i * 100),(i * 100),false);
      } 

      cardBehaviorList.ShowCardList(cardBehaviorList.cards);
    }
  }
}
