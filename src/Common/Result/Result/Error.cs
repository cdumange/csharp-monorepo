
namespace Result
{
    public record Error
    {
        public required string Reason { get; set; }

        public static Error FromReason(string reason)
        {
            return new Error
            {
                Reason = reason
            };
        }
    }
}