using System.Text;
class Message
{
    char[] delimiterChars = { ' ', ',', '.', ':' };
    public void WordN(string message, int n)
    {
        string[] word = message.Split(delimiterChars);
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i].Length < n && word[i].Length > 0)
            {
                System.Console.WriteLine(word[i]);
            }
        }
    }

    public string DelWord(string message, char symbol)
    {
        string res = String.Empty;
        string[] word = message.Split(delimiterChars);
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i].EndsWith(symbol) != true)
            {
                res = res + word[i] + " ";
            }
        }
        return res;
    }

    public string MaxLenthWord(string message)
    {
        string[] word = message.Split(delimiterChars);
        string max = word[0];
        for (int i =1; i<word.Length; i++)
        {
            if (word[i].Length>max.Length)
            {
                max = word[i];
            }
        }
        return max;
    }

    public StringBuilder MaxLenthWordString(string message)
    {
        string res = String.Empty;
        StringBuilder str=new StringBuilder();
        string[] word = message.Split(delimiterChars);
        string max = MaxLenthWord (message);
        for (int i =1; i<word.Length; i++)
        {
            if (word[i].Length==max.Length)
            {
                str.Append($"{word[i]} ");
            }
        }
        return str;
    }



}