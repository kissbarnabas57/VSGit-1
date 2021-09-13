using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSGit
{
  class Program
  {
    static void Main(string[] args)
    {
      ElsoFeladat();
      MasodikFeladat();

      Console.ReadKey();
    }

    private static void MasodikFeladat()
    {
      Console.WriteLine("2. feladat");
      Random rnd = new Random();
      Console.WriteLine("Random szám:{0}", rnd.Next(1,101));
    }

    private static void ElsoFeladat()
    {
      Console.WriteLine("Próba");
    }
  }
}
