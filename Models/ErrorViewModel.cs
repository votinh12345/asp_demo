using Microsoft.EntityFrameworkCore;

namespace hienv_asp.Models
{
    [Keyless]
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}