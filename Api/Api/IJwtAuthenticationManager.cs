namespace Api
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string userName, string paswword);
    }
}
