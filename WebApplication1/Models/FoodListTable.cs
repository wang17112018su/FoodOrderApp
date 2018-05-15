namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodListTable")]
    public partial class FoodListTable
    {
        [Key]
        public int OrderNo { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(30)]
        public string Food { get; set; }

        [StringLength(1)]
        public string SizeOfMeal { get; set; }

        [StringLength(1)]
        public string Pepper { get; set; }

        [StringLength(1)]
        public string Chilli { get; set; }

        [StringLength(1)]
        public string Ketchup { get; set; }

        [StringLength(1)]
        public string Tartar { get; set; }
    }
}
