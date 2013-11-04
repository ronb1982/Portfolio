using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SWCGuild.FakeDatabase;

namespace MVCPortfolio.Models.FakeDatabase
{
    // To use our repository, we must have an ID field added by implementing the IDataEntity interface
    public class Book : IDataEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter a title")]
        [DisplayName("Book title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Enter an author")]
        [DisplayName("Author name")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Enter the year of publication")]
        [DisplayName("Year of publication")]
        public string YearPublished { get; set; }

    }
}