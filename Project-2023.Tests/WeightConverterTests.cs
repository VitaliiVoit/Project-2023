using Project_2023.Models;
using Project_2023.Models.Converters;
using Project_2023.Models.Measurements;

namespace Project_2023.Tests;

[TestFixture]
public class WeightConverterTests
{
    Weight weight;
    WeightConverter converter;

    [SetUp]
    public void SetUp()
    {
        weight = new Weight(1);
        converter = new WeightConverter();
    }

    [Test]
    public void ConvertKilogramToPound()
    {
        var oneKilogramToPound = 2.2046;

        var result = converter.ConvertFromMetric(weight, WeightUnits.Pound);

        Assert.Multiple(() =>
        {
            Assert.That(result.Unit.Name, Is.EqualTo(WeightUnits.Pound.Name));
            Assert.That($"{result.Value:f4}", Is.EqualTo($"{oneKilogramToPound:f4}"));
        });
    }

    [Test]
    public void ConvertKilogramToStone()
    {
        var oneKilogramToStone = 0.1575;

        var result = converter.ConvertFromMetric(weight, WeightUnits.Stone);

        Assert.Multiple(() =>
        {
            Assert.That(result.Unit.Name, Is.EqualTo(WeightUnits.Stone.Name));
            Assert.That($"{result.Value:f4}", Is.EqualTo($"{oneKilogramToStone:f4}"));
        });
    }

    [Test]
    public void ConvertKilogramToOunce()
    {
        var oneKilogramToOunce = 35.274;

        var result = converter.ConvertFromMetric(weight, WeightUnits.Ounce);

        Assert.Multiple(() =>
        {
            Assert.That(result.Unit.Name, Is.EqualTo(WeightUnits.Ounce.Name));
            Assert.That($"{result.Value:f4}", Is.EqualTo($"{oneKilogramToOunce:f4}"));
        });
    }

    [Test]
    public void ConvertPoundToKilogram()
    {
        var onePoundToKilogram = 0.4536;
        var onePound = new Weight(1, WeightUnits.Pound);

        var result = converter.ConvertToMetric(onePound);

        Assert.Multiple(() =>
        {
            Assert.That(result.Unit.Name, Is.EqualTo(WeightUnits.Kilogram.Name));
            Assert.That($"{result.Value:f4}", Is.EqualTo($"{onePoundToKilogram:f4}"));
        });
    }

    [Test]
    public void ConvertStoneToKilogram()
    {
        var oneStoneToKilogram = 6.3503;
        var oneStone = new Weight(1, WeightUnits.Stone);

        var result = converter.ConvertToMetric(oneStone);

        Assert.Multiple(() =>
        {
            Assert.That(result.Unit.Name, Is.EqualTo(WeightUnits.Kilogram.Name));
            Assert.That($"{result.Value:f4}", Is.EqualTo($"{oneStoneToKilogram:f4}"));
        });
    }

    [Test]
    public void ConvertOunceToKilogram()
    {
        var oneOunceToKilogram = 0.0283;
        var oneOunce = new Weight(1, WeightUnits.Ounce);

        var result = converter.ConvertToMetric(oneOunce);

        Assert.Multiple(() =>
        {
            Assert.That(result.Unit.Name, Is.EqualTo(WeightUnits.Kilogram.Name));
            Assert.That($"{result.Value:f4}", Is.EqualTo($"{oneOunceToKilogram:f4}"));
        });
    }
}
