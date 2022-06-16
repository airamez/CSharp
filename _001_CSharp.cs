using static System.Console;
using System.Text;
using System.Collections.Generic;
public class CSharp {
  public static void Main(string[] args) {
    WriteLine(Now());
  }

  static string Now() => DateTime.Now.ToLongDateString();
}
