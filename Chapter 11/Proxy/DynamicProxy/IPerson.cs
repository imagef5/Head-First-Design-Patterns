namespace DynamicProxy
{
    public interface IPerson
    {
        string Name { get; set; }
        string Gender { get; set; }
        string Interests { get; set; }
        int HotOrNotRating { get; set; }
    }
}