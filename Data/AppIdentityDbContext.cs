using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DreamMessenger.Models;

namespace DreamMessenger.Data
{
    //реализуем интерфейс бд контекста с типом нашего юзера
    public class AppIdentityDbContext:IdentityDbContext<UserIdentity>
    {
        //таблицы для пользователей
        public DbSet<UserIdentity> AppUsers { get; set; }
        public DbSet<BaseUser> BaseUsers { get; set; }
        public DbSet<MessageUser> MessageUsers { get; set; }
        public DbSet<MessageFilesUser> MessageFiles { get; set; }
        public DbSet<Friends> Friends { get; set; } 

        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
            : base(options)
        {
        }

        //пустой конструктор для работы с таблицами (CRUD)
        public AppIdentityDbContext() { }

        //настройки приложения (строка подключения в д.случае)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=DreamMessenger;Trusted_Connection=true");
        }

        //настройки моделей
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //вызов этого метода из базового класса IdentityDbContext т.к. там хрянятся данные для БД  Identity контекста
            base.OnModelCreating(builder);
            
            //подключение настроек из других классов
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new BaseUserConfiguration());
            builder.ApplyConfiguration(new MessageUsersConfiguration());
            builder.ApplyConfiguration(new FriendsUsersConfiguration());
        }
    }

    //настройки модели UserIdentity в отдельном классе
    public class UserConfiguration : IEntityTypeConfiguration<UserIdentity>
    {
        //реализация интерфейса методом-настройщиком
        public void Configure(EntityTypeBuilder<UserIdentity> builder)
        {
            //обязательные к заполнению поля с значениями по умолчанию
            builder.Property(x => x.FirstName).IsRequired().HasDefaultValue("");
            builder.Property(x => x.LastName).IsRequired().HasDefaultValue("");
            builder.Property(x => x.RegistrationDate).IsRequired().HasDefaultValue(System.DateTime.UtcNow);
            builder.Property(x => x.IsBlockedForever).IsRequired().HasDefaultValue(false);

            //задаём максимальную длину
            builder.Property(x => x.FirstName).HasMaxLength(20);
            builder.Property(x => x.LastName).HasMaxLength(30);

            //связь один к одному между пользователем и его профилем, с настройкой удаления
            builder.HasOne(x => x.BaseUser).WithOne(y => y.UserIdentity).HasForeignKey<BaseUser>(x => x.UserIdentityKey).OnDelete(DeleteBehavior.Cascade);
            //связь один к многим между пользователем и его сообщениями, с настройкой удаления
            builder.HasMany(x => x.Messages).WithOne(y => y.UserIdentity).HasForeignKey(x => x.UserIdentityKey).OnDelete(DeleteBehavior.Cascade);
            //связь один к многим между пользователем и его друзьями
            builder.HasMany(x => x.Friends).WithOne(y => y.UserIdentity).HasForeignKey(x => x.UserIdentityKey).OnDelete(DeleteBehavior.Cascade);
        }
    }

    //настройки модели BaseUser в отдельном классе
    public class BaseUserConfiguration : IEntityTypeConfiguration<BaseUser>
    {
        //реализация интерфейса методом-настройщиком
        public void Configure(EntityTypeBuilder<BaseUser> builder)
        {
            //задаём максимальную длину
            builder.Property(x => x.Location).HasMaxLength(50);
            builder.Property(x => x.Bio).HasMaxLength(250);

            //задаём значения по умолчанию для столбцов
            builder.Property(x => x.Location).HasDefaultValue("Planet Earth");
            builder.Property(x => x.ProfilePhoto).HasDefaultValue("");
            builder.Property(x => x.Facebook).HasDefaultValue("");
            builder.Property(x => x.Twitter).HasDefaultValue("");
            builder.Property(x => x.Instagram).HasDefaultValue("");
            builder.Property(x => x.Linkedin).HasDefaultValue("");
            builder.Property(x => x.Youtube).HasDefaultValue("");
            builder.Property(x => x.Bio).HasDefaultValue("");
        }
    }

    //настройки модели MessageUser в отдельном классе
    public class MessageUsersConfiguration : IEntityTypeConfiguration<MessageUser>
    {
        //реализация интерфейса методом-настройщиком
        public void Configure(EntityTypeBuilder<MessageUser> builder)
        {
            //задаём максимальную длину
            builder.Property(x => x.Name).HasMaxLength(20);

            //задаём обязательные поля и значения по умолчанию
            builder.Property(x => x.Name).IsRequired().HasDefaultValue("");
            builder.Property(x => x.Photo).IsRequired().HasDefaultValue("");
            builder.Property(x => x.Text).IsRequired().HasDefaultValue("");
            builder.Property(x => x.Time).IsRequired().HasDefaultValue(System.DateTime.Now);

            //связь один к многим между сообщением и прикрепленными файлами, с настройкой удаления
            builder.HasMany(x => x.MessageFiles).WithOne(x => x.MessageUser).HasForeignKey(x => x.MessageUserId).OnDelete(DeleteBehavior.Cascade);
        }
    }

    //настройки модели MessageUser в отдельном классе
    public class FriendsUsersConfiguration:IEntityTypeConfiguration<Friends>
    {
        //реализация интерфейса методом-настройщиком
        public void Configure(EntityTypeBuilder<Friends> builder)
        {
            //обязательные к заполнению поля с значениями по умолчанию
            builder.Property(x => x.FriendUsername).IsRequired().HasDefaultValue("");
            builder.Property(x => x.FriendEmail).IsRequired().HasDefaultValue("");
            builder.Property(x => x.FriendKey).IsRequired().HasDefaultValue("");
        }
    }
}
