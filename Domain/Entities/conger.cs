namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevjee.conger")]
    public partial class conger
    {
        public int id { get; set; }

        public int duree { get; set; }

        public DateTime? fromdate { get; set; }

        [StringLength(255)]
        public string motif { get; set; }

        [StringLength(255)]
        public string state { get; set; }

        public DateTime? todate { get; set; }

        [StringLength(255)]
        public string type { get; set; }

        public int? u_id { get; set; }

        public virtual user user { get; set; }
    }
}
