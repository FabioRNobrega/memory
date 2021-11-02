using UnityEngine; 

namespace CardUI {
  public class CardProperties
  {
    public string PrintText(string Text)
    { 
      Debug.Log(Text);

      return "Card Text";
    }

    public int PrintNumber(int Number)
    {
      Debug.Log(Number);

      return 1;
    }
  }
}
