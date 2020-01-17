using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Entities
{
    public class tblProductPriceSettings
    {
        [Required]
        [ForeignKey("ProductID")]
        public tblProducts Product { get; set; }
        public int ProductID { get; set; }

        [Required]
        [ForeignKey("OrganisationID")]
        public tblOrganisations Organisation { get; set; }
        public int OrganisationID { get; set; }

        public float StichingPrice { get; set; }
    }
}
