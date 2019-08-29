using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            //throw new NotImplementedException("You need to implement this function.");

             //var subs = new Dictionary<string, string> { { "xyz", "ABC" }, { "mny", "OPQ" }, { "rst", "FGQ" } };
      //  string va = "abcdefghijklmnopqrstuvwxyz";
     //   va = subs.Aggregate(va, (result, s) => result.Replace(s.Key, s.Value));
     //   Console.WriteLine(va);
            
            string ans="";

            for (int i=0;i<text.Length;i++)
                {

                if(Char.IsUpper(text[i]))
                    {
                    ans=ans+(char)((((int)(text[i])-65+shiftKey)%26)+65);
                    }
                else if (Char.IsLower(text[i]))
                    {
                    ans=ans+(char)((((int)(text[i])-97+shiftKey)%26)+97);
                    }
                else{ans=ans+text[i];}


                }
            return ans;




        }
        public static void Main(string[] args){
            
        }
    }
}
