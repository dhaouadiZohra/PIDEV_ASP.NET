namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevjee.comment")]
    public partial class comment
    {
        public int id { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public DateTime? postdate { get; set; }

        public int? documment_id { get; set; }

        public int? utilisateur_id { get; set; }

        public virtual user user { get; set; }

        public virtual document document { get; set; }
    }
}
