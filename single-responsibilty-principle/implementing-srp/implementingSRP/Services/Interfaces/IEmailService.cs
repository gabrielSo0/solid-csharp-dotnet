namespace implementingSRP.Services.Interfaces
{
    public interface IEmailService
    {
        void SendEmail(string email, string product, string message);
    }
}