using System;
using System.Collections.Generic;
using System.Text;

namespace Code
{
    public class RotationalCipher
    {
        public static string Rotate(string Text, int Key)
        {
            var builder = new StringBuilder();
            Key=Key%26;
            foreach (char c in Text)
            {
                int i = System.Convert.ToInt32(c);
                if(i>64&&i<91)
                {
                    builder.Append((char)(((i+Key-65)%26)+65));
                }
                else if(i>96&&i<123)
                {
                    builder.Append((char)(((i+Key-97)%26)+97));
                }
                else
                {
                    builder.Append((char)i);
                }
            }
            return(builder.ToString());
        }
    }

}