﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Resources;

namespace _0425hw
{
    internal class Model
    {
        public string ParseDictionary(string Word)
        {
            int MaxSimilarity = 0;
            string Replacement="";
            string Words;
            try
            {
                StreamReader sr = new StreamReader("eng.txt");
                Words = sr.ReadToEnd();
                sr.Close();
                string[] SplitText = Words.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in SplitText)
                {
                    int CurSimilarity = 0;
                    for(int i=0;i<Word.Length;i++)
                    {
                        if (Word[i] == s[i])
                        {
                            CurSimilarity++;
                        }
                    }
                    if (CurSimilarity > MaxSimilarity)
                    {
                        MaxSimilarity = CurSimilarity;
                        Replacement = s;
                    }
                }
                return Replacement;
            }
            catch(Exception ex )
            {
                return ex.Message;
            }
        }
    }
}
