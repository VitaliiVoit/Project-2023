namespace Project_2023.Models.Measurements;

/// <summary>
/// Вимірювання
/// </summary>
public abstract class Measurement : IEquatable<Measurement>, IComparable<Measurement>
{
    protected double _value;
    protected Unit? _unit;
    
    /// <summary>
    /// Значення
    /// </summary>
    public abstract double Value { get; set; }

    /// <summary>
    /// Одиниця вимірювання
    /// </summary>
    public abstract Unit Unit { get; init; }

    public abstract int CompareTo(Measurement? other);

    public abstract bool Equals(Measurement? other);

    public override string ToString()
    {
        return $"{Value:f4} {Unit.Symbol} ({Unit.Name})";
    }
}
