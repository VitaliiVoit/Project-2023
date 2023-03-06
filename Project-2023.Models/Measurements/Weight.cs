using Project_2023.Models.Converters;

namespace Project_2023.Models.Measurements;

/// <summary>
/// Маса
/// </summary>
public class Weight : Measurement
{
    public override double Value
    {
        get => _value;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Довжина не може бути від'ємною");
            }
            _value = value;
        }
    }
    public override Unit Unit
    {
        get => _unit!;
        init
        {
            UnitValidator.ValidateUnitType(value, MeasurementType.Weigth);
            _unit = value;
        }
    }

    public Weight() => Unit = WeightUnits.Kilogram;

    public Weight(double value)
    {
        Value = value;
        Unit = WeightUnits.Kilogram;
    }

    public Weight(double value, Unit unit)
    {
        Value = value;
        Unit = unit;
    }

    public override int CompareTo(Measurement? other)
    {
        if (other is null) throw new ArgumentNullException(nameof(other), "Об'єкт для порівняння пустий");
        MeasurementValidator.ValidateMeasurementType(other, MeasurementType.Weigth);
        
        var otherValue = new WeightConverter().ConvertToMetric(other).Value;
        var value = new WeightConverter().ConvertToMetric(this).Value;
        return value.CompareTo(otherValue);
    }

    public override bool Equals(Measurement? other)
    {
        if (other is null) return false;
        MeasurementValidator.ValidateMeasurementType(other, MeasurementType.Weigth);
        
        var otherValue = new WeightConverter().ConvertToMetric(other).Value;
        var value = new WeightConverter().ConvertToMetric(this).Value;
        return value.Equals(otherValue);
    }

    public override string ToString()
    {
        return "Weight = " + base.ToString();
    }
}
