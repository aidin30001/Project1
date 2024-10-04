using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encoding_2
{
  internal static class Data
  {
      private static  string alphabetUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
      private static string alphabetLower = "абвгдеёжзийклмнопрстуфхцшщъыьэюя";
      private static string? password = null;
      private static string? resultEncrypt = null;
      private static string? resultDecrypt = null;
      private static string? resultRLT = null;

      public static string AlphabetUpper 
      {
        get { return alphabetUpper; }
      }
      public static string AlphabetLower 
      {
        get { return alphabetLower; }
      }
      public static string  PasswordEncoding  
      {
        get { return password!; }
        set { password = value; }
      }
      public static string ResultEncrypt            
      {
        get { return resultEncrypt!; }
        set { resultEncrypt = value; }
      }
      public static string ResultDecrypt            
      {
        get { return resultDecrypt!; }
        set { resultDecrypt = value; }
      }
      public static string ResultRLT            
      {
        get { return resultRLT!; }
        set { resultRLT = value; }
      }
  }
}
