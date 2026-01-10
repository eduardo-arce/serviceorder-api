namespace SO.Domain.DTO.User
{
    public class SignUpInputDTO
    {
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool IsAdmin { get; set; } = false;
    }
}