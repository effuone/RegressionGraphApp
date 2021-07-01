using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegressionLineApp {
  public class Validator {
    public static bool AreAllNumbers(string input) {
      string temp = input.Replace(" ", "");
      bool ans = true;
      foreach (var ch in temp) {
        if (!Char.IsNumber(ch)) {
          ans = false;
          break;
        }
      }
      return ans;
    }
  }
}
