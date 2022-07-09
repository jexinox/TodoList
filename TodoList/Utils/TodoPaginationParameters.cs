namespace TodoList.Utils;

public class TodoPaginationParameters
{
    private const int max_page_size = 50;
    public int PageNumber { get; set; } = 1;
    private int pageSize = 10;
    public int PageSize
    {
        get => pageSize;
        set => pageSize = value > max_page_size ? max_page_size : value;
    }
}