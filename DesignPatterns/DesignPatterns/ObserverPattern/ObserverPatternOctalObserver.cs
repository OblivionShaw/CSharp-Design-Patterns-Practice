public class ObserverPatternOctalObserver : ObserverPatternObserver
{
    public ObserverPatternOctalObserver(ObserverPatternSubject subject)
    {
        this.subject = subject;
        this.subject.Attach(this);
    }

    public override string Update()
    {
        return "Octal String: " + System.Convert.ToString(subject.GetState(), 8);
    }
}
