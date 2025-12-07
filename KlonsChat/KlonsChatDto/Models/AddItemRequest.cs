namespace KlonsChatDto.Models
{
    public class AddItemRequest
    {
        public string UserGuid { get; set; }
        public string SupportGuid { get; set; }
        public string Content { get; set; }
    }
}