class Program
{
    static void Main()
    {
        string str = "abc#d##c";
        int count = 0;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (str[i] == '#')
            {
                count++;
            }
            else
            {
                while (count > 0)
                {
                    if (str[i] != '#')
                    {
                        str = str.Remove(i, 1);
                        count--;

                        if (count != 0)
                        {
                            i--;
                        }
                    }
                    else
                    {
                        count++;
                        break;
                    }
                }
            }
        }

        str = str.Replace("#", "");
        Console.WriteLine(str);
    }
}