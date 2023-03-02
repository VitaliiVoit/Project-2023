namespace Project_2023.Models.Measurements;

public abstract class Measurement : IEquatable<Measurement>, IComparable<Measurement>
{
    protected double _value;
    protected Unit _unit;

    public abstract double Value { get; set; }

    public abstract Unit Unit { get; init; }

    public abstract int CompareTo(Measurement? other);

    public abstract bool Equals(Measurement? other);

    public override string ToString()
    {
        return $"{Value:f4} {Unit.Symbol} ({Unit.Name})";
    }
}
