public class FilterPatternOrCriteria : FilterPatternCriteria
{
    private FilterPatternCriteria criteria;
    private FilterPatternCriteria otherCriteria;

    public FilterPatternOrCriteria(FilterPatternCriteria criteria, FilterPatternCriteria otherCriteria)
    {
        this.criteria = criteria;
        this.otherCriteria = otherCriteria;
    }

    public List<FilterPatternPerson> MeetCriteria(List<FilterPatternPerson> persons)
    {
        var firstCriteriaItems = criteria.MeetCriteria(persons);
        var otherCriteriaItems = otherCriteria.MeetCriteria(persons);

        foreach (var person in otherCriteriaItems)
        {
            if (!firstCriteriaItems.Contains(person))
            {
                firstCriteriaItems.Add(person);
            }
        }
        return firstCriteriaItems;
    }
}
