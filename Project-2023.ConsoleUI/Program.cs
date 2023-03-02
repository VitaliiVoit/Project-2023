
using Project_2023.Models;
using Project_2023.Models.Converters;
using Project_2023.Models.Measurements;

Length l1 = new Length(1);
Length l2 = new Length(1.00);

Console.WriteLine(l1.CompareTo(l2));
Console.WriteLine(l1.Equals(l2));
Console.WriteLine(l2.Equals(l1));
Console.ReadLine();