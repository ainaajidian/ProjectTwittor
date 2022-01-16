namespace TwittorAPI.Input
{
    public record RegisterUser
    (
       string FullName,
       string Email,
       string UserName,
       string Password
    );
}
