class Program
{
    static void Main()
    {
        string folderPath = @"C:\Практика КПиЯп\Arabok_16\Zad_2\New_folder";
        DirectoryInfo newFolder = Directory.CreateDirectory(folderPath);

        Console.WriteLine($"Папка \"{newFolder.Name}\" успешно создана по пути: {newFolder.FullName}");

    }
}