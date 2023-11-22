﻿// <auto-generated />
using System;
using Architecture.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Architecture.Database.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231122195035_Add Dynamic Field")]
    partial class AddDynamicField
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Architecture.Domain.Auth", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CODE");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_DATE");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MODIFIED_BY");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("PASSWORD");

                    b.Property<int>("Roles")
                        .HasColumnType("int");

                    b.Property<Guid>("Salt")
                        .HasMaxLength(1000)
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Login")
                        .IsUnique();

                    b.HasIndex("Salt")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Auth", "Auth");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IsDeleted = false,
                            Login = "admin",
                            Password = "O34uMN1Vho2IYcSM7nlXEqn57RZ8VEUsJwH++sFr0i3MSHJVx8J3PQGjhLR3s5i4l0XWUnCnymQ/EbRmzvLy8uMWREZu7vZI+BqebjAl5upYKMMQvlEcBeyLcRRTTBpYpv80m/YCZQmpig4XFVfIViLLZY/Kr5gBN5dkQf25rK+u88gtSXAyPDkW+hVS+dW4AmxrnaNFZks0Zzcd5xlb12wcF/q96cc4htHFzvOH9jtN98N5EBIXSvdUVnFc9kBuRTVytATZA7gITbs//hkxvNQ3eody5U9hjdH6D+AP0vVt5unZlTZ+gInn8Ze7AC5o6mn0Y3ylGO1CBJSHU9c/BcFY9oknn+XYk9ySCoDGctMqDbvOBcvSTBkKcrCzev2KnX7xYmC3yNz1Q5oPVKgnq4mc1iuldMlCxse/IDGMJB2FRdTCLV5KNS4IZ1GB+dw3tMvcEEtmXmgT2zKN5+kUkOxhlv5g1ZLgXzWjVJeKb5uZpsn3WK5kt8T+kzMoxHd5i8HxsU2uvy9GopxAnaV0WNsBPqTGkRllSxARl4ZN3hJqUla553RT49tJxbs+N03OmkYhjq+L0aKJ1AC+7G+rdjegiAQZB+3mdE7a2Pne2kYtpMoCmNMKdm9jOOVpfXJqZMQul9ltJSlAY6LPrHFUB3mw61JBNzx+sZgYN29GfDY=",
                            Roles = 3,
                            Salt = new Guid("79005744-e69a-4b09-996b-08fe0b70cbb9"),
                            UserId = 1L
                        });
                });

            modelBuilder.Entity("Architecture.Domain.DynamicField", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CODE");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_DATE");

                    b.Property<long?>("DynamicFieldLookupTypeId")
                        .HasColumnType("bigint")
                        .HasColumnName("DYNAMIC_FIELD_LOOKUP_TYPE_ID");

                    b.Property<long?>("DynamicFieldMaxValue")
                        .HasColumnType("bigint")
                        .HasColumnName("DYNAMIC_FIELD_MAX_VALUE");

                    b.Property<long?>("DynamicFieldMinValue")
                        .HasColumnType("bigint")
                        .HasColumnName("DYNAMIC_FIELD_MIN_VALUE");

                    b.Property<string>("DynamicFieldRegex")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DYNAMIC_FIELD_REGEX");

                    b.Property<long?>("DynamicFieldTypeId")
                        .HasColumnType("bigint")
                        .HasColumnName("DYNAMIC_FIELD_TYPE_ID");

                    b.Property<long?>("EntityTypeId")
                        .HasColumnType("bigint")
                        .HasColumnName("ENTITY_TYPE_ID");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MODIFIED_BY");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE");

                    b.Property<long?>("NameId")
                        .HasColumnType("bigint")
                        .HasColumnName("NAME_ID");

                    b.HasKey("Id");

                    b.HasIndex("DynamicFieldLookupTypeId");

                    b.HasIndex("DynamicFieldTypeId");

                    b.HasIndex("EntityTypeId");

                    b.HasIndex("NameId");

                    b.ToTable("DYNAMIC_FIELDS", "Architecture");
                });

            modelBuilder.Entity("Architecture.Domain.Example", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CODE");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_DATE");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MODIFIED_BY");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Example", "Example");
                });

            modelBuilder.Entity("Architecture.Domain.Language", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CODE");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_DATE");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED");

                    b.Property<string>("LangFlag")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LANG_FLAG");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MODIFIED_BY");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE");

                    b.Property<DateTime?>("ValidFrom")
                        .HasColumnType("datetime2")
                        .HasColumnName("VALID_FROM");

                    b.Property<DateTime?>("ValidTo")
                        .HasColumnType("datetime2")
                        .HasColumnName("VALID_TO");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VALUE");

                    b.HasKey("Id");

                    b.ToTable("LANGUAGES", "Architecture");
                });

            modelBuilder.Entity("Architecture.Domain.Lookup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CODE");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_DATE");

                    b.Property<string>("DataType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DATA_TYPE");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("bit")
                        .HasColumnName("IS_SYSTEM");

                    b.Property<long?>("Links")
                        .HasColumnType("bigint")
                        .HasColumnName("LINKS");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MODIFIED_BY");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint")
                        .HasColumnName("PARENT_ID");

                    b.Property<long?>("TranslationId")
                        .HasColumnType("bigint")
                        .HasColumnName("TRANSLATION_ID");

                    b.Property<DateTime?>("ValidFrom")
                        .HasColumnType("datetime2")
                        .HasColumnName("VALID_FROM");

                    b.Property<DateTime?>("ValidTo")
                        .HasColumnType("datetime2")
                        .HasColumnName("VALID_TO");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VALUE");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("TranslationId");

                    b.ToTable("LOOKUPS", "Architecture");
                });

            modelBuilder.Entity("Architecture.Domain.LookupValue", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CODE");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("COLOR");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_DATE");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("bit")
                        .HasColumnName("IS_SYSTEM");

                    b.Property<long?>("LookupId")
                        .HasColumnType("bigint")
                        .HasColumnName("LOOKUP_ID");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MODIFIED_BY");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE");

                    b.Property<long?>("Order")
                        .HasColumnType("bigint")
                        .HasColumnName("ORDER");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint")
                        .HasColumnName("PARENT_ID");

                    b.Property<long?>("TranslationId")
                        .HasColumnType("bigint")
                        .HasColumnName("TRANSLATION_ID");

                    b.Property<DateTime?>("ValidFrom")
                        .HasColumnType("datetime2")
                        .HasColumnName("VALID_FROM");

                    b.Property<DateTime?>("ValidTo")
                        .HasColumnType("datetime2")
                        .HasColumnName("VALID_TO");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VALUE");

                    b.HasKey("Id");

                    b.HasIndex("LookupId");

                    b.HasIndex("ParentId");

                    b.HasIndex("TranslationId");

                    b.ToTable("LOOKUP_VALUES", "Architecture");
                });

            modelBuilder.Entity("Architecture.Domain.Translation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CODE");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_DATE");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MODIFIED_BY");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE");

                    b.HasKey("Id");

                    b.ToTable("TRANSLATIONS", "Architecture");
                });

            modelBuilder.Entity("Architecture.Domain.TranslationValue", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CODE");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_DATE");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED");

                    b.Property<long?>("LanguageId")
                        .HasColumnType("bigint")
                        .HasColumnName("LANGUAGE_ID");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MODIFIED_BY");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE");

                    b.Property<string>("TransaltionValue")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TRANSALTION_VALUE");

                    b.Property<long?>("TranslationId")
                        .HasColumnType("bigint")
                        .HasColumnName("TRANSLATION_ID");

                    b.HasKey("Id");

                    b.HasIndex("TranslationId");

                    b.ToTable("TRANSLATION_VALUES", "Architecture");
                });

            modelBuilder.Entity("Architecture.Domain.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CODE");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_DATE");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("EMAIL");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MODIFIED_BY");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("NAME");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User", "User");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "administrator@administrator.com",
                            IsDeleted = false,
                            Name = "Administrator",
                            Status = 1
                        });
                });

            modelBuilder.Entity("Architecture.Domain.Auth", b =>
                {
                    b.HasOne("Architecture.Domain.User", "User")
                        .WithOne()
                        .HasForeignKey("Architecture.Domain.Auth", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Architecture.Domain.DynamicField", b =>
                {
                    b.HasOne("Architecture.Domain.LookupValue", "DynamicFieldLookupType")
                        .WithMany()
                        .HasForeignKey("DynamicFieldLookupTypeId");

                    b.HasOne("Architecture.Domain.LookupValue", "DynamicFieldType")
                        .WithMany()
                        .HasForeignKey("DynamicFieldTypeId");

                    b.HasOne("Architecture.Domain.LookupValue", "EntityType")
                        .WithMany()
                        .HasForeignKey("EntityTypeId");

                    b.HasOne("Architecture.Domain.Translation", "Name")
                        .WithMany()
                        .HasForeignKey("NameId");

                    b.Navigation("DynamicFieldLookupType");

                    b.Navigation("DynamicFieldType");

                    b.Navigation("EntityType");

                    b.Navigation("Name");
                });

            modelBuilder.Entity("Architecture.Domain.Lookup", b =>
                {
                    b.HasOne("Architecture.Domain.Lookup", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.HasOne("Architecture.Domain.Translation", "Translation")
                        .WithMany()
                        .HasForeignKey("TranslationId");

                    b.Navigation("Parent");

                    b.Navigation("Translation");
                });

            modelBuilder.Entity("Architecture.Domain.LookupValue", b =>
                {
                    b.HasOne("Architecture.Domain.Lookup", "Lookup")
                        .WithMany("LookupValues")
                        .HasForeignKey("LookupId");

                    b.HasOne("Architecture.Domain.LookupValue", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.HasOne("Architecture.Domain.Translation", "Translation")
                        .WithMany()
                        .HasForeignKey("TranslationId");

                    b.Navigation("Lookup");

                    b.Navigation("Parent");

                    b.Navigation("Translation");
                });

            modelBuilder.Entity("Architecture.Domain.TranslationValue", b =>
                {
                    b.HasOne("Architecture.Domain.Translation", "Translation")
                        .WithMany("TranslationValues")
                        .HasForeignKey("TranslationId");

                    b.Navigation("Translation");
                });

            modelBuilder.Entity("Architecture.Domain.Lookup", b =>
                {
                    b.Navigation("LookupValues");
                });

            modelBuilder.Entity("Architecture.Domain.Translation", b =>
                {
                    b.Navigation("TranslationValues");
                });
#pragma warning restore 612, 618
        }
    }
}
