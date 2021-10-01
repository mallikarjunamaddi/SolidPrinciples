namespace SolidPrinciples
{
    /// <summary>
    /// To implement a Login Module.
    /// It needs Login, Register methods
    /// </summary>
    interface IUser
    {
        /// <summary>
        /// To Login
        /// </summary>
        /// <param name="userEmail"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Login(string userEmail, string password);

        /// <summary>
        /// To Register a user
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="userEmail"></param>
        /// <returns></returns>
        bool Register(string userName, string password, string userEmail);

        /// <summary>
        /// To Log Errors if any
        /// </summary>
        /// <param name="message"></param>
        void Logger(string errorMessage);

        /// <summary>
        /// Send an Email for user registeration
        /// </summary>
        /// <param name="userEmail"></param>
        /// <returns></returns>
        bool SendEmail(string emailContent);
    }

    /// <summary>
    /// With SRP, we divide the responsibilites
    /// </summary>
    interface IUserLatest
    {
        bool Login(string userEmail, string password);
        bool Register(string userName, string password, string userEmail);
    }

    /// <summary>
    /// Logger is a general service, which can be
    /// reused in many other parts of the application
    /// </summary>
    interface ILogger
    {
        void Logger(string errorMessage);
    }

    /// <summary>
    /// SendMail should be part of EmailService
    /// It has nothing to do with IUser
    /// </summary>
    interface IEmailService
    {
        bool SendEmail(string emailContent);
    }
}
