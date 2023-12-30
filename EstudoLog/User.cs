namespace EstudoLog
{
    public class User
    {
        public User(string name, DateTime lastUpdate)
        {
            Name = name;
            this.lastUpdate = lastUpdate;
        }

        public string Name { get; private set; }
        public DateTime lastUpdate { get; private set; }
    }
}
