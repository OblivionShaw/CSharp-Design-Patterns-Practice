public class FilterPatternCriteriaSingle : FilterPatternCriteria
{
    public List<FilterPatternPerson> MeetCriteria(List<FilterPatternPerson> persons)
    {
        var singlePersons = new List<FilterPatternPerson>();
        foreach (var person in persons)
        {
            if (person.GetMaritalStatus().ToUpper() == "SINGLE")
            {
                singlePersons.Add(person);
            }
        }
        return singlePersons;
    }
}
