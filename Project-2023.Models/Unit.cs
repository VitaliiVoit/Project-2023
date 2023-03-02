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
    public static Unit Inch => new(nameof(Inch), "in", MeasurementType.Length);
    public static Unit Foot => new(nameof(Foot), "ft", MeasurementType.Length);
    public static Unit Yard => new(nameof(Yard), "yd", MeasurementType.Length);
    public static Unit Mile => new(nameof(Mile), "mi", MeasurementType.Length);
    public static Unit Metre => new(nameof(Metre), "m", MeasurementType.Length);
}

/// <summary>
/// Одиниці вимірювання маси
/// </summary>
public static class WeightUnits
{
    public static Unit Pound => new(nameof(Pound), "lb", MeasurementType.Weigth);
    public static Unit Stone => new(nameof(Stone), "st", MeasurementType.Weigth);
    public static Unit Ounce => new(nameof(Ounce), "oz", MeasurementType.Weigth);
    public static Unit Kilogram => new(nameof(Kilogram), "kg", MeasurementType.Weigth);
}