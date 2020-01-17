using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Entities
{
    public class tblOrganisationSettings : CommonEntities
    {
        [Required]
        [ForeignKey("OrganisationID")]
        public tblOrganisations Organisation { get; set; }
        public int OrganisationID { get; set; }


        [Required]
        [ForeignKey("ParentOrganisationSettingID")]
        public tblOrganisationSettings ParentOrganisationSetting { get; set; }
        public int ParentOrganisationSettingID { get; set; }
    }
}
