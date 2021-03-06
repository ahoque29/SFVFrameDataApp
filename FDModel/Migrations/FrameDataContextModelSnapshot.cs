// <auto-generated />
using FDModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FDModel.Migrations
{
    [DbContext(typeof(FrameDataContext))]
    partial class FrameDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FDModel.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BackDash")
                        .HasColumnType("int");

                    b.Property<string>("CharacterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CharacterPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ForwardDash")
                        .HasColumnType("int");

                    b.Property<int>("Health")
                        .HasColumnType("int");

                    b.Property<string>("Quote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stun")
                        .HasColumnType("int");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("FDModel.Move", b =>
                {
                    b.Property<int>("MoveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<string>("MoveName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OnBlock")
                        .HasColumnType("int");

                    b.Property<int>("OnHit")
                        .HasColumnType("int");

                    b.Property<int>("Recovery")
                        .HasColumnType("int");

                    b.Property<int>("StartUp")
                        .HasColumnType("int");

                    b.Property<int>("Stun")
                        .HasColumnType("int");

                    b.HasKey("MoveId");

                    b.HasIndex("CharacterId");

                    b.ToTable("Moves");
                });

            modelBuilder.Entity("FDModel.Move", b =>
                {
                    b.HasOne("FDModel.Character", "Character")
                        .WithMany("Moves")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("FDModel.Character", b =>
                {
                    b.Navigation("Moves");
                });
#pragma warning restore 612, 618
        }
    }
}
