using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UI.Model;

public partial class ContosoContext : DbContext
{
    public ContosoContext()
    {
    }

    public ContosoContext(DbContextOptions<ContosoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CurrencyExchange> CurrencyExchanges { get; set; }

    public virtual DbSet<CurrencyExchange1> CurrencyExchanges1 { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Customer1> Customers1 { get; set; }

    public virtual DbSet<Date> Dates { get; set; }

    public virtual DbSet<Date1> Dates1 { get; set; }

    public virtual DbSet<GeoLocation> GeoLocations { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderRow> OrderRows { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Product1> Products1 { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<Store1> Stores1 { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:20.42.114.46,443;Initial Catalog=contoso;Persist Security Info=False;User ID=test-db-admin;Password=YaAS9V3QH4mgxUwa;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<CurrencyExchange>(entity =>
        {
            entity.HasKey(e => new { e.Date, e.FromCurrency, e.ToCurrency }).HasName("PK__Currency__9F41EC282F03A62D");

            entity.ToTable("CurrencyExchange", "Data");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.FromCurrency)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.ToCurrency)
                .HasMaxLength(3)
                .IsFixedLength();
        });

        modelBuilder.Entity<CurrencyExchange1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Currency Exchange");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.FromCurrency)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.ToCurrency)
                .HasMaxLength(3)
                .IsFixedLength();
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerKey)
                .HasName("PK_Customer_CustomerKey")
                .IsClustered(false);

            entity.ToTable("Customer", "Data");

            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Company).HasMaxLength(50);
            entity.Property(e => e.Continent).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CountryFull).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.GivenName).HasMaxLength(150);
            entity.Property(e => e.MiddleInitial).HasMaxLength(150);
            entity.Property(e => e.Occupation).HasMaxLength(100);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.StateFull).HasMaxLength(50);
            entity.Property(e => e.StreetAddress).HasMaxLength(150);
            entity.Property(e => e.Surname).HasMaxLength(150);
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.Vehicle).HasMaxLength(50);
            entity.Property(e => e.ZipCode).HasMaxLength(50);
        });

        modelBuilder.Entity<Customer1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Customer");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Continent).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .HasColumnName("Country Code");
            entity.Property(e => e.CustomerKey).ValueGeneratedOnAdd();
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(301);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.StateCode)
                .HasMaxLength(50)
                .HasColumnName("State Code");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(50)
                .HasColumnName("Zip Code");
        });

        modelBuilder.Entity<Date>(entity =>
        {
            entity.HasKey(e => e.Date1).HasName("PK__Date__77387D06AEDE6368");

            entity.ToTable("Date", "Data");

            entity.Property(e => e.Date1)
                .HasColumnType("date")
                .HasColumnName("Date");
            entity.Property(e => e.DayOfWeek)
                .HasMaxLength(30)
                .HasColumnName("Day of Week");
            entity.Property(e => e.DayOfWeekNumber).HasColumnName("Day of Week Number");
            entity.Property(e => e.DayOfWeekShort)
                .HasMaxLength(30)
                .HasColumnName("Day of Week Short");
            entity.Property(e => e.Month).HasMaxLength(30);
            entity.Property(e => e.MonthNumber).HasColumnName("Month Number");
            entity.Property(e => e.MonthShort)
                .HasMaxLength(30)
                .HasColumnName("Month Short");
            entity.Property(e => e.Quarter)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.WorkingDay).HasColumnName("Working Day");
            entity.Property(e => e.WorkingDayNumber).HasColumnName("Working Day Number");
            entity.Property(e => e.YearMonth)
                .HasMaxLength(30)
                .HasColumnName("Year Month");
            entity.Property(e => e.YearMonthNumber).HasColumnName("Year Month Number");
            entity.Property(e => e.YearMonthShort)
                .HasMaxLength(30)
                .HasColumnName("Year Month Short");
            entity.Property(e => e.YearQuarter)
                .HasMaxLength(30)
                .HasColumnName("Year Quarter");
            entity.Property(e => e.YearQuarterNumber).HasColumnName("Year Quarter Number");
        });

        modelBuilder.Entity<Date1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Date");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.DayOfWeek)
                .HasMaxLength(30)
                .HasColumnName("Day of Week");
            entity.Property(e => e.DayOfWeekNumber).HasColumnName("Day of Week Number");
            entity.Property(e => e.DayOfWeekShort)
                .HasMaxLength(30)
                .HasColumnName("Day of Week Short");
            entity.Property(e => e.Month).HasMaxLength(30);
            entity.Property(e => e.MonthNumber).HasColumnName("Month Number");
            entity.Property(e => e.MonthShort)
                .HasMaxLength(30)
                .HasColumnName("Month Short");
            entity.Property(e => e.Quarter)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.WorkingDay).HasColumnName("Working Day");
            entity.Property(e => e.WorkingDayNumber).HasColumnName("Working Day Number");
            entity.Property(e => e.YearMonth)
                .HasMaxLength(30)
                .HasColumnName("Year Month");
            entity.Property(e => e.YearMonthNumber).HasColumnName("Year Month Number");
            entity.Property(e => e.YearMonthShort)
                .HasMaxLength(30)
                .HasColumnName("Year Month Short");
            entity.Property(e => e.YearQuarter)
                .HasMaxLength(30)
                .HasColumnName("Year Quarter");
            entity.Property(e => e.YearQuarterNumber).HasColumnName("Year Quarter Number");
        });

        modelBuilder.Entity<GeoLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GeoLocations", "Data");

            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CountryCode).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.StateCode).HasMaxLength(50);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderKey)
                .HasName("PK_Orders_OrderKey")
                .IsClustered(false);

            entity.ToTable("Orders", "Data");

            entity.Property(e => e.OrderKey).ValueGeneratedNever();
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Currency Code");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("date")
                .HasColumnName("Delivery Date");
            entity.Property(e => e.OrderDate)
                .HasColumnType("date")
                .HasColumnName("Order Date");

            entity.HasOne(d => d.CustomerKeyNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerKey)
                .HasConstraintName("FK_Orders_CustomerKey");

            entity.HasOne(d => d.OrderDateNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.OrderDate)
                .HasConstraintName("FK_Orders_OrderDateKey");

            entity.HasOne(d => d.StoreKeyNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.StoreKey)
                .HasConstraintName("FK_Orders_StoreKey");
        });

        modelBuilder.Entity<OrderRow>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OrderRows", "Data");

            entity.Property(e => e.LineNumber).HasColumnName("Line Number");
            entity.Property(e => e.NetPrice)
                .HasColumnType("money")
                .HasColumnName("Net Price");
            entity.Property(e => e.UnitCost)
                .HasColumnType("money")
                .HasColumnName("Unit Cost");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("money")
                .HasColumnName("Unit Price");

            entity.HasOne(d => d.OrderKeyNavigation).WithMany()
                .HasForeignKey(d => d.OrderKey)
                .HasConstraintName("FK_OrderRows_OrderKey");

            entity.HasOne(d => d.ProductKeyNavigation).WithMany()
                .HasForeignKey(d => d.ProductKey)
                .HasConstraintName("FK_OrderRows_ProductKey");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductKey).HasName("PK__Product__A15E99B30D7D5DE7");

            entity.ToTable("Product", "Data");

            entity.Property(e => e.ProductKey).ValueGeneratedNever();
            entity.Property(e => e.Brand).HasMaxLength(50);
            entity.Property(e => e.Category).HasMaxLength(30);
            entity.Property(e => e.CategoryCode)
                .HasMaxLength(100)
                .HasColumnName("Category Code");
            entity.Property(e => e.Color).HasMaxLength(20);
            entity.Property(e => e.Manufacturer).HasMaxLength(50);
            entity.Property(e => e.ProductCode)
                .HasMaxLength(255)
                .HasColumnName("Product Code");
            entity.Property(e => e.ProductName)
                .HasMaxLength(500)
                .HasColumnName("Product Name");
            entity.Property(e => e.Subcategory).HasMaxLength(50);
            entity.Property(e => e.SubcategoryCode)
                .HasMaxLength(100)
                .HasColumnName("Subcategory Code");
            entity.Property(e => e.UnitCost)
                .HasColumnType("money")
                .HasColumnName("Unit Cost");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("money")
                .HasColumnName("Unit Price");
            entity.Property(e => e.WeightUnitMeasure)
                .HasMaxLength(20)
                .HasColumnName("Weight Unit Measure");
        });

        modelBuilder.Entity<Product1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Product");

            entity.Property(e => e.Brand).HasMaxLength(50);
            entity.Property(e => e.Category).HasMaxLength(30);
            entity.Property(e => e.CategoryCode)
                .HasMaxLength(100)
                .HasColumnName("Category Code");
            entity.Property(e => e.Color).HasMaxLength(20);
            entity.Property(e => e.Manufacturer).HasMaxLength(50);
            entity.Property(e => e.ProductCode)
                .HasMaxLength(255)
                .HasColumnName("Product Code");
            entity.Property(e => e.ProductName)
                .HasMaxLength(500)
                .HasColumnName("Product Name");
            entity.Property(e => e.Subcategory).HasMaxLength(50);
            entity.Property(e => e.SubcategoryCode)
                .HasMaxLength(100)
                .HasColumnName("Subcategory Code");
            entity.Property(e => e.UnitCost)
                .HasColumnType("money")
                .HasColumnName("Unit Cost");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("money")
                .HasColumnName("Unit Price");
            entity.Property(e => e.WeightUnitMeasure)
                .HasMaxLength(20)
                .HasColumnName("Weight Unit Measure");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Sales");

            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Currency Code");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("date")
                .HasColumnName("Delivery Date");
            entity.Property(e => e.ExchangeRate).HasColumnName("Exchange Rate");
            entity.Property(e => e.LineNumber).HasColumnName("Line Number");
            entity.Property(e => e.NetPrice)
                .HasColumnType("money")
                .HasColumnName("Net Price");
            entity.Property(e => e.OrderDate)
                .HasColumnType("date")
                .HasColumnName("Order Date");
            entity.Property(e => e.OrderNumber).HasColumnName("Order Number");
            entity.Property(e => e.UnitCost)
                .HasColumnType("money")
                .HasColumnName("Unit Cost");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("money")
                .HasColumnName("Unit Price");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.StoreKey).HasName("PK__Store__ADC1E1AD49C38997");

            entity.ToTable("Store", "Data");

            entity.Property(e => e.StoreKey).ValueGeneratedNever();
            entity.Property(e => e.CloseDate)
                .HasColumnType("date")
                .HasColumnName("Close Date");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OpenDate)
                .HasColumnType("date")
                .HasColumnName("Open Date");
            entity.Property(e => e.SquareMeters).HasColumnName("Square Meters");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StoreCode).HasColumnName("Store Code");
        });

        modelBuilder.Entity<Store1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Store");

            entity.Property(e => e.CloseDate)
                .HasColumnType("date")
                .HasColumnName("Close Date");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OpenDate)
                .HasColumnType("date")
                .HasColumnName("Open Date");
            entity.Property(e => e.SquareMeters).HasColumnName("Square Meters");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StoreCode).HasColumnName("Store Code");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
