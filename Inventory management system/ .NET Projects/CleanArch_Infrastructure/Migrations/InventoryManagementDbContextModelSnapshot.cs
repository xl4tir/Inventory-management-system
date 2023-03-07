﻿// <auto-generated />
using CleanArch_Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CleanArch_Infrastructure.Migrations
{
    [DbContext(typeof(InventoryManagementDbContext))]
    partial class InventoryManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Latin1_General_100_CI_AS_SC_UTF8")
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CleanArch_Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Консерви",
                            Name = "Консерви"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Соєві продукти",
                            Name = "Соєві продукти"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Риба",
                            Name = "Риба"
                        },
                        new
                        {
                            Id = 4,
                            Description = "М'ясо",
                            Name = "М'ясо"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Посуд",
                            Name = "Посуд"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Гриби",
                            Name = "Гриби"
                        });
                });

            modelBuilder.Entity("CleanArch_Domain.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LocalAddress")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Київ",
                            LocalAddress = "вул. Максимовича",
                            RegionId = 1
                        },
                        new
                        {
                            Id = 2,
                            City = "Київ",
                            LocalAddress = "бул. Дарницький",
                            RegionId = 1
                        },
                        new
                        {
                            Id = 3,
                            City = "Бережан",
                            LocalAddress = "вул. Радісна",
                            RegionId = 1
                        },
                        new
                        {
                            Id = 4,
                            City = "Бориспіль",
                            LocalAddress = "вул. Хвойна",
                            RegionId = 1
                        },
                        new
                        {
                            Id = 5,
                            City = "Київ",
                            LocalAddress = "пров. Майкопський",
                            RegionId = 1
                        },
                        new
                        {
                            Id = 6,
                            City = "Вінниця",
                            LocalAddress = "вул. Бучми",
                            RegionId = 2
                        },
                        new
                        {
                            Id = 7,
                            City = "Жмеринка",
                            LocalAddress = "пров. Вишневий",
                            RegionId = 2
                        },
                        new
                        {
                            Id = 8,
                            City = "Могилев-Подільський",
                            LocalAddress = "вул. Генетична",
                            RegionId = 2
                        },
                        new
                        {
                            Id = 9,
                            City = "Хмільник",
                            LocalAddress = "вул. О. Кошового",
                            RegionId = 2
                        },
                        new
                        {
                            Id = 10,
                            City = "Луцьк",
                            LocalAddress = "вул. Панаса Мирного",
                            RegionId = 3
                        },
                        new
                        {
                            Id = 11,
                            City = "Володимир-Волинський",
                            LocalAddress = "пров. Наливайка",
                            RegionId = 3
                        },
                        new
                        {
                            Id = 12,
                            City = "Луцьк",
                            LocalAddress = "просп. Веселий",
                            RegionId = 3
                        },
                        new
                        {
                            Id = 13,
                            City = "Дніпро",
                            LocalAddress = "вул. Аксакова",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 14,
                            City = "Вільногірськ",
                            LocalAddress = "вул. Єлісеївська",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 15,
                            City = "Кам`янське",
                            LocalAddress = "вул. Космонавтів",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 16,
                            City = "Нікополь",
                            LocalAddress = "вул. Басейна",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 17,
                            City = "Житомир",
                            LocalAddress = "бул. Європейський",
                            RegionId = 5
                        },
                        new
                        {
                            Id = 18,
                            City = "Бердячів",
                            LocalAddress = "вул. Якубця",
                            RegionId = 5
                        },
                        new
                        {
                            Id = 19,
                            City = "Коростень",
                            LocalAddress = "вул. Гайдамацька",
                            RegionId = 5
                        },
                        new
                        {
                            Id = 20,
                            City = "Малин",
                            LocalAddress = "вул. Левінська",
                            RegionId = 5
                        },
                        new
                        {
                            Id = 21,
                            City = "Київ",
                            LocalAddress = "вул. Ясна",
                            RegionId = 1
                        },
                        new
                        {
                            Id = 22,
                            City = "Дніпро",
                            LocalAddress = "вул. Чернишевського",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 23,
                            City = "Луцьк",
                            LocalAddress = "вул. Потапова",
                            RegionId = 3
                        });
                });

            modelBuilder.Entity("CleanArch_Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("SellPrice")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "",
                            Name = "Соєва ковбаса (шт.)",
                            PurchasePrice = 83m,
                            SellPrice = 91m,
                            SupplierId = 3
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "",
                            Name = "Соєвий соус (шт.)",
                            PurchasePrice = 20m,
                            SellPrice = 38m,
                            SupplierId = 3
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "",
                            Name = "Карась річний (шт.)",
                            PurchasePrice = 102m,
                            SellPrice = 127m,
                            SupplierId = 6
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 5,
                            Description = "",
                            Name = "Тарілка (шт.)",
                            PurchasePrice = 57m,
                            SellPrice = 81m,
                            SupplierId = 1
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            Description = "",
                            Name = "Набір ложок (шт.)",
                            PurchasePrice = 121m,
                            SellPrice = 158m,
                            SupplierId = 5
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "",
                            Name = "Консервовані огірки (шт.)",
                            PurchasePrice = 83m,
                            SellPrice = 96m,
                            SupplierId = 4
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            Description = "",
                            Name = "Яловичина (кг)",
                            PurchasePrice = 19m,
                            SellPrice = 46m,
                            SupplierId = 2
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            Description = "",
                            Name = "Свинина (кг)",
                            PurchasePrice = 28m,
                            SellPrice = 35m,
                            SupplierId = 3
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 6,
                            Description = "",
                            Name = "Шампіньйони (кг.)",
                            PurchasePrice = 20m,
                            SellPrice = 25m,
                            SupplierId = 7
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 5,
                            Description = "",
                            Name = "Дошка для нарізання (шт.)",
                            PurchasePrice = 58m,
                            SellPrice = 75m,
                            SupplierId = 8
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "",
                            Name = "Хек в'ялений (шт.)",
                            PurchasePrice = 70m,
                            SellPrice = 87m,
                            SupplierId = 6
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 6,
                            Description = "",
                            Name = "Гливи (кг.)",
                            PurchasePrice = 17m,
                            SellPrice = 27m,
                            SupplierId = 7
                        });
                });

            modelBuilder.Entity("CleanArch_Domain.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Київська"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Вінницька"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Волинська"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Дніпропетровська"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Донецька"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Житомирська"
                        });
                });

            modelBuilder.Entity("CleanArch_Domain.Entities.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "ТОВ 'Кернел-Трейд'",
                            LocationId = 3,
                            PhoneNum = "+380955017222"
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "ДП 'Гарантований покупець'",
                            LocationId = 5,
                            PhoneNum = "+380506952890"
                        },
                        new
                        {
                            Id = 3,
                            CompanyName = "ПрАТ 'ММК Ім. Ілліча'",
                            LocationId = 7,
                            PhoneNum = "+380950668956"
                        },
                        new
                        {
                            Id = 4,
                            CompanyName = "ТОВ 'Сільпо-Фуд'",
                            LocationId = 11,
                            PhoneNum = "+380959304515"
                        },
                        new
                        {
                            Id = 5,
                            CompanyName = "ТОВ 'Епіцентр К'",
                            LocationId = 13,
                            PhoneNum = "+380504425483"
                        },
                        new
                        {
                            Id = 6,
                            CompanyName = "ТОВ 'БАДМ'",
                            LocationId = 16,
                            PhoneNum = "+380958437543"
                        },
                        new
                        {
                            Id = 7,
                            CompanyName = "ТОВ 'ХІМ-Трейд'",
                            LocationId = 18,
                            PhoneNum = "+380981064707"
                        },
                        new
                        {
                            Id = 8,
                            CompanyName = "ПрАТ 'МХП'",
                            LocationId = 19,
                            PhoneNum = "+380926244083"
                        });
                });

            modelBuilder.Entity("CleanArch_Domain.Entities.WarehouseProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("WarehouseProducts");
                });

            modelBuilder.Entity("CleanArch_Domain.Entities.Location", b =>
                {
                    b.HasOne("CleanArch_Domain.Entities.Region", "RegionNavigation")
                        .WithMany("Locations")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Location_Region");

                    b.Navigation("RegionNavigation");
                });

            modelBuilder.Entity("CleanArch_Domain.Entities.Product", b =>
                {
                    b.HasOne("CleanArch_Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Product_Category");

                    b.HasOne("CleanArch_Domain.Entities.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Product_Supplier");

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("CleanArch_Domain.Entities.Supplier", b =>
                {
                    b.HasOne("CleanArch_Domain.Entities.Location", "Location")
                        .WithMany("Suppliers")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Suppliers_Location");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("CleanArch_Domain.Entities.WarehouseProduct", b =>
                {
                    b.HasOne("CleanArch_Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CleanArch_Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CleanArch_Domain.Entities.Location", b =>
                {
                    b.Navigation("Suppliers");
                });

            modelBuilder.Entity("CleanArch_Domain.Entities.Region", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("CleanArch_Domain.Entities.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
