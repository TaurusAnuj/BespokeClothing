using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Entities
{
    public class tblCommunicationTypes : CommonEntities
    {

        [Required]
        [MaxLength(10)]
        public string Code { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Event { get; set; }

        [Required]
        [MaxLength(500)]
        public string Message { get; set; }

        
    }
}
