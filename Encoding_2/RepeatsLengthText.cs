using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encoding_2
{
  internal static class RepeatsLengthText
  {
    private static int step = 0;
    private static int index = 0;
    public static async Task NextAsync(string text, string password)
    {
      step = 0;
      index = 0;
      Data.ResultRLT = null!;
      await Task.Run(() => Next(text, password));
    }
    
    private static void Next(string text, string password)
    {
      while (text.Length > step)
      {
        if (password.Length <= index && text.Length > step)
        {
          index = 0;
        }

        Data.ResultRLT += password[index];

        step += 1;
        index += 1;
      }
    }
  }
}
