public class ObserverPatternBinaryObserver : ObserverPatternObserver
{
    public ObserverPatternBinaryObserver(ObserverPatternSubject subject)
    {
        this.subject = subject;
        this.subject.Attach(this);
    }

    public override string Update()
    {
        return "Binary String: " + System.Convert.ToString(subject.GetState(), 2);
    }
}
