using Project_2023.Models.Measurements;

namespace Project_2023.Models.Converters;

public interface IMetricConverter
{
    Measurement ConvertFromMetric(Measurement measurement, Unit unit);

    Measurement ConvertToMetric(Measurement measurement);
}
