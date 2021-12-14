using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

namespace CardUI
{
  public class Main : MonoBehaviour
  {
    #region Variables
    public CardList cardBehaviorList;
    public CardBehavior cardBehaviorClass;

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
        clone.name = $"{i+i}";
      } 

      cardBehaviorList.ShowCardList(cardBehaviorList.cards);
    }

    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
        {
          string cardNumber = Regex.Replace($"{e.keyCode}", "[^0-9]", "");
          clone = GameObject.FindWithTag(cardNumber);
          cardBehaviorClass = clone.GetComponent<CardBehavior>();
          cardBehaviorClass.flipCard($"{cardNumber}");
        }
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