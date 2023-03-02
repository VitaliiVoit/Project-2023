
using Project_2023.Models;
using Project_2023.Models.Converters;
using Project_2023.Models.Measurements;

Length l1 = new Length(1);
Weight l2 = new Weight(1.00);

var lengthConverter = new LengthConverter();
var weightConverter = new WeightConverter();
weightConverter.ConvertToMetric(l1);


Console.ReadLine();