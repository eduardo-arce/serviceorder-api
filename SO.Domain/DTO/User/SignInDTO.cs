namespace SO.Domain.DTO.User
{
    public class SignInInputDTO
    {
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
    }

    public class SignInOutputDTO
    {
        public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public bool IsAdmin { get; set; }
        public string AccessToken { get; set; } = null!;
    }
}