namespace Model
{
    public class CardBasicInformation
    {
        public int ID { get; set; }

        public int Series { get; set; }

        public int Race { get; set; }

        public int Attributes { get; set; }

        public int Stars { get; set; }

        public int MaterialType { get; set; }

        public bool CanLiberate { get; set; }

        public bool CanEvolve { get; set; }
    }
}