using System.Collections.Generic;

public class ObserverPatternSubject
{
    private List<ObserverPatternObserver> observers = new List<ObserverPatternObserver>();
    private int state;

    public int GetState()
    {
        return state;
    }

    public void SetState(int state)
    {
        this.state = state;
        NotifyAllObservers();
    }

    public void Attach(ObserverPatternObserver observer)
    {
        observers.Add(observer);
    }

    public void NotifyAllObservers()
    {
        foreach (ObserverPatternObserver observer in observers)
        {
            observer.Update();
        }
    }
}
