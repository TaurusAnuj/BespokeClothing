using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Entities
{
    public class tblCodes : CommonEntities
    {
        [Required]
        [MaxLength(10)]
        public string TypeCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MaxLength(50)]
        public string CodeValue { get; set; }
    }
}