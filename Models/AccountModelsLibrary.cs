using System.ComponentModel.DataAnnotations;

namespace DreamMessenger.Models.AccountModels
{
    public class EmailConfirm //модель для отправки подтверждения почты
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CallbackUrl { get; set; }
        public string Email { get; set; }
        public System.DateTime Date { get; set; }
    }

    public class LoginModel //модель для авторизации юзера
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }

    public class RegisterModel //модель для регистрации юзера
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string PasswordConfirm { get; set; }
    }

    public class ResetPassword //модель для сброса пароля по форме
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }

    public class EditPassword //модель для изменения пароля
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel //модель для сообщения о сбросе пароля
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Date { get; set; }
        public string CallbackUrl { get; set; }
    }

    public class SettingsModel
    {        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //регул.выражение для валидации номера телефона
        [RegularExpression(@"^([\+]?(?:00)?[0-9]{1,3}[\s.-]?[0-9]{1,12})([\s.-]?[0-9]{1,4}?)$",ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }
        public string Location { get; set; }

        //Никнейм должен начинаться с заглавной буквы состоять только из букв и цифр
        [RegularExpression(@"^[A-Z][a-zA-Z0-9-_\.]{1,20}$", ErrorMessage = "The nickname must start with a capital letter and contain only letters and numbers.")]
        public string NickName { get; set; }

        public string Bio { get; set; }
        public string ProfilePhoto { get; set; }

        //ссылки на соц.сети с атрибутом валидации url
        [UrlAttribute]
        public string FacebookLink { get; set; }
        [UrlAttribute]
        public string InstagramLink { get; set; }
        [UrlAttribute]
        public string TwitterLink { get; set; }
        [UrlAttribute]
        public string LinkedinLink { get; set; }
        [UrlAttribute]
        public string YoutubeLink { get; set; }
    }
}
