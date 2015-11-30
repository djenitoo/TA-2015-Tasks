namespace _6.PhonesTraversal
{
    public class Entry
    {
        public string Name { get; set; }
        public string Town { get; set; }
        public string Tel { get; set; }

        public Entry()
        {
        }

        public Entry(string name, string town, string tel)
        {
            this.Name = name;
            this.Town = town;
            this.Tel = tel;
        }

        public override string ToString()
        {
            return this.Name + "\t | " + this.Town + "\t | " + this.Tel;
        }
    }
}
