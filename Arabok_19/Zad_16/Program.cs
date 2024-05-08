/// <summary>
/// Класс, представляющий программу для копирования файлов и изменения атрибутов.
/// </summary>
class Program
{
    /// <summary>
    /// Копирует файлы из одной директории в другую и изменяет атрибуты.
    /// </summary>
    static void Main(string[] args)
    {
        try
        {
            string sourceDirectory = @"C:\KPiAYPfiles"; // Путь к исходной директории
            string targetDirectory = @"C:\Example_36tp"; // Путь к целевой директории

            Directory.CreateDirectory(targetDirectory);

            string[] files = Directory.GetFiles(sourceDirectory);

            for (int i = 0; i < Math.Min(3, files.Length); i++)
            {
                string sourceFilePath = files[i];
                string targetFilePath = Path.Combine(targetDirectory, Path.GetFileName(sourceFilePath));

                File.Copy(sourceFilePath, targetFilePath);

                File.SetAttributes(targetFilePath, FileAttributes.Hidden);

                string linkFilePath = Path.Combine(targetDirectory, $"LinkTo_{Path.GetFileName(sourceFilePath)}");
                File.Create(linkFilePath);
            }

            Console.WriteLine("Файлы успешно скопированы и атрибуты изменены.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
