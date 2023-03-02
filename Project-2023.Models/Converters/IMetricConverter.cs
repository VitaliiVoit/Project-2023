using Project_2023.Models.Measurements;

namespace Project_2023.Models.Converters;

public interface IMetricConverter
{
    /// <summary>
    /// Конвертує з метричної системи
    /// </summary>
    /// <param name="measurement"> Вимірювання котре конвертуємо </param>
    /// <param name="unit"> Одиниця вимірювання в котру конвертуємо </param>
    /// <returns> Вимірювання в котре конвертували </returns>
    Measurement ConvertFromMetric(Measurement measurement, Unit unit);

    /// <summary>
    /// Конвертуємо в метричну систему
    /// </summary>
    /// <param name="measurement"> Вимірювання котре конвертуємо </param>
    /// <returns> Вимірювання в котре конвертували </returns>
    Measurement ConvertToMetric(Measurement measurement);
}
