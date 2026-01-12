namespace SO.Domain.DTO.ServiceOrder
{
    public class ServiceOrderFilterInputDTO
    {
        public string? UserId { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;

    }
}