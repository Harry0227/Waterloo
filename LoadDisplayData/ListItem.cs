namespace LoadDisplayData
{
    internal class ListItem
    {
        private string v1;
        private string v2;

        public ListItem(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        
    }

    public class IdName
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IdName(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
