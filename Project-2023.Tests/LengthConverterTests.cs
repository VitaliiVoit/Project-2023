using Project_2023.Models;
using Project_2023.Models.Converters;
using Project_2023.Models.Measurements;

namespace Project_2023.Tests;

[TestFixture]
public class LengthConverterTests
{
    Length length;
    LengthConverter converter;
    
    [SetUp]
    public void SetUp()
    {
        length = new Length(1);
        converter = new LengthConverter();
    }

    [Test]
    public void ConvertMetreToInch()
    {
        var oneMetreToInch = 39.3701;

        var result = converter.ConvertFromMetric(length, LengthUnits.Inch);
        Assert.Multiple(() =>
        {
            Assert.That(result.Unit.Name, Is.EqualTo(LengthUnits.Inch.Name));
            Assert.That($"{result.Value:f4}", Is.EqualTo($"{oneMetreToInch:f4}"));
        });
    }

    [Test]
    public void ConvertMetreToFoot()
    {
        var oneMetreToFoot = 3.2808;

        var result = converter.ConvertFromMetric(length, LengthUnits.Foot);

        Assert.Multiple(() =>
        {
            Assert.That(result.Unit.Name, Is.EqualTo(LengthUnits.Foot.Name));
            Assert.That($"{result.Value:f4}", Is.EqualTo($"{oneMetreToFoot:f4}"));
        });
    }

    [Test]
    public void ConvertMetreToYard()
    {
        var oneMetreToYard = 1.0936;

        var result = converter.ConvertFromMetric(length, LengthUnits.Yard);

        Assert.Multiple(() =>
        {
            Assert.That(result.Unit.Name, Is.EqualTo(LengthUnits.Yard.Name));
            Assert.That($"{result.Value:f4}", Is.EqualTo($"{oneMetreToYard:f4}"));
        });
    }

    [Test]
    public void ConvertMetreToMile()
    {
        var oneMetreToMile = 0.0006;

        var result = converter.ConvertFromMetric(length, LengthUnits.Mile);

        Assert.Multiple(() =>
        {
            Assert.That(result.Unit.Name, Is.EqualTo(LengthUnits.Mile.Name));
            Assert.That($"{result.Value:f4}", Is.EqualTo($"{oneMetreToMile:f4}"));
        });
    }

    [Test]
    public void ConvertInchToMetre()
    {
        var oneInchToMetre = 0.0254;
        var oneInch = new Length(1, LengthUnits.Inch);

        var result = converter.ConvertToMetric(oneInch);

        Assert.Multiple(() =>
        {
            Assert.That(result.Unit.Name, Is.EqualTo(LengthUnits.Metre.Name));
            Assert.That($"{result.Value:f4}", Is.EqualTo($"{oneInchToMetre:f4}"));
        });
    }

    [Test]
    public void ConvertFootToMetre()
    {
        var oneFootToMetre = 0.3048;
        var oneFoot =  new Length(1, LengthUnits.Foot);

        var result = converter.ConvertToMetric(oneFoot);

        Assert.Multiple(() =>
        {
            Assert.That(result.Unit.Name, Is.EqualTo(LengthUnits.Metre.Name));
            Assert.That($"{result.Value:f4}", Is.EqualTo($"{oneFootToMetre:f4}"));
        });
    }

    [Test]
    public void ConvertYardToMetre()
    {
        var oneYardToMetre = 0.9144;
        var oneYard = new Length(1, LengthUnits.Yard);

        var result = converter.ConvertToMetric(oneYard);

        Assert.Multiple(() =>
        {
            Assert.That(result.Unit.Name, Is.EqualTo(LengthUnits.Metre.Name));
            Assert.That($"{result.Value:f4}", Is.EqualTo($"{oneYardToMetre:f4}"));
        });
    }

    [Test]
    public void ConvertMileToMetre()
    {
        var oneMileToMetre = 1609.344;
        var oneMile = new Length(1, LengthUnits.Mile);

        var result = converter.ConvertToMetric(oneMile);

        Assert.Multiple(() =>
        {
            Assert.That(result.Unit.Name, Is.EqualTo(LengthUnits.Metre.Name));
            Assert.That($"{result.Value:f4}", Is.EqualTo($"{oneMileToMetre:f4}"));
        });
    }
}
