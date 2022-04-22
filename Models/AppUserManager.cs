using DreamMessenger.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DreamMessenger.Models
{
    //реализация собственного UserManager 
    public class AppUserManager : UserManager<UserIdentity> //наследуемся от базового класса с типом нашего юзера
    {
        //конструктор менеджера с параметрами настройками
        public AppUserManager(IUserStore<UserIdentity> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<UserIdentity> passwordHasher, IEnumerable<IUserValidator<UserIdentity>> userValidators, IEnumerable<IPasswordValidator<UserIdentity>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<UserIdentity>> logger)
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            //пустой конструктор, который передаёт все настройки в базовый класс
        }

        //метод для получения юзера с его данными BaseUser
        public async Task<UserIdentity> GetUserIdentityAsync(ClaimsPrincipal User)
        {
            //получаем юзера через св-во User (авториз.пользовтеля)
            var user = await GetUserAsync(User);

            //извлекаем юзера с его связанными данными (с возможностью считывать их)
            var userIdentity = await Users.Include(x => x.BaseUser).SingleAsync(x => x.Id == user.Id);

            //возращаем юзера
            return userIdentity;
        }

        //метод для получения юзера с его данными Friends
        public async Task<UserIdentity> GetUserWithFriendsAsync(ClaimsPrincipal User)
        {
            //получаем юзера через св-во User (авториз.пользовтеля)
            var user = await GetUserAsync(User);

            //извлекаем юзера с его связанными данными (с возможностью считывать их)
            var userIdentity = await Users.Include(x => x.Friends).SingleAsync(x => x.Id == user.Id);

            //возращаем юзера
            return userIdentity;
        }  
    }
}
