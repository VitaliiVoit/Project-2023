﻿using Project_2023.Models.Measurements;

namespace Project_2023.Models.Converters;

/// <summary>
/// Конвертер маси
/// </summary>
public class WeightConverter : IMetricConverter
{
    public Measurement ConvertFromMetric(Measurement measurement, Unit unit)
    {
        MeasurementValidator.ValidateMeasurementType(measurement, MeasurementType.Weigth);
        UnitValidator.ValidateUnitType(unit, MeasurementType.Weigth);

        return unit.Name switch
        {
            "pound" => new Weight(measurement.Value / 0.4536, unit),
            "stone" => new Weight(measurement.Value / 6.3503, unit),
            "ounce" => new Weight(measurement.Value / 0.0283495, unit),
            _ => (Weight)measurement,
        };
    }

    public Measurement ConvertToMetric(Measurement measurement)
    {
        MeasurementValidator.ValidateMeasurementType(measurement, MeasurementType.Weigth);

        return measurement.Unit.Name switch
        {
            "pound" => new Weight(measurement.Value * 0.4536, WeightUnits.Kilogram),
            "stone" => new Weight(measurement.Value * 6.3503, WeightUnits.Kilogram),
            "ounce" => new Weight(measurement.Value * 0.028349, WeightUnits.Kilogram),
            _ => (Weight)measurement,
        };
    }
}