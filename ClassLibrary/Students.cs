using System.Data.Linq.Mapping;

namespace ClassLibrary
{
    [Table]
    public class Students
    {
        [Column]
        public int UserID;
        [Column]
        public string Name;
        [Column]
        public string School;
    }
}
