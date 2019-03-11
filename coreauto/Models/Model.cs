namespace coreauto.Models
{
    public class Model
    {
        public int Int { get; set; }
        public int Name { get; set; }
        public Make Make { get; set; } //navigation property to make sure both make and model point back to each other. 
        public int MakeId { get; set; } //FK property association.
    }
}
