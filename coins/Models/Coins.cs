using System.Collections.Generic;

namespace Coins.Models
{
  public class Coiner
  {
    private int _inputNumber;

    public Coiner(int inputNumber)
    {
      _inputNumber = inputNumber;
    }

    public int GetNumber()
    {
      return _inputNumber;
    }

    public List<string> GetValue(int input)
    {
      List<string> result = new List<string>{};
      var change = input;

      if (change >= 25)
      {
        result.Add((change/25).ToString() + " Quarter");
        change = change%25;
      }
      if(change >= 10)
      {
        result.Add((change/10).ToString() + " Dime");
        change = change % 10;
      }
      if(change >= 5)
      {
        result.Add((change/5).ToString() + " Nickel");
        change = change % 5;
      }
      if(change >= 1)
      {
        result.Add((change/1).ToString() + " Penny");
      }
      return result;
    }

  }
}
