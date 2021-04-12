using System;
using UniRx;
using UnityEngine;

namespace Infrastructure
{
    public class PlayTurnGateway : IPlayTurnGateway
    {
        public IObservable<Unit> PlayTurn(int energyRemaining)
        {
            return Observable.Return(Unit.Default)
                .Delay(TimeSpan.FromSeconds(1))
                .Do(_ => Debug.Log($"Sending to server remaining energy {energyRemaining}"));
        }
    }
}