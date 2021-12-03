namespace Design_Patterns_Assignment.Repository
{
    public interface IDbContext
    {
        public string Name { get; set; }
        string Load(string v);
        void Save(string data);
    }
}