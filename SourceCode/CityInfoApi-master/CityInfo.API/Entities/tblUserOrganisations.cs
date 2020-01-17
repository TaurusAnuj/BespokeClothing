using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Entities
{
    public class tblUserOrganisations : CommonEntities
    {
        [Required]
        [ForeignKey("UserID")]
        public tblUsers User { get; set; }
        public int UserID { get; set; }


        [Required]
        [ForeignKey("OrganisationID")]
        public tblOrganisations Organisation { get; set; }
        public int OrganisationID { get; set; }
    }
}
