
namespace mvc.Models
{
    
    public class Owner
    {
        public string Avatar_url { get; set; }
    }

    public class Items
    {
        public string Name { get; set; }
        public Owner Owner { get; set; }
    }

    public class Repository
    {
        public int Total_count { get; set; }
        public Items[] Items { get; set; }
    }

    public class Search
    {
        public string SearchText { get; set; }

    }
}




