namespace _0425hw
{
    internal class Dictionary
    {
        public async Task<string> ParseDictionary(string Word)
        {
            var Result=await Task<string>.Run(() => {
            int MaxSimilarity = 0;
            string Replacement = "";
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
                    for (int i = 0; i < Word.Length; i++)
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
            catch (Exception ex)
            {
                return ex.Message;
            }
                });
            return Result;
        }
        public bool AddNewWord (string Word)
        {
            bool flag = false;
            StreamReader sr = new StreamReader("eng.txt");
            string Words = sr.ReadToEnd();
            sr.Close();
            string[] SplitText = Words.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in SplitText)
            {
                if (s == Word)
                {
                    flag = true;
                    return false;
                }
            }
            StreamWriter sw=new StreamWriter("eng.txt",true);
            sw.WriteLine(Word);
            sw.Close();
            return true;
        }
    }
}
