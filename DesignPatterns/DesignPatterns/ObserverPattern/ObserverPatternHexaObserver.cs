public class ObserverPatternHexaObserver : ObserverPatternObserver
{
    public ObserverPatternHexaObserver(ObserverPatternSubject subject)
    {
        this.subject = subject;
        this.subject.Attach(this);
    }

    public override string Update()
    {
        return "Hex String: " + System.Convert.ToString(subject.GetState(), 16).ToUpper();
    }
}
