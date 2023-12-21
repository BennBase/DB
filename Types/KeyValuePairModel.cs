namespace Types
{
    public class KeyValuePairModel
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public KeyValuePairModel(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
