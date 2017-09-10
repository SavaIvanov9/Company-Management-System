namespace CompanyManagementSystem.Services.Abstraction
{
    public interface IEncryptionService
    {
        string Encrypt(string plainText, string passPhrase);

        string Decrypt(string cipherText, string passPhrase);
    }
}
