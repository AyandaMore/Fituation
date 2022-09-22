using System.ComponentModel.DataAnnotations;

namespace FituationAPI.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}