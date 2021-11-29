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
    Vector2 movement;    

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

      // cardAnimator.SetFloat("side", Mathf.Abs(movement.x));

      if(Input.GetKeyUp(KeyCode.Escape)) {
        Application.Quit();
      }
    }
  }
}
