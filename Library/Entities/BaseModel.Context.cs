//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LibraryEntities : DbContext
    {
        public LibraryEntities()
            : base("name=LibraryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BookLocation> BookLocations { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<DeliveryService> DeliveryServices { get; set; }
        public virtual DbSet<Extradition> Extraditions { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Librarian> Librarians { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SchoolBoy> SchoolBoys { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TypeOfHall> TypeOfHalls { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
