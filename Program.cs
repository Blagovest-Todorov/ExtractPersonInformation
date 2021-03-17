using System;
using System.Text;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            
            

            for (int i = 0; i < nLines; i++)
            {
                string text = Console.ReadLine();

                string sbName = string.Empty;
                string sbAge = string.Empty;

                if ( text.Contains('@') && text.Contains('|') && text.Contains('#') &&  text.Contains('*') )
                {
                    int idxOfAtSymbol = text.IndexOf('@');  //start idx +1  ->  Name
                    int idxOfPipeSymbol = text.IndexOf('|'); //endIdx -1 / Name
                    int idxOfHashTagSymbol = text.IndexOf('#'); //startIdx +1  of Age
                    int idxOfAstericSymbol = text.IndexOf('*'); //endIdx -1 of Age

                    for (int j = idxOfAtSymbol + 1; j < idxOfPipeSymbol; j++)
                    {
                        sbName += text[j];
                    }

                    for (int k = idxOfHashTagSymbol + 1 ; k < idxOfAstericSymbol; k++)
                    {
                        sbAge += text[k];
                    }
                }

                Console.WriteLine($"{sbName} is {sbAge} years old.");
                
            }
        }
    }
}
