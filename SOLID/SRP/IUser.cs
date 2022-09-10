using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP
{
    public interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
    }
    public interface ILogger
    {
        void LogError(string error);
    }
    public interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}
