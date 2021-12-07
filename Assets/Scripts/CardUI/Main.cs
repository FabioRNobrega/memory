using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardUI
{
  public class Main : MonoBehaviour
  {
    #region Variables
    public CardList cardBehaviorList;

    public GameObject prefab; 
    public GameObject clone; 

    Vector2[] positions = { new Vector2(-2.5f, 2.5f), new Vector2(0, 2.5f), new Vector2(2.5f,2.5f), new Vector2(-2.5f,0), new Vector2(0,0),  new Vector2(2.5f, 0),  new Vector2(-2.5f,-2.5f),  new Vector2(0, -2.5f),  new Vector2(2.5f, -2.5f) } ;

    #endregion
    void Start(){      
      cardBehaviorList = new CardList();




      for (int i = 0; i < 9; i++) 
      {
        cardBehaviorList.addCard((i+1), (10 * i+1), "Type", (i * 100),(i * 100),false);
        clone = Instantiate(prefab, positions[i], Quaternion.identity);
        clone.tag = $"{i+1}";
      } 

      cardBehaviorList.ShowCardList(cardBehaviorList.cards);
    }

      void FixedUpdate() 
    {       
      if(Input.GetKeyUp(KeyCode.Escape)) 
        {
          Application.Quit();
        }
    }
  }
}