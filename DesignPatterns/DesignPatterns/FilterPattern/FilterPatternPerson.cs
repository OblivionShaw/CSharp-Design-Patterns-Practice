public class FilterPatternPerson
{
    private string name;
    private string gender;
    private string maritalStatus;

    public FilterPatternPerson(string name, string gender, string maritalStatus)
    {
        this.name = name;
        this.gender = gender;
        this.maritalStatus = maritalStatus;
    }

    public string GetName()
    {
        return name;
    }
    public string GetGender()
    {
        return gender;
    }
    public string GetMaritalStatus()
    {
        return maritalStatus;
    }
}
