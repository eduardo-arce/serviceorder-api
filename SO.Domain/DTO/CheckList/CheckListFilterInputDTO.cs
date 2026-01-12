namespace SO.Domain.DTO.CheckList
{
    public class CheckListFilterInputDTO
    {
        public bool? IsActive { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;

    }
}