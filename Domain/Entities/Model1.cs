namespace Domain.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<alert> alert { get; set; }
        public virtual DbSet<archivage> archivage { get; set; }
        public virtual DbSet<comment> comment { get; set; }
        public virtual DbSet<conger> conger { get; set; }
        public virtual DbSet<document> document { get; set; }
        public virtual DbSet<evenement> evenement { get; set; }
        public virtual DbSet<mail> mail { get; set; }
        public virtual DbSet<participate> participate { get; set; }
        public virtual DbSet<reclamation> reclamation { get; set; }
        public virtual DbSet<t_todo> t_todo { get; set; }
        public virtual DbSet<task> task { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<alert>()
                .Property(e => e.alertcontext)
                .IsUnicode(false);

            modelBuilder.Entity<alert>()
                .HasMany(e => e.task)
                .WithOptional(e => e.alert)
                .HasForeignKey(e => e.alert_id);

            modelBuilder.Entity<archivage>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<archivage>()
                .Property(e => e.path)
                .IsUnicode(false);

            modelBuilder.Entity<archivage>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<comment>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<conger>()
                .Property(e => e.motif)
                .IsUnicode(false);

            modelBuilder.Entity<conger>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<conger>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<document>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<document>()
                .Property(e => e.path)
                .IsUnicode(false);

            modelBuilder.Entity<document>()
                .HasMany(e => e.comment)
                .WithOptional(e => e.document)
                .HasForeignKey(e => e.documment_id);

            modelBuilder.Entity<evenement>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.localisation)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.titre)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .HasMany(e => e.participate)
                .WithRequired(e => e.evenement)
                .HasForeignKey(e => e.idevent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<evenement>()
                .HasMany(e => e.user)
                .WithMany(e => e.evenement)
                .Map(m => m.ToTable("evenement_user").MapLeftKey("events_id"));

            modelBuilder.Entity<mail>()
                .Property(e => e.context)
                .IsUnicode(false);

            modelBuilder.Entity<mail>()
                .Property(e => e.path)
                .IsUnicode(false);

            modelBuilder.Entity<mail>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.sujet)
                .IsUnicode(false);

            modelBuilder.Entity<t_todo>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<task>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<task>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<task>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.cin)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.sexe)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.archivage)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.comment)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.utilisateur_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.conger)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.u_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.document)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.mail)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.receiver_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.mail1)
                .WithOptional(e => e.user1)
                .HasForeignKey(e => e.sender_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.participate)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.iduser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.reclamation)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.utilisateurs_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.task)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.user_id);
        }
    }
}
