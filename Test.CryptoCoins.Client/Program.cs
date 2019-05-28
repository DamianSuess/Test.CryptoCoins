using NBitcoin;
using System;

namespace Test.CryptoCoins.Client
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
      ////Application.EnableVisualStyles();
      ////Application.SetCompatibleTextRenderingDefault(false);
      ////Application.Run(new Form1());
      ///

      CoinTests();
    }

    private static void CoinTests()
    { 
      // Wif(Network.Main): "L5YBgwdqKv3C5MUk5BHBCGQpwkEGb2PDuQhxu4GJ1btkLiZB71Be"
      Console.WriteLine("Hello : " + new Key().GetWif(Network.Main));
    }
  }
}