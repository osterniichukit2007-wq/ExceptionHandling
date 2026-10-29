
Console.OutputEncoding = System.Text.Encoding.UTF8;

bool isValid = false;

while (!isValid)
{
    Console.Write("Введіть ціле число: ");
    string? input = Console.ReadLine();

    try
    {
        int number = Int32.Parse(input!);

        Console.WriteLine($"Ви ввели число: {number}");
        isValid = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Введене значення не є числом.");
    }
    catch (OverflowException) when (input != null && input.StartsWith("-"))
    {
        Console.WriteLine("Число менше за допустимий діапазон Int32.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Число більше за допустимий діапазон Int32.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Помилка: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Спробу введення завершено.\n");
    }
}