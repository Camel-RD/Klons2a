namespace KlonsChatDto.Models;

public enum EGetItemsResult { None, Ok, UserNotFound }
public class GetItemsResult
{
    public EGetItemsResult Result { get; set; } = EGetItemsResult.None;
    public List<ItemDto> Items { get; set; }
}
