using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Encoding_2
{
    public class VigenereCipher
    {
      public async Task EncryptAsync(string text, string password)
      {
        await RepeatsLengthText.NextAsync(text, password);
        await EncodingAsync.NextAsync(text, password);
      }

      public async Task DecryptAsync(string text, string password)
      {
        await RepeatsLengthText.NextAsync(text, password);
        await EncodingAsync.NextAsync(text, password, true);
      }
    }
}
