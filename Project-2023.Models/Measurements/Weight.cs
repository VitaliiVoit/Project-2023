namespace Project_2023.Models.Measurements;

/// <summary>
/// Маса
/// </summary>
public sealed class Weight : Measurement
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
        get => _unit;
        init
        {
            UnitValidator.ValidateUnitType(value, MeasurementType.Weigth);
            _unit = value;
        }
    }

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
        if (other is null) throw new ArgumentNullException("Об'єкт для порівннян пустий");
        MeasurementValidator.ValidateMeasurementType(other, MeasurementType.Weigth);
        UnitValidator.CompareUnits(Unit, other.Unit);

        return Value.CompareTo(other.Value);
    }

    public override bool Equals(Measurement? other)
    {
        if (other is null) throw new ArgumentNullException("Об'єкт для порівннян пустий");
        MeasurementValidator.ValidateMeasurementType(other, MeasurementType.Weigth);
        UnitValidator.CompareUnits(Unit, other.Unit);

        return Value.Equals(other.Value);
    }

    public override string ToString()
    {
        return "Weight = " + base.ToString();
    }
}
