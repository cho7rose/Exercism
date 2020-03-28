using System;
using System.Text;

namespace MyCode
{
    public class Bob
    {
        public static string Response(string text)
        {
            var response="";
            bool AllUpper=true;
            bool Question=false;
            bool NoLetters=true;
            bool NoNumbers=true;
            char[] myChar = text.ToCharArray();
            text=text.Trim(' ');
            if(text.EndsWith("?"))
            {
                Question=true;
            }
            foreach(char c in text)
            {
                if(!Char.IsSymbol(c)&&!Char.IsWhiteSpace(c)&&!Char.IsPunctuation(c))
                {
                    if(Char.IsLetter(c))
                    {
                        NoLetters=false;
                    }
                    if(Char.IsDigit(c))
                    {
                        NoNumbers=false;
                    }
                    if(Char.IsLower(c))
                    {
                        AllUpper=false;
                    }
                }
            }
            if(NoLetters==true)
            {
                AllUpper=false;
            }
            if(AllUpper==true)
            {
                if(Question==true)
                {
                    response="Calm down, I know what I'm doing!";
                }
                else
                {
                    response="Whoa, chill out!";
                }
            }
            else
            {
                if(Question==true)
                {
                    response="Sure.";
                }
                else
                {
                    response="Whatever.";
                }
            }
            if(NoLetters==true&&NoNumbers==true&&Question==false)
            {
                response="Fine. Be that way!";
            }
            return(response);            
        }
    }
}
