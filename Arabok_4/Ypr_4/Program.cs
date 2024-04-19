//Введите два числа
//4
//2
//4 / 2 = 2
// после try-блока
//Введите два числа
//3
//g
//Нужно ввести число!
// после try-блока
//Введите два числа
//d
//Нужно ввести число!
// после try-блока
//Введите два числа
//2
//0
//Делить на нуль нельзя!
// после try-блока
//Введите два числа
//1234567899876543
//Какая - то ошибка
// после try-блока

for (int i = 0; i < 5; i++)
{
    try
    {
        Console.WriteLine("Введите два числа");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(a + " / " + b + " = " + a / b);
    }
    catch (FormatException)
    {
        Console.WriteLine("Нужно ввести число! ");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Делить на нуль нельзя!");
    }
    catch
    {
        Console.WriteLine("Какая - то ошибка ");
    }
    finally
    {
        Console.WriteLine(" после try-блока ");
    }
}
