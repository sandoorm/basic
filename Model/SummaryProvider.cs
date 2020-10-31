namespace basic.Model
{
    public class SummaryProvider : ISummaryProvider
    {
        public string[] GetSummaries()
        {
            return new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };
        }
    }
}