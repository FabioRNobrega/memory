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
      this.cardAnimator = this.GetComponent<Animator>();
    }

    public void flipCard(string keyValue) {
      if (Input.GetKeyDown($"[{keyValue}]"))
      {
        if(cardAnimator.GetFloat("side") == 1) {        
          cardAnimator.SetFloat("side", 0);  
          selectedCards += 1;        
        } else {
          cardAnimator.SetFloat("side", 1);
        }
      }
    }

    void OnMouseUp()
    {
       if(cardAnimator.GetFloat("side") == 1) {        
          cardAnimator.SetFloat("side", 0);        
        } else {
          cardAnimator.SetFloat("side", 1);
        }
    }
  }
}
