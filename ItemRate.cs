namespace DataGridFormatting
{
    public class ItemRate
    {
        public ItemRate(string item, double rate)
        {
            Item = item;
            Rate = rate;
        }

        public string Item { get; set; }

        public double Rate { get; set; }
    }
}
