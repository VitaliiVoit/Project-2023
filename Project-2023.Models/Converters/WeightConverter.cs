using Project_2023.Models.Measurements;

namespace Project_2023.Models.Converters;

/// <summary>
/// Конвертер маси
/// </summary>
public class WeightConverter : IMetricConverter
{
    public Measurement ConvertFromMetric(Measurement measurement, Unit unit)
    {
        if (measurement is null) throw new ArgumentNullException(nameof(measurement), "Об'єкт для порівннян пустий");
        MeasurementValidator.ValidateMeasurementType(measurement, MeasurementType.Weigth);
        UnitValidator.ValidateUnitType(unit, MeasurementType.Weigth);
        if (!measurement.Unit.Equals(WeightUnits.Kilogram)) unit = new("N/A", "N/A", MeasurementType.Weigth);
        
        return unit.Name.ToLower() switch
        {
            "pound" => new Weight(measurement.Value / 0.4536, unit),
            "stone" => new Weight(measurement.Value / 6.3503, unit),
            "ounce" => new Weight(measurement.Value / 0.0283495, unit),
            _ => (Weight)measurement,
        };
    }

    public Measurement ConvertToMetric(Measurement measurement)
    {
        if (measurement is null) throw new ArgumentNullException(nameof(measurement), "Об'єкт для порівннян пустий");
        MeasurementValidator.ValidateMeasurementType(measurement, MeasurementType.Weigth);

        return measurement.Unit.Name.ToLower() switch
        {
            "pound" => new Weight(measurement.Value * 0.4536, WeightUnits.Kilogram),
            "stone" => new Weight(measurement.Value * 6.3503, WeightUnits.Kilogram),
            "ounce" => new Weight(measurement.Value * 0.028349, WeightUnits.Kilogram),
            _ => (Weight)measurement,
        };
    }
}
