namespace AbySalto.Junior.Application.Exception;

public class DbException :System.Exception
{
   public DbException(string message) : base(message){ } 
}