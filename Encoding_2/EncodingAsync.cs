using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Encoding_2
{
  internal static class EncodingAsync
  {
    private static int step = 0;
    private static int index = 0;
    private static int interim = 0;
    public static async Task NextAsync(string text, string password, bool isEncoding = false)
    {
      step = 0;
      index = 0;
      interim = 0;
      await Task.Run(() => Next(text, password, isEncoding));
    }

    private static void Next(string text, string password, bool isEncoding = false)
    {
      while (text.Length > step)
      {
        index = Data.AlphabetUpper.IndexOf(Convert.ToString(Data.ResultRLT[step]));
        interim =  Data.AlphabetUpper.IndexOf(Convert.ToString(text[step]));
        
        if (!isEncoding)
        {
          if (Data.AlphabetUpper.IndexOf(Convert.ToString(text[step])) != -1)
          {
            Data.ResultEncrypt += Convert.ToString(Data.AlphabetUpper[(interim + index) % 33]);
          }
          else 
          {
            Data.ResultEncrypt += Convert.ToString(text[step]);
          }
        }
        else
        {
          if (Data.AlphabetUpper.IndexOf(Convert.ToString(text[step])) != -1)
          {
            Data.ResultDecrypt += Convert.ToString(Data.AlphabetUpper[(interim - index) < 0 ? 33-(-1*(interim - index)) : (interim - index)]);
          }
          else 
          {
            Data.ResultDecrypt += Convert.ToString(text[step]);
          }
        }
        
        step += 1;
      }
    }
  }
}
