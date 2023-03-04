﻿namespace Project_2023.Models.Measurements;

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
            UnitValidator.ThrowIfNull(value);
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
        UnitValidator.CompareUnits(Unit, other.Unit);

        return Value.CompareTo(other.Value);
    }

    public override bool Equals(Measurement? other)
    {
        if (other is null) throw new ArgumentNullException(nameof(other), "Об'єкт для порівннян пустий");
        MeasurementValidator.ValidateMeasurementType(other, MeasurementType.Length);
        UnitValidator.CompareUnits(Unit, other.Unit);

        return Value.Equals(other.Value);
    }

    public override string ToString()
    {
        return "Length = " + base.ToString();
    }
}
