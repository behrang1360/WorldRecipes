namespace WorldRecipes.Models
{
    public class UserAccess
    {
        public int UasrAccessId { get; set; }
        public bool CanAdd { get; set; }
        public bool CanEdit { get; set; }
        public bool CanView { get; set; }
      
    }
}