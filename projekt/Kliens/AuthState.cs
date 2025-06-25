using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public static class AuthState
{
    public static string Token { get; set; }
	public static bool IsAuth
	{
		get
		{
			if (Token is null)
			{
				return false;
			}
			else return true;
		} 
	}
}
