namespace sdc1_knowledge_check2
{
    public class Cat : Animal
    {
        public string? Breed { get; set; }

        public override string ToString()
        {
            return "Cat's Name: " + Name + "; Cat's Breed: " + Breed + "; Cat's Weight: " + Weight + "lbs.";
        }
    }
}