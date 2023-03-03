using Project_2023.Models;
using Project_2023.Models.Converters;
using Project_2023.Models.Measurements;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

ConsoleKey choice;
do
{
    Console.WriteLine("===== Вітаю вас користуваче =====");

    IMetricConverter converter = ChooseConverter();

    Console.WriteLine("\nВи обрали " + converter.GetType().Name);
    while (true)
    {
        try
        {
            ConvertUnit(converter);
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    Console.Write("Бажаєте продовжити? Y/N :>");
    choice = Console.ReadKey().Key;
    Console.WriteLine();
} while (choice == ConsoleKey.Y);

static Unit ChooseLengthUnit()
{
    Console.WriteLine("Виберіть одиницю вимірювання ");
    Console.Write("I -> дюйми, F -> фути, Y -> Ярди, M -> милі :>");

    var choiceUnit = Console.ReadKey().Key;
    Console.WriteLine();

    return choiceUnit switch
    {
        ConsoleKey.I => LengthUnits.Inch,
        ConsoleKey.F => LengthUnits.Foot,
        ConsoleKey.Y => LengthUnits.Yard,
        ConsoleKey.M => LengthUnits.Mile,
        _ => throw new Exception("Неправильно вибрана одиниця вимірювання"),
    };
}

static Unit ChooseWeightUnit()
{
    Console.WriteLine("Виберіть одиницю вимірювання ");
    Console.Write("P -> фунт, S -> стоун, O -> унція :>");

    var choiceUnit = Console.ReadKey().Key;
    Console.WriteLine();

    return choiceUnit switch
    {
        ConsoleKey.P => WeightUnits.Pound,
        ConsoleKey.S => WeightUnits.Stone,
        ConsoleKey.O => WeightUnits.Ounce,
        _ => throw new Exception("Неправильно вибрана одиниця вимірювання"),
    };
}

static Unit SetUnit(Func<Unit> chooseMethod)
{
    while (true)
    {
        try
        {
            return chooseMethod();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

static double EnterValue()
{
    while (true)
    {
        Console.Write("Введіть значення :>");
        if (double.TryParse(Console.ReadLine()!, out double result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Некоректно введені дані! Введіть ще раз");
        }
    }
}

static IMetricConverter ChooseConverter()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Виберіть конвертер котрий хочете використати");
            Console.Write("L -> LengthConverter \nW -> WeightConverter :>");
            var choiceConverter = Console.ReadKey().Key;
            Console.WriteLine();

            return choiceConverter switch
            {
                ConsoleKey.L => new LengthConverter(),
                ConsoleKey.W => new WeightConverter(),
                _ => throw new Exception("Неправильно вибраний конвертер"),
            };
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

static void ConvertUnit(IMetricConverter converter)
{
    Console.WriteLine("Виберіть у яку систему переводити");
    Console.Write("1 -> В метричну \n2 -> В неметричну :>");

    Unit unit;
    double value;
    Measurement measurement, convertedMeasurement;
    var choiceSystem = Console.ReadKey().Key;
    Console.WriteLine();

    switch ((choiceSystem, converter))
    {
        case (ConsoleKey.D1, LengthConverter):
            Console.WriteLine("Конвертуємо в метричну систему (Довжина)");

            value = EnterValue();
            unit = SetUnit(ChooseLengthUnit);

            measurement = new Length(value, unit);

            convertedMeasurement = converter.ConvertToMetric(measurement);
            Console.WriteLine(convertedMeasurement);
            break;
        case (ConsoleKey.D2, LengthConverter):
            Console.WriteLine("Конвертуємо в неметричну систему (Довжина)");

            value = EnterValue();
            unit = SetUnit(ChooseLengthUnit);

            measurement = new Length(value);

            convertedMeasurement = converter.ConvertFromMetric(measurement, unit);
            Console.WriteLine(convertedMeasurement);
            break;
        case (ConsoleKey.D1, WeightConverter):
            Console.WriteLine("Конвертуємо в метричну систему (Маса)");

            value = EnterValue();
            unit = SetUnit(ChooseWeightUnit);

            measurement = new Weight(value, unit);

            convertedMeasurement = converter.ConvertToMetric(measurement);
            Console.WriteLine(convertedMeasurement);
            break;
        case (ConsoleKey.D2, WeightConverter):
            Console.WriteLine("Конвертуємо в неметричну систему (Маса)");

            value = EnterValue();
            unit = SetUnit(ChooseWeightUnit);

            measurement = new Weight(value);

            convertedMeasurement = converter.ConvertFromMetric(measurement, unit);
            Console.WriteLine(convertedMeasurement);
            break;
        default:
            throw new Exception("Неправильно вибрана дія");
    }
}