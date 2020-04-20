namespace ClassLibrary1
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Tests")]
    public abstract class TestClassBase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}