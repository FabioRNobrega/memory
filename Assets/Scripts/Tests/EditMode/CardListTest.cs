using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace CardUI {
  public class Card
  {
      // A Test behaves as an ordinary method
      [Test]
      public bool addCard()
      {
        Card = new CardList<CardList>();

        Card.addCard(1,10,"Type",0,0,false);
      }
  }
}
