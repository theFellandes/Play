namespace Play.Common.Settings
{
    public class MongoDbSettings
    {
        //Since we don't want users to change the Host&Port values, we changed set; to init;
        public string Host { get; init; }

        public int Port { get; init; }
        //Expression body definition
        public string ConnectionString => $"mongodb://{Host}:{Port}";
    }
}