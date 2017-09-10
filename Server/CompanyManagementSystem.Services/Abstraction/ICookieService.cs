namespace CompanyManagementSystem.Services.Abstraction
{
    public interface ICookieService
    {
        string EncryptString(string value);

        string DecryptString(string value);

        string CreateCookie(string name, string password, long id);

        bool ValidateCookie(string value);

        bool ExtendCookie(string value);
    }
}
