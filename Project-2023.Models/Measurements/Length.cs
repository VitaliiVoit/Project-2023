namespace Project_2023.Models.Measurements;

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
        get => _unit;
        init
        {
            if (MeasurementType.Length != value.Measurement)
            {
                throw new ArgumentException("Об'єкт одиниці вимірювання не може бути пустим або іншим");
            }
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
        if (other is null) throw new ArgumentNullException("Об'єкт для порівннян пустий");
        if (other.Unit.Measurement != MeasurementType.Length)
        {
            throw new ArgumentException("Не можна порівняти між собою дві різні фізичні велечини");
        }
        if (!string.Equals(Unit.Name, other.Unit.Name, StringComparison.OrdinalIgnoreCase))
        {
            throw new ArithmeticException("Не можна порівняти між собою різні одиниці вимірювання");
        }

        return Value.CompareTo(other.Value);
    }

    public override bool Equals(Measurement? other)
    {
        if (other is null) throw new ArgumentNullException("Об'єкт для порівннян пустий");
        if (other.Unit.Measurement != MeasurementType.Length)
        {
            throw new ArgumentException("Не можна порівняти між собою дві різні фізичні велечини");
        }
        if (!string.Equals(Unit.Name, other.Unit.Name, StringComparison.OrdinalIgnoreCase))
        {
            throw new ArithmeticException("Не можна порівняти між собою різні одиниці вимірювання");
        }

        return Value.Equals(other.Value);
    }

    public override string ToString()
    {
        return "Length = " + base.ToString();
    }
}
