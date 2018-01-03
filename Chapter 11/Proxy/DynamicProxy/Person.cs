namespace DynamicProxy
{
    public class Person : IPerson 
    {
        int rating;
        int ratingCount = 0;

        #region Implement IPerson Interface
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Interests { get; set; }
        public int HotOrNotRating 
        { 
            get 
            {
                return (ratingCount == 0 ) ? 0 : rating / ratingCount;
            } 
            set 
            {
                rating += value;
                ratingCount++;
            }
        }
        #endregion 
    }
}