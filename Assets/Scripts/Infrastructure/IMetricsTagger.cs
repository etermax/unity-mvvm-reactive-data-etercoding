namespace Infrastructure
{
    public interface IMetricsTagger
    {
        void TagEvent(string metric);
    }
}