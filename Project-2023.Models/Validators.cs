using Project_2023.Models.Measurements;

namespace Project_2023.Models;

/// <summary>
/// Перевірки для вимірювання
/// </summary>
public static class MeasurementValidator
{
    /// <summary>
    /// Перевіряє чи одиниця вимірювання відповідає вказаному типу вимірювання
    /// </summary>
    /// <param name="measurement"> Вимірювання </param>
    /// <param name="type"> Тип вимірювання </param>
    /// <exception cref="ArgumentException"></exception>
    public static void ValidateMeasurementType(Measurement measurement, MeasurementType type)
    {
        if (measurement.Unit.Measurement != type)
        {
            throw new ArgumentException("Не можна порівняти між собою дві різні фізичні велечини");
        }
    }
}

/// <summary>
/// Перевірки для одиниці вимірювання
/// </summary>
public static class UnitValidator
{
    /// <summary>
    /// Перевіряє чи одиниця вимірювання відповідає вказаному типу вимірювання
    /// </summary>
    /// <param name="unit"> Одиниця вимірювання </param>
    /// <param name="type"> Тип вимірювання </param>
    /// <exception cref="ArgumentException"></exception>
    public static void ValidateUnitType(Unit unit, MeasurementType type)
    {
        if (unit.Measurement != type)
        {
            throw new ArgumentException("Не можна визначати інші одиниці вимірювання чужої величини");
        }
    }

    /// <summary>
    /// Перевіряє чи одиниця вимірювання пуста
    /// </summary>
    /// <param name="unit"> Одиниця вимірювання </param>
    /// <exception cref="ArgumentException"></exception>
    public static void ThrowIfNull(Unit unit)
    {
        if (unit is null)
        {
            throw new ArgumentException("Одиниця вимірювання пуста");
        }
    }
}

