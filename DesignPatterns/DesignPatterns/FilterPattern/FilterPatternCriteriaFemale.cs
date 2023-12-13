public class FilterPatternCriteriaFemale : FilterPatternCriteria
{
    public List<FilterPatternPerson> MeetCriteria(List<FilterPatternPerson> persons)
    {
        var femalePersons = new List<FilterPatternPerson>();
        foreach (var person in persons)
        {
            if (person.GetGender().ToUpper() == "FEMALE")
            {
                femalePersons.Add(person);
            }
        }
        return femalePersons;
    }
}
