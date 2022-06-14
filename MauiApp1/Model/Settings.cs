using System.Globalization;
using System.Xml.Linq;
namespace MauiApp1.Model
{
    internal static class Settings
    {
        private static string filePath = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.UserProfile),
            "kolory.xml");
        private static IFormatProvider formatProvider =
            CultureInfo.InvariantCulture;

        public static void Save(Color color)
        {
            XDocument xml = new XDocument(
                new XElement("ustawienia",
                    new XElement(
                        "r",
                        color.R.ToString(formatProvider)),
                    new XElement(
                        "g",
                        color.G.ToString(formatProvider)),
                    new XElement(
                        "b",
                        color.B.ToString(formatProvider))
                )
            );
            xml.Save(filePath);
        }
        public static Color Load()
        {
            if (!File.Exists(filePath)) return Color.Black;
            try
            {
                XDocument xml = XDocument.Load(filePath);
                double r = double.Parse(
                    xml.Root.Element("r").Value,
                    formatProvider);
                double g = double.Parse(
                    xml.Root.Element("g").Value,
                    formatProvider);
                double b = double.Parse(
                    xml.Root.Element("b").Value,
                    formatProvider);
                return new Color(r, g, b);
            }
            catch
            {
                return Color.Black;
            }
        }
    }
}