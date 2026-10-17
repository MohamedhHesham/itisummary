namespace Gem.Models
{
    public abstract class Vechile
    {
        private string color;

        public Vechile()
        {
            Console.WriteLine("This is non parametrized constructor! ");
        }
        public Vechile(string color, string model, float width, float height, float length, float maxSpeed, string engine)
        {
            Color = color;
            Model = model;
            Width = width;
            Height = height;
            Length = length;
            MaxSpeed = maxSpeed;
            Engine = engine;
        }

        public string Model { get; set; }

        public float Width { get; set; }

        public float Height { get; set; }

        public float Length { get; set; }

        public float MaxSpeed { get; set; }

        public string Engine { get; set; }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value.ToLower() != "yellow")
                {
                    color = value;
                }
                else
                {
                    Console.WriteLine("Color cannot be yellow");
                }
            }
        }

        public virtual string ShowSpecifications(string type)
        {
            if (type == "full")
            {
               return $"{Color}, {Model}, {Width}, {Height}, {Length}, {MaxSpeed}, {Engine}";
            }
            else if (type == "brief")
            {
                return $"{Color}, {Model}";
            }
            else
            {
                return "Invalid type";
            }
        }

        public string ShowSpecifications()
        {
            return $"{Color}, {Model}, {Width}, {Height}, {Length}";
        }
        public abstract string GetDescription();

    }
}
