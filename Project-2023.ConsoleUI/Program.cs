using Project_2023.Models;
using Project_2023.Models.Converters;
using Project_2023.Models.Measurements;
using System.Text;

const string lengthUnitsMessage = "I -> дюйми, F -> фути, Y -> Ярди, M -> милі :>";
const string weightUnitsMessage = "P -> фунт, S -> стоун, O -> унція :>";
Console.OutputEncoding = Encoding.UTF8;

ConsoleKey choice;
do
{
    Console.WriteLine("===== Вітаю вас користуваче =====");

    IMetricConverter converter = SetConverter();
    Console.WriteLine("\nВи обрали " + converter.GetType().Name);

    while (true)
    {
        try
        {
            Console.WriteLine(ConvertMeasurement(converter));
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    choice = GetYourChoice("Бажаєте продовжити? Y/N :>");
} while (choice == ConsoleKey.Y);

static ConsoleKey GetYourChoice(string message)
{
    Console.Write(message);
    var key = Console.ReadKey().Key;
    Console.WriteLine();
    return key;
}

static Unit ChooseLengthUnit(ConsoleKey key)
{
    return key switch
    {
        ConsoleKey.I => LengthUnits.Inch,
        ConsoleKey.F => LengthUnits.Foot,
        ConsoleKey.Y => LengthUnits.Yard,
        ConsoleKey.M => LengthUnits.Mile,
        _ => throw new Exception("Неправильно вибрана одиниця вимірювання"),
    };
}

static Unit ChooseWeightUnit(ConsoleKey key)
{
    return key switch
    {
        ConsoleKey.P => WeightUnits.Pound,
        ConsoleKey.S => WeightUnits.Stone,
        ConsoleKey.O => WeightUnits.Ounce,
        _ => throw new Exception("Неправильно вибрана одиниця вимірювання"),
    };
}

static Unit SetUnit(string message, Func<ConsoleKey, Unit> chooseMethod)
{
    while (true)
    {
        Console.WriteLine("Виберіть одиницю вимірювання ");

        var choiceUnit = GetYourChoice(message);
        try
        {
            return chooseMethod(choiceUnit);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

static double EnterMeasurementValue()
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

static IMetricConverter ChooseConverter(ConsoleKey key)
{
    return key switch
    {
        ConsoleKey.L => new LengthConverter(),
        ConsoleKey.W => new WeightConverter(),
        _ => throw new Exception("Неправильно вибраний конвертер"),
    };
}

static IMetricConverter SetConverter()
{
    while (true)
    {
        Console.WriteLine("Виберіть конвертер котрий хочете використати");
        var choiceConverter = GetYourChoice("L -> LengthConverter \nW -> WeightConverter :>");
        try
        {
            return ChooseConverter(choiceConverter);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

static T ConvertToMetric<T>(string message, Func<ConsoleKey, Unit> chooseMethod, IMetricConverter converter) 
    where T : Measurement, new()
{
    var value = EnterMeasurementValue();
    var unit = SetUnit(message, chooseMethod);
    var measurement = new T { Value = value, Unit = unit };

    return (T)converter.ConvertToMetric(measurement);
}

static T ConvertFromMetric<T>(string message, Func<ConsoleKey, Unit> chooseMethod, IMetricConverter converter)
    where T : Measurement, new()
{
    var value = EnterMeasurementValue();
    var unit = SetUnit(message, chooseMethod);
    var measurement = new T { Value = value};

    return (T)converter.ConvertFromMetric(measurement, unit);
}

static Measurement ConvertMeasurement(IMetricConverter converter)
{
    Console.WriteLine("Виберіть у яку систему переводити");
    var choiceSystem = GetYourChoice("1 -> В метричну \n2 -> В неметричну :>");

    switch ((choiceSystem, converter))
    {
        case (ConsoleKey.D1, LengthConverter):
            Console.WriteLine("Конвертуємо в метричну систему (Довжина)");
            return ConvertToMetric<Length>(lengthUnitsMessage, ChooseLengthUnit, converter);
        case (ConsoleKey.D1, WeightConverter):
            Console.WriteLine("Конвертуємо в метричну систему (Маса)");
            return ConvertToMetric<Weight>(weightUnitsMessage, ChooseWeightUnit, converter);
        case (ConsoleKey.D2, LengthConverter):
            Console.WriteLine("Конвертуємо в неметричну систему (Довжина)");
            return ConvertFromMetric<Length>(lengthUnitsMessage, ChooseLengthUnit, converter);
        case (ConsoleKey.D2, WeightConverter):
            Console.WriteLine("Конвертуємо в неметричну систему (Маса)");
            return ConvertFromMetric<Weight>(weightUnitsMessage, ChooseWeightUnit, converter);
        default:
            throw new Exception("Неправильно вибрана дія");
    }
}