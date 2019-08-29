using System;
using System.Collections;
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
            
           // string ans="";
           //
           // for (int i=0;i<text.Length;i++)
             //   {
                //if(Char.IsUpper(text[i]))
                  //  {
                   // ans=ans+(char)((((int)(text[i])-65+shiftKey)%26)+65);
                   // }
               // else if (Char.IsLower(text[i]))
                 //   {
                  //  ans=ans+(char)((((int)(text[i])-97+shiftKey)%26)+97);
                   // }
//                else{ans=ans+text[i];}}return ans;



            Hashtable subs = new Hashtable();
             string[] g=new string[26];string[] gg=new string[26];
            string[] g1=new string[26];string[] gg1=new string[26];
           // g[0]=""+(char)97;
            for (int i=0;i<26;i++)
           {
               g[i]=""+(char)(i+97);
               gg[i]=""+(char)(97+((i+shiftKey)%26));
               subs.Add(g[i],gg[i]);
           }
            for (int i=0;i<26;i++)
           {
               g1[i]=""+(char)(i+65);
               gg1[i]=""+(char)(65+((i+shiftKey)%26));
               subs.Add(g1[i],gg1[i]);
           }
            string ans="";
            for(int i=0;i<text.Length;i++)
                {
                if(subs.ContainsKey(text[i]+""))
                    {
                    ans+=subs[text[i]+""];}
                else{ans+=text[i];
                    }


                }
            return ans;



        }
        public static void Main(string[] args){
            
        }
    }
}
