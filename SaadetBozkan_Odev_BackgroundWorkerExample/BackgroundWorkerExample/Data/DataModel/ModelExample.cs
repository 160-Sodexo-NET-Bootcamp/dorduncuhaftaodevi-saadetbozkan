using System.ComponentModel.DataAnnotations.Schema;

namespace Data.DataModel
{
    public class ModelExample
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }

    }
}
