namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YesNo")]
    public partial class YesNo
    {
        [StringLength(1)]
        public string ID { get; set; }

        [StringLength(3)]
        public string Description { get; set; }
    }
}
