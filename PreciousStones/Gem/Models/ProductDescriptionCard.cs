namespace Gem
{
    // A struct cannot inherit or be inherited
    // Use struct with lightweight short-lived objects
    public struct ProductDescriptionCard
    {
        public ProductDescriptionCard(string name, byte size, string color)
        {
            Name = name;
            Size = size;
            Color = color;
        }

        public string Name { get; set; }
        public byte Size { get; set; }
        public string Color { get; set; }

        public void showdescription()
        {
            Console.WriteLine($"Name\t: {Name} \nSize\t:" +
            $"{Size} \nColor\t:{Color}");
        }
    }
}
