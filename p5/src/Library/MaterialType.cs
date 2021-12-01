namespace Ucu.Poo.Defense
{
    public class MaterialType
    {
        public string Name { get; set; }

        public MaterialType(string name)
        {
            this.Name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            return this.Name.Equals(((MaterialType)obj).Name);
        }
    }
}