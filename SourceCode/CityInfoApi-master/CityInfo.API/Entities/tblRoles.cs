using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Entities
{
    public class tblRoles : CommonEntities
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}