using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class CheckScrabbleScore
  {
    
    public int CheckScore(string userEnteredText) {
      Dictionary<string, int> scorecard = new Dictionary<string, int>() { 
        {"a", 1}
      };
        return scorecard["a"];
    }

  }
}