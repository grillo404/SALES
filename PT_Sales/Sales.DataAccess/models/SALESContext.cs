using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Sales.DataAccess.models
{
    public partial class SALESContext : DbContext
    {

        public SALESContext(DbContextOptions<SALESContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=LAPTOP-QTNUI3UK;Initial Catalog=SALES;Integrated Security=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("PK__CLIENT__5556D89B613912CB");

                entity.ToTable("CLIENT");

                entity.Property(e => e.IdClient).HasColumnName("ID_CLIENT");

                entity.Property(e => e.DateBirth)
                    .HasColumnType("date")
                    .HasColumnName("dateBirth");

                entity.Property(e => e.DeleteClient).HasColumnName("deleteClient");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("emailAddress");

                entity.Property(e => e.FirstNameClient)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("firstNameClient");

                entity.Property(e => e.IdentificationClient)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("identificationClient");

                entity.Property(e => e.LastModifiet)
                    .HasColumnType("datetime")
                    .HasColumnName("lastModifiet");

                entity.Property(e => e.LastNameClient)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("lastNameCLient");

                entity.Property(e => e.NumberPhone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("numberPhone");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.IdInvoice)
                    .HasName("PK__INVOICE__1B08B1D49EA1329D");

                entity.ToTable("INVOICE");

                entity.Property(e => e.IdInvoice).HasColumnName("ID_INVOICE");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.DeleteInvoice).HasColumnName("deleteInvoice");

                entity.Property(e => e.LastModifiet)
                    .HasColumnType("datetime")
                    .HasColumnName("lastModifiet");

                entity.Property(e => e.SaleDate)
                    .HasColumnType("datetime")
                    .HasColumnName("saleDate");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct)
                    .HasName("PK__PRODUCT__69B20C205A342CE7");

                entity.ToTable("PRODUCT");

                entity.Property(e => e.IdProduct).HasColumnName("ID_PRODUCT");

                entity.Property(e => e.DeleteProduct).HasColumnName("deleteProduct");

                entity.Property(e => e.LastModifiet)
                    .HasColumnType("datetime")
                    .HasColumnName("lastModifiet");

                entity.Property(e => e.NameProduct)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nameProduct");

                entity.Property(e => e.PriceProduct).HasColumnName("priceProduct");

                entity.Property(e => e.ProductActive).HasColumnName("productActive");

                entity.Property(e => e.StorageProduct).HasColumnName("storageProduct");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => e.IdSale)
                    .HasName("PK__SALE__E8F6CE8559BC7D3C");

                entity.ToTable("SALE");

                entity.Property(e => e.IdSale).HasColumnName("ID_SALE");

                entity.Property(e => e.FkIdClient).HasColumnName("FK_ID_CLIENT");

                entity.Property(e => e.FkIdInvoice).HasColumnName("FK_ID_INVOICE");

                entity.Property(e => e.FkIdProduct).HasColumnName("FK_ID_PRODUCT");

                entity.HasOne(d => d.FkIdClientNavigation)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.FkIdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SALE__FK_ID_CLIE__2B3F6F97");

                entity.HasOne(d => d.FkIdInvoiceNavigation)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.FkIdInvoice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SALE__FK_ID_INVO__2C3393D0");

                entity.HasOne(d => d.FkIdProductNavigation)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.FkIdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SALE__FK_ID_PROD__2A4B4B5E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
