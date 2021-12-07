using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardUI
{
  public class CardBehavior : MonoBehaviour
  {
    #region Variables
    public CardList cardBehaviorList;
    private SpriteRenderer cardBody;
    private Animator cardAnimator;

    public bool flip = false;

    public Transform prefab;

    #endregion
    void Start(){
      
      cardBehaviorList = new CardList();
      this.cardAnimator = this.GetComponent<Animator>();
      this.cardBody = this.GetComponent<SpriteRenderer>();
    
      for (int i = 0; i < 9; i++) 
      {
        cardBehaviorList.addCard((i+1), (10 * i+1), "Type", (i * 100),(i * 100),false);
      } 

      cardBehaviorList.ShowCardList(cardBehaviorList.cards);
    }

     void FixedUpdate() 
    { 
      foreach(CardProperties  card in cardBehaviorList.cards ) {
        Debug.Log(card);
        if (Input.GetKeyDown($"[{card.id}]"))
          {
            if(flip) 
            {
              cardAnimator.SetFloat("side", 1);
              flip = !flip;
              return;
            } 
            cardAnimator.SetFloat("side", 0);          
            flip = !flip;
          }
      }

      
      if(Input.GetKeyUp(KeyCode.Escape)) 
        {
          Application.Quit();
        }
    }
  }
}
