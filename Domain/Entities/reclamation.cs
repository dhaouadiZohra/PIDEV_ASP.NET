namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevjee.reclamation")]
    public partial class reclamation
    {
        public int id { get; set; }

        public int? etat { get; set; }

        [StringLength(255)]
        public string sujet { get; set; }

        public int? utilisateurs_id { get; set; }

        public virtual user user { get; set; }
    }
}
