namespace Project_2023.Models;

public enum MeasurementType
{
    Length, Weigth
}
public record struct Unit(string Name, string Symbol, MeasurementType Measurement);

public static class LengthUnits
{
    public static Unit Inch => new("inch", "in", MeasurementType.Length);
    public static Unit Foot => new("foot", "ft", MeasurementType.Length);
    public static Unit Yard => new("yard", "yd", MeasurementType.Length);
    public static Unit Mile => new("mile", "mi", MeasurementType.Length);
    public static Unit Metre => new("metre", "m", MeasurementType.Length);
}

public static class WeightUnits
{
    public static Unit Pound => new("pound", "lb", MeasurementType.Weigth);
    public static Unit Stones => new("stones", "st", MeasurementType.Weigth);
    public static Unit Ounce => new("ounce", "oz", MeasurementType.Weigth);
    public static Unit Kilogram => new("kilogram", "kg", MeasurementType.Weigth);
}