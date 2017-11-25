using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using MyStoreWebApi.BL.Models;
using MyWebAPI.Api.Models;

namespace MyWebAPI.Api.App_Start
{

    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Подключите здесь службу электронной почты для отправки сообщения электронной почты.
            return Task.FromResult(0);
        }
    }

    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Подключите здесь службу SMS, чтобы отправить текстовое сообщение.
            return Task.FromResult(0);
        }
    }

    //public class ApplicationUserManager : UserManager<UserDTO, Guid>
    //{
    //    public ApplicationUserManager(IUserStore<UserDTO, Guid> store)
    //        : base(store)
    //    {
    //    }


    //    public static ApplicationUserManager Create(
    //        IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
    //    {
    //        var manager = new ApplicationUserManager();
    //        // Configure validation logic for usernames 
    //        manager.UserValidator = new UserValidator<UserDTO, Guid>(manager)
    //        {
    //            AllowOnlyAlphanumericUserNames = false,
    //            RequireUniqueEmail = true
    //        };
    //        // Configure validation logic for passwords 
    //        manager.PasswordValidator = new PasswordValidator
    //        {
    //            RequiredLength = 6,
    //            RequireNonLetterOrDigit = true,
    //            RequireDigit = true,
    //            RequireLowercase = true,
    //            RequireUppercase = true,
    //        };
    //        // Register two factor authentication providers. This application uses Phone 
    //        // and Emails as a step of receiving a code for verifying the user 
    //        // You can write your own provider and plug in here. 
    //        manager.RegisterTwoFactorProvider("PhoneCode",
    //            new PhoneNumberTokenProvider<UserDTO, Guid>
    //            {
    //                MessageFormat = "Your security code is: {0}"
    //            });
    //        manager.RegisterTwoFactorProvider("EmailCode",
    //            new EmailTokenProvider<UserDTO, Guid>
    //            {
    //                Subject = "Security Code",
    //                BodyFormat = "Your security code is: {0}"
    //            });
    //        manager.EmailService = new EmailService();
    //        manager.SmsService = new SmsService();
    //        var dataProtectionProvider = options.DataProtectionProvider;
    //        if (dataProtectionProvider != null)
    //        {
    //            manager.UserTokenProvider =
    //                new DataProtectorTokenProvider<UserDTO, Guid>(
    //                    dataProtectionProvider.Create("ASP.NET Identity"));
    //        }
    //        return manager;
    //    }
    //}
    // Настройка диспетчера входа для приложения.
    //public class ApplicationSignInManager : SignInManager<ApplicationUser, Guid>
    //{
    //    public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager)
    //        : base(userManager, authenticationManager)
    //    {
    //    }

    //    public override Task<ClaimsIdentity> CreateUserIdentityAsync(ApplicationUser user)
    //    {
    //        return user.GenerateUserIdentityAsync((ApplicationUserManager)UserManager);
    //    }

    //    public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
    //    {
    //        return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
    //    }
    //}
}