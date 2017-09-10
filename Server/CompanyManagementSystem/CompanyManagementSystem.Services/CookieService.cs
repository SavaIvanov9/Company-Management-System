namespace CompanyManagementSystem.Services
{
    using System;
    using System.Linq;
    using Data.Abstraction;
    using Encryption;

    public class CookieService
    {
        private readonly string key;
        private readonly IEncryptor encryptor;

        protected CookieService(IUnitOfWork data, IEncryptor encryptor)
        {
            this.data = data;
            this.encryptor = encryptor;
            this.key = "JS Sucks";
        }

        private IUnitOfWork data { get; }

        public string EncryptString(string value)
        {
            return encryptor.Encrypt(value, key);
        }

        public string DecryptString(string value)
        {
            return encryptor.Decrypt(value, key);
        }

        public string CreateCookie(string name, string password, long id)
        {
            return this.EncryptString($"{name}-{password}-{id}");
        }

        public bool ValidateCookie(string value)
        {
            var cookie = this.data.CookieRepository
                .All()
                .FirstOrDefault(x => x.Content == value && x.ExpirationDate > DateTime.Now);

            if (cookie == null)
            {
                return false;
            }

            return true;
        }

        public bool ExtendCookie(string value)
        {
            var result = false;

            try
            {
                var cookie = this.data.CookieRepository
                    .All()
                    .Where(x => x.Content == value)
                    .FirstOrDefault();

                if (cookie == null)
                {
                    throw new Exception();
                }

                if (cookie.ExpirationDate < DateTime.Now.Add(new TimeSpan(1, 0, 15, 0)))
                {
                    var date = cookie.ExpirationDate;
                    cookie.ExpirationDate = date.Add(new TimeSpan(1, 0, 0, 0));
                    this.data.CookieRepository.Update(cookie);
                    this.data.SaveChanges();
                }

                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }
    }
}
