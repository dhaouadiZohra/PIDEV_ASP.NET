namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevjee.t_todo")]
    public partial class t_todo
    {
        public int id { get; set; }

        [StringLength(255)]
        public string text { get; set; }
    }
}
