using UnityEngine; 
using System;
using System.Collections;
using System.Collections.Generic;

namespace CardUI {
  public class CardProperties
  {
    #region Variables 
    public int id { get; set; }
    public int value { get; set; }
    public string Type { get; set; }
    public float PositionX { get; set; }
    public float PositionY { get; set; }
    public bool CardIsFlipped { get; set; }
    #endregion
  }
}
