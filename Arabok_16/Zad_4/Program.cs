class Program
{
    static void Main()
    {
        string firstFilePath = "C:\\Практика КПиЯп\\Arabok_16\\Zad_4/Files/first.txt";
        string secondFilePath = "C:\\Практика КПиЯп\\Arabok_16\\Zad_4/Files/second.txt";
        string tempFilePath = "C:\\Практика КПиЯп\\Arabok_16\\Zad_4/Files/third.txt";

        string[] file1Lines = File.ReadAllLines(firstFilePath);
        string[] file2Lines = File.ReadAllLines(secondFilePath);

        using (StreamWriter writer = new StreamWriter(tempFilePath))
        {
            foreach (string line in file1Lines)
            {
                writer.WriteLine(line);
            }
            foreach (string line in file2Lines)
            {
                writer.WriteLine(line);
            }
        }

        string[] tempLines = File.ReadAllLines(tempFilePath);
        Array.Copy(tempLines, file1Lines, file1Lines.Length);
        Array.Copy(tempLines, file1Lines.Length, file2Lines, 0, file2Lines.Length);

        File.WriteAllLines(firstFilePath, file1Lines);
        File.WriteAllLines(secondFilePath, file2Lines);

        File.Delete(tempFilePath);

        Console.WriteLine("Файлы переписаны успешно.");
    }
}