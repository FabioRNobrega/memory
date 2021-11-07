using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardUI
{
  public class CardBehavior : MonoBehaviour
  {
    #region Variables
    private SpriteRenderer cardBody;
    private Animator cardAnimator;
    public CardList cardList;
    Vector2 movement;

    #endregion
    void Start(){
      // this.cardList = new CardList<CardList>();
      this.cardAnimator = this.GetComponent<Animator>();
      this.cardBody = this.GetComponent<SpriteRenderer>();

      for (int i = 0; i < 9; i++) 
      {
        Debug.Log(i+1);
        cardList.addCard((i+1), (10 * i+1), "Type", (i * 100),(i * 100),false);
      } 

      // cardList.ShowCardList(cardList);
    }

    void Update() 
    {
      movement.x = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate() 
    {

      cardAnimator.SetFloat("side", Mathf.Abs(movement.x));

      if(Input.GetKeyUp(KeyCode.Escape)) {
        Application.Quit();
      }
    }

    void cardFlip() 
    {
      if(movement.x >= 0) {
        this.cardBody.flipX = false;
      } else {
        this.cardBody.flipX = true;
      }
    }
  }
}
