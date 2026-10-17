namespace Gem.Models
{
    public class Truck : Vechile
    {
        public float BoxVolume { get; set; }
        public static string Manfucturer { get; set; }
        
        public static string Country { get; set; }



        public Truck(string color, string model, float width, float height,
            float length, float maxSpeed, string engine,float BoxVolume) :
            base(color, model, width, height, length, maxSpeed, engine)
        {
            this.BoxVolume = BoxVolume;
        }
        public override string ShowSpecifications(string type)
        {
            return $"{base.ShowSpecifications(type)},{BoxVolume}";
        }

        public static string GreetVisitor()
        {
            return "Welcome to the static method GreetVisitor() from the truck";
        }

        public override string GetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
