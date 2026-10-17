namespace Gem.Models
{
    public class Bus : Vechile
    {
        public string first;
        private string second;
        protected string third;

        public override string GetDescription()
        {
            return "This is a Bus";
        }
    }
}
