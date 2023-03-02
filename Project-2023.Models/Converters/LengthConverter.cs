﻿using Project_2023.Models.Measurements;

namespace Project_2023.Models.Converters;

public class LengthConverter : IMetricConverter
{
    public Measurement ConvertFromMetric(Measurement measurement, Unit unit)
    {
        return unit.Name switch
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
        return measurement.Unit.Name switch
        {
            "inch" => new Length(measurement.Value * 0.0254, LengthUnits.Metre),
            "foot" => new Length(measurement.Value * 0.3048, LengthUnits.Metre),
            "yard" => new Length(measurement.Value * 0.9144, LengthUnits.Metre),
            "mile" => new Length(measurement.Value * 1609.344, LengthUnits.Metre),
            _ => (Length)measurement,
        };
    }
}