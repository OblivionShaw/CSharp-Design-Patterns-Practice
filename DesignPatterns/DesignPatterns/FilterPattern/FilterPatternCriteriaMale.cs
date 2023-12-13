public class FilterPatternCriteriaMale : FilterPatternCriteria
{
    public List<FilterPatternPerson> MeetCriteria(List<FilterPatternPerson> persons)
    {
        var malePersons = new List<FilterPatternPerson>();
        foreach (var person in persons)
        {
            if (person.GetGender().ToUpper() == "MALE")
            {
                malePersons.Add(person);
            }
        }
        return malePersons;
    }
}
