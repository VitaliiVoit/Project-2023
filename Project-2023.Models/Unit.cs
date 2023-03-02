namespace Project_2023.Models;

/// <summary>
/// Тип вимірювання
/// </summary>
public enum MeasurementType
{
    Length,
    Weigth
}

/// <summary>
/// Одиниця вимірювання
/// </summary>
/// <param name="Name"> Назва одиниці </param>
/// <param name="Symbol"> Символ одиниці </param>
/// <param name="Measurement"> Вимірювання </param>
public record struct Unit(string Name, string Symbol, MeasurementType Measurement);

/// <summary>
/// Одиниці вимірювання довжини
/// </summary>
public static class LengthUnits
{
    public static Unit Inch => new(nameof(Inch).ToLower(), "in", MeasurementType.Length);
    public static Unit Foot => new(nameof(Foot).ToLower(), "ft", MeasurementType.Length);
    public static Unit Yard => new(nameof(Yard).ToLower(), "yd", MeasurementType.Length);
    public static Unit Mile => new(nameof(Mile).ToLower(), "mi", MeasurementType.Length);
    public static Unit Metre => new(nameof(Metre).ToLower(), "m", MeasurementType.Length);
}

/// <summary>
/// Одиниці вимірювання маси
/// </summary>
public static class WeightUnits
{
    public static Unit Pound => new(nameof(Pound).ToLower(), "lb", MeasurementType.Weigth);
    public static Unit Stone => new(nameof(Stone).ToLower(), "st", MeasurementType.Weigth);
    public static Unit Ounce => new(nameof(Ounce).ToLower(), "oz", MeasurementType.Weigth);
    public static Unit Kilogram => new(nameof(Kilogram).ToLower(), "kg", MeasurementType.Weigth);
}