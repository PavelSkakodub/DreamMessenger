using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DreamMessenger.Models
{
    //класс пользователя унаслед.от IdentityUser
    public class UserIdentity : IdentityUser
    {
        //никнейм
        //емейл
        //номер телефона
        //...

        public string FirstName { get; set; } //имя
        public string LastName { get; set; } //фамилия
        public DateTime RegistrationDate { get; set; } //дата регистрации
        public bool IsBlockedForever { get; set; } //вместо удаления блокируем навсегда

        //ленивая загрузка с помощью virtual
        public BaseUser BaseUser { get; set; } //информация по профилю (связь 1 к 1)
        public List<MessageUser> Messages { get; set; } //список сообщений юзера (свзь один к многим)
        public List<Friends> Friends { get; set; } //список друзей (1 к многим)
    }

    //класс профильной информации по юзеру
    public class BaseUser
    {
        public int Id { get; set; } //Id

        public string ProfilePhoto { get; set; } //путь к фото профиля
        public string Location { get; set; } //местоположение
        public string Bio { get; set; } //био (инфа по пользователю)

        public string Facebook { get; set; } //ссылка на Facebook
        public string Twitter { get; set; } //ссылка на Twitter
        public string Instagram { get; set; } //ссылка на Instagram
        public string Linkedin { get; set; } //ссылка на Linkedin
        public string Youtube { get; set; } //ссылка на Youtube
        public DateTime LastUpdate { get; set; } //дата посл.обновления профиля 

        public string UserIdentityKey { get; set; } //внешний ключ
        public UserIdentity UserIdentity { get; set; } //связь 1 к 1 (ленивая загрузка с помощью virtual)
    }

    //класс друзей (контактов) пользователя
    public class Friends
    {
        public int Id { get; set; } //Id
        public string FriendKey { get; set; } //Id друга пользователя
        public string FriendUsername { get; set; } //никнейм друга
        public string FriendEmail { get; set; } //емейл друга
        public string UserIdentityKey { get; set; } //внешний ключ
        public UserIdentity UserIdentity { get; set; } //связь один ко многим
    }

    //класс сообщения пользователя с ссылками на файлы
    public class MessageUser
    {
        public int Id { get; set; } //Id
        public string Name { get; set; } //имя отправителя
        public string Photo { get; set; } //ссылка на фото (аватарка отправителя)
        public string Text { get; set; } //текст сообщения
        public DateTime Time { get; set; } //время отправки с датой (для сортировки)

        public string UserIdentityKey { get; set; } //внешний ключ
        public UserIdentity UserIdentity { get; set; } //связь один к многим 

        public List<MessageFilesUser> MessageFiles { get; set; } //список файлов
    }

    //класс файла, прикрепленного к сообщению
    public class MessageFilesUser
    {
        public int Id { get; set; } //Id
        public string FileUrl { get; set; } //ссылка на файл в S3-хранилище

        public int MessageUserId { get; set; } //внешний ключ
        public MessageUser MessageUser { get; set; } //связь один к многим (ленивая загрузка с помощью virtual)
    }


}
