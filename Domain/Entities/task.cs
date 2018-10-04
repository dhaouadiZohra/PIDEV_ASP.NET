namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevjee.task")]
    public partial class task
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? deadline { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string state { get; set; }

        public int? alert_id { get; set; }

        public int? user_id { get; set; }

        public virtual alert alert { get; set; }

        public virtual user user { get; set; }
    }
}
