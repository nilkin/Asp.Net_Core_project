using System.ComponentModel.DataAnnotations.Schema;


namespace CorporX.Models
{
    public class ContentEntity
    {
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Name { get; set; }
        public string Content { get; set; }

    }
}
