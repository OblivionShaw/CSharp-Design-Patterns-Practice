public class FilterPatternAndCriteria : FilterPatternCriteria
{
    private FilterPatternCriteria criteria;
    private FilterPatternCriteria otherCriteria;

    public FilterPatternAndCriteria(FilterPatternCriteria criteria, FilterPatternCriteria otherCriteria)
    {
        this.criteria = criteria;
        this.otherCriteria = otherCriteria;
    }

    public List<FilterPatternPerson> MeetCriteria(List<FilterPatternPerson> persons)
    {
        var firstCriteriaPersons = criteria.MeetCriteria(persons);
        return otherCriteria.MeetCriteria(firstCriteriaPersons);
    }
}
