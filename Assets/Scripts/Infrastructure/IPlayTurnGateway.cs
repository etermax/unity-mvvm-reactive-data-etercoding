using System;
using UniRx;

namespace Infrastructure
{
    public interface IPlayTurnGateway
    {
        IObservable<Unit> PlayTurn(int energyRemaining);
    }
}