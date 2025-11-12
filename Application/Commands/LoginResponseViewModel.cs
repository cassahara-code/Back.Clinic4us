namespace Application.Commands
{
    public class LoginResponseViewModel
    {
        public string AccessToken { get; set; } = string.Empty;
        public double ExpiresIn { get; set; }
        public UserTokenViewModel UserToken { get; set; } = null!;
    }

    public class UserTokenViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public IEnumerable<ClaimViewModel> Claims { get; set; } = new List<ClaimViewModel>();
    }

    public class ClaimViewModel
    {
        public string Value { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
    }
}
