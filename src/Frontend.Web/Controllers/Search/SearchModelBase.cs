using GwoDb;

public class SearchModelBase
{
    public Message Message;
    public PagerModel Pager { get; set; }
    public string SearchTerm { get; set; }
    public int ResultCount { get; set; }
}