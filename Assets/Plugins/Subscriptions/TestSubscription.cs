using System;
using NSubstitute;
using UniRx;

namespace Etermax.Observables{
	public static class ObservableTestExtensions{
		public static TestSubscription<T> Test<T>(this IObservable<T> observable){
			return new TestSubscription<T>(observable);
		}
	}

	public class TestSubscription<T>{
		private readonly IObservable<T> _sourceObservable;
		private readonly IObserver<T> _testObserver;

		public TestSubscription(IObservable<T> sourceObservable){
			_sourceObservable = sourceObservable;
			_testObserver = Substitute.For<IObserver<T>>();
			_sourceObservable.Subscribe(_testObserver);
		}

		public TestSubscription<T> AssertValue(T value){
			_testObserver.Received().OnNext(value);
			return this;
		}

		public TestSubscription<T> AssertValue(Predicate<T> predicate){
			_testObserver.Received().OnNext(Arg.Is<T>(value => predicate(value)));
			return this;
		}

		public TestSubscription<T> AssertComplete(){
			_testObserver.Received().OnCompleted();
			return this;
		}

		public TestSubscription<T> AssertException(Exception e){
			_testObserver.Received().OnError(e);
			return this;
		}

		public TestSubscription<T> AssertNoErrors(){
			_testObserver.DidNotReceive().OnError(Arg.Any<Exception>());
			return this;
		}

		public TestSubscription<T> AssertNotCompleted(){
			_testObserver.DidNotReceive().OnCompleted();
			return this;
		}

		public TestSubscription<T> AssertError(){
			_testObserver.Received().OnError(Arg.Any<Exception>());
			return this;
		}

		public TestSubscription<T> AssertError<U>() where U : Exception{
			_testObserver.Received().OnError(Arg.Is<Exception>(error => error is U));
			return this;
		}

		public TestSubscription<T> AssertNoOnNext(){
			_testObserver.DidNotReceive().OnNext(Arg.Any<T>());
			return this;
		}
	}
}