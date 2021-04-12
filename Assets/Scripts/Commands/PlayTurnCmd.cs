using Infrastructure;
using UniRx;
using ViewModel;

namespace Commands
{
    public class PlayTurnCmd : ICommand
    {
        private readonly CharacterData _characterData;
        private readonly IPlayTurnGateway _playTurnGateway;
        private readonly IMetricsTagger _metricsTagger;

        public PlayTurnCmd(CharacterData characterData, IPlayTurnGateway playTurnGateway, IMetricsTagger metricsTagger)
        {
            _characterData = characterData;
            _playTurnGateway = playTurnGateway;
            _metricsTagger = metricsTagger;
        }

        public void Execute()
        {
            _playTurnGateway.PlayTurn(_characterData.energy.Value)
                .Do(_=> _metricsTagger.TagEvent("Sent energy"))
                .Subscribe();
        }
    }
}