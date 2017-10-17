using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Coins.Models;

namespace Coins.Tests
{

  [TestClass]
  public class CoinerTests
  {
    [TestMethod]
    public void GetValue()
    {
      //Arrange
      Coiner newCoin = new Coiner(26);

      var output = new List<string>{"1 Quarter", "1 Penny"};

      //Act
      List<string> result = newCoin.GetValue(newCoin.GetNumber());
      foreach(string coin in result)
      {
        Console.WriteLine(coin);
      }
      //Assert
      CollectionAssert.AreEqual(result, output);

    }

    }
  }
