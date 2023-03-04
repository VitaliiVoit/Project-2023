using Project_2023.Models.Measurements;

namespace Project_2023.Models.Converters;

/// <summary>
/// Конвертер довжини
/// </summary>
public class LengthConverter : IMetricConverter
{
    public Measurement ConvertFromMetric(Measurement measurement, Unit unit)
    {
        if (measurement is null) throw new ArgumentNullException(nameof(measurement), "Об'єкт для порівннян пустий");
        MeasurementValidator.ValidateMeasurementType(measurement, MeasurementType.Length);
        UnitValidator.ThrowIfNull(unit);
        UnitValidator.ValidateUnitType(unit, MeasurementType.Length);
        if (!measurement.Unit.Equals(LengthUnits.Metre)) unit = new("N/A", "N/A", MeasurementType.Length);
        
        return unit.Name.ToLower() switch
        {
            "inch" => new Length(measurement.Value / 0.0254, unit),
            "foot" => new Length(measurement.Value / 0.3048, unit),
            "yard" => new Length(measurement.Value / 0.9144, unit),
            "mile" => new Length(measurement.Value / 1609.344, unit),
            _ => (Length)measurement,
        };
    }

    public Measurement ConvertToMetric(Measurement measurement)
    {
        if (measurement  is null) throw new ArgumentNullException(nameof(measurement), "Об'єкт для порівннян пустий");
        MeasurementValidator.ValidateMeasurementType(measurement, MeasurementType.Length);

        return measurement.Unit.Name.ToLower() switch
        {
            "inch" => new Length(measurement.Value * 0.0254, LengthUnits.Metre),
            "foot" => new Length(measurement.Value * 0.3048, LengthUnits.Metre),
            "yard" => new Length(measurement.Value * 0.9144, LengthUnits.Metre),
            "mile" => new Length(measurement.Value * 1609.344, LengthUnits.Metre),
            _ => (Length)measurement,
        };
    }
}
