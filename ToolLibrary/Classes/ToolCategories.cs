using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary.Classes
{
    class ToolCategories
    {
        string[] tools;

        // displaying tool categories
        public void DisplayToolCategories()
        {
            tools = new string[] { "Gardening tools", "Flooring tools", "Fencing tools", "Measuring tools", "Cleaning tools", "Painting tools", "Electronic tools", "Electricity tools", "Automotive tools" };
            Console.WriteLine("\n=====Tool Categories=====");
            DisplayList(tools);
        }

        // display 1. Gardening Tools
        public void DisplayGardeningTools()
        {
            tools = new string[] { "Line Trimmers", "Lawn Mowers", "Hand Tools", "Wheelbarrows", "Garden Power Tools" };
            DisplayList(tools);
        }

        // display 2. Flooring Tools
        public void DisplayFlooringTools()
        {
            tools = new string[] { "Scrapers", "Floor Lasers", "Floor Levelling Tools", "Floor Levelling Materials", "Floor Hand Tools", "Tiling Tools" };
            DisplayList(tools);
        }

        // display 3. Fencing Tools
        public void DisplayFencingTools()
        {
            tools = new string[] { "Hand Tools", "Electric Fencing", "Steel Fencing Tools", "Power Tools", "Fencing Accessories" };
            DisplayList(tools);
        }

        // display 4. Measuring Tools
        public void DisplayMeasuringTools()
        {
            tools = new string[] { "Distance Tools", "Laser Measurer", "Measuring Jugs", "Temperature & Humidity Tools", "Levelling Tools", "Markers" };
            DisplayList(tools);
        }

        // display 5. Cleaning Tools
        public void DisplayCleaningTools()
        {
            tools = new string[] { "Draining", "Car Cleaning", "Vacuum", "Pressure Cleaning", "Pool Cleaning", "Floor Cleaning" };
            DisplayList(tools);
        }

        // display 6. Painting Tools
        public void DisplayPaintingTools()
        {
            tools = new string[] { "Sanding Tools", "Brushes", "Rollers", "Paint Removal Tools", "Paint Scrapers", "Sprayers" };
            DisplayList(tools);
        }

        // display 7. Electronic Tools
        public void DisplayElectronicTools()
        {
            tools = new string[] { "Voltage Tester", "Oscilloscopes", "Thermal Imaging", "Data Test Tool", "Insulation Testers" };
            DisplayList(tools);
        }

        // display 8. Electricity Tools
        public void DisplayElectricityTools()
        {
            tools = new string[] { "Test Equipment", "Safety Equipment", "Basic Hand Tools", "Circuit Protection", "Cable Tools" };
            DisplayList(tools);
        }

        // display 9. Automotive Tools
        public void DisplayAutomotiveTools()
        {
            tools = new string[] { "Jacks", "Air Compressors", "Battery Chargers", "Socket Tools", "Braking", "Drivetrain" };
            DisplayList(tools);
        }

        void DisplayList(string[] s)
        {
            Console.WriteLine("Select a tool type");
            Console.WriteLine("================================");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i+1, s[i]);
            }
        }
    }
}
