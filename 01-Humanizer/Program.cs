using System.Globalization;
using Humanizer;

Console.WriteLine("URL GitHub");
Console.WriteLine("https://github.com/Humanizr/Humanizer \n\n");

var quantitySingular = "peso".ToQuantity(1, "C2", new CultureInfo("es-MX"));
Console.WriteLine("Quantity singular");
Console.WriteLine($"{quantitySingular}\n");

var quantityPlural = "peso".ToQuantity(2, "C2", new CultureInfo("es-MX"));
Console.WriteLine("Quantity plural");
Console.WriteLine($"{quantityPlural}\n");

var numberToWords = 1500555.ToWords(new CultureInfo("es-MX"));
Console.WriteLine("Numbet to words");
Console.WriteLine($"1500555 => {numberToWords}\n");

Console.WriteLine($"{1.ToWords(GrammaticalGender.Feminine, new CultureInfo("es-MX"))}\n");

Console.WriteLine("Number to ordinal words");
Console.WriteLine($"{11.ToOrdinalWords(new CultureInfo("es-MX"))}");
Console.WriteLine($"{11.ToOrdinalWords(GrammaticalGender.Feminine, new CultureInfo("es-MX"))}\n");

Console.WriteLine("DateTime to ordinal words");
Console.WriteLine($"{new DateTime(2021, 10, 10).ToOrdinalWords(GrammaticalCase.Instrumental)}");