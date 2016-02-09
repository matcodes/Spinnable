using System;

namespace Spinnable
{
	#region RussianAppLanguage
	public class RussianAppLanguage : AppLanguage
	{
		public RussianAppLanguage ()
			: base("Русский")
		{
			this.AppName = "SPINNER";
			this.HomePageLabel = "Главная";
			this.SearchPageLabel = "Поиск";
			this.GalleryPageLabel = "Галерии";
			this.FollowersPageLabel = "Фавориты";
			this.ProfilePageLabel = "Профайл";
			this.LogInPageLabel = "Вход";
			this.SignUpPageLabel = "Регистрация";
			this.ForgotPageLabel = "Восстановление пароля";
			this.EditProfilePageLabel = "Редактор профиля";

			this.LogInWelcomeText = "Зарегистрируйтесь, чтобы смотреть 360° панорамные фотографии и видео в содружестве Spinnable";
			this.ForgotWelcomeText = "Мы отправим новый пароль на Ваш EMail.";

			this.UserNamePlaceholder = "Пользователь";
			this.PasswordPlaceholder = "Пароль";
			this.EmailPlaceholder = "Введите Ваш Email";

			this.LogInButtonText = "Вход";
			this.SignUpButtonText = "Регистрация";
			this.ForgottenButtonText = "Забыли пароль?";
			this.SendButtonText = "Отправить";
			this.ChangePasswordButtonText = "Сменить пароль";

			this.PostsLabelText = "Постов:";
			this.FollowersLabelText = "Подписчиков:";
			this.FollowingsLabelText = "Подписок:";
			this.UserNameLabelText = "Имя пользователя:";
			this.EMailLabelText = "Электронная почта:";
			this.DisplayNameLabelText = "Подпись:";
		}
	}
	#endregion
}

