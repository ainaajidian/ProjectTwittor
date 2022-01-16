namespace TwittorAPI.Input
{
    public record UpdateProfileInput
    (
        int? UserId,
        string FullName,
        string Email,
        string Username,
        string Password
    );
}
