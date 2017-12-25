using System;

namespace LearnSP.Models
{
    public class ErrorViewModel2
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}