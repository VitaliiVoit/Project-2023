using Project_2023.Models.Converters;

namespace Project_2023.Models.Measurements;

/// <summary>
/// Довжина
/// </summary>
public sealed class Length : Measurement
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
            UnitValidator.ValidateUnitType(value, MeasurementType.Length);
            _unit = value;
        } 
    }

    public Length(double value)
    {
        Value = value;
        Unit = LengthUnits.Metre;
    }

    public Length(double value, Unit unit)
    {
        Value = value;
        Unit = unit;
    }

    public override int CompareTo(Measurement? other)
    {
        if (other is null) throw new ArgumentNullException(nameof(other), "Об'єкт для порівннян пустий");
        MeasurementValidator.ValidateMeasurementType(other, MeasurementType.Length);
        
        var otherValue = new LengthConverter().ConvertToMetric(other).Value;
        var value = new LengthConverter().ConvertToMetric(this).Value;
        return value.CompareTo(otherValue);
    }

    public override bool Equals(Measurement? other)
    {
        if (other is null) return false;
        MeasurementValidator.ValidateMeasurementType(other, MeasurementType.Length);

        var otherValue = new LengthConverter().ConvertToMetric(other).Value;
        var value = new LengthConverter().ConvertToMetric(this).Value;
        return value.Equals(otherValue);
    }

    public override string ToString()
    {
        return "Length = " + base.ToString();
    }
}
