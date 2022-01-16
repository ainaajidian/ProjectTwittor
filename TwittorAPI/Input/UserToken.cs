namespace TwittorAPI.Input
{
    public record UserToken
    (
        string Token,
        string Expired,
        string Message
    );
}
