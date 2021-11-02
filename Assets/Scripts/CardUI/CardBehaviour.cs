using UnityEngine; 

namespace CardUI
{
  public class CardBehaviour : MonoBehaviour
  {
    private CardProperties card;

    void Start(){
      card = new CardProperties();
      card.PrintText("Card Text from cardBehaviour");
      int myNumber  = card.PrintNumber(22);
      Debug.Log(myNumber);
    }
  }
}
