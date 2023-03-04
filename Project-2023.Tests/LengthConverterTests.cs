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
            Assert.That(result.Value, Is.EqualTo(oneMetreToInch));
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
            Assert.That(result.Value, Is.EqualTo(oneMetreToFoot));
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
            Assert.That(result.Value, Is.EqualTo(oneMetreToYard));
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
            Assert.That(result.Value, Is.EqualTo(oneMetreToMile));
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
            Assert.That(result.Value, Is.EqualTo(oneInchToMetre));
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
            Assert.That(result.Value, Is.EqualTo(oneFootToMetre));
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
            Assert.That(result.Value, Is.EqualTo(oneYardToMetre));
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
            Assert.That(result.Value, Is.EqualTo(oneMileToMetre));
        });
    }

    [Test]
    public void EqualsTest()
    {
        var oneInch = new Length(1, LengthUnits.Inch);
        var oneInchToMetre = new Length(0.0254);

        var result = oneInch.Equals(oneInchToMetre);
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.True);
            Assert.That(oneInch, Is.EqualTo(oneInchToMetre));
        });
    }

    [Test]
    public void CompareToTest()
    {
        var oneInch = new Length(1, LengthUnits.Inch);
        var oneInchToMetre = new Length(0.0254);

        var result = oneInch.CompareTo(oneInchToMetre);
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EqualTo(0));
            Assert.That(oneInch, Is.EqualTo(oneInchToMetre));
        });
    }

    [Test]
    public void SortTest()
    {
        var oneMetre = new Length(1);
        var oneInch = new Length(1, LengthUnits.Inch);
        var oneFoot = new Length(1, LengthUnits.Foot);
        var oneYard = new Length(1, LengthUnits.Yard);
        var oneMile = new Length(1, LengthUnits.Mile);

        var list = new List<Measurement>()
        {
            oneMile, oneYard, oneInch, oneMetre, oneFoot
        };
        var result = list.Order().ToList();
        var sortedList = new List<Measurement>()
        {
            oneInch, oneFoot, oneYard, oneMetre, oneMile
        };

        Assert.That(result, Is.EqualTo(sortedList));
    }
}
