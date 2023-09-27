namespace WebApplication3.ConnectionString
{
    public class ConnectionString
    {
        public static string Pr_DbConnectionString { get; set; }

        static ConnectionString()
        {
            Pr_DbConnectionString = string.Empty; // Set an initial value if needed
        }
    }
}
