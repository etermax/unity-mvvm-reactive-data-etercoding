using UnityEngine;

namespace Infrastructure
{
    public class MetricsTagger : IMetricsTagger
    {
        public void TagEvent(string metric)
        {
            Debug.Log($"Tagging '{metric}'");
        }
    }
}