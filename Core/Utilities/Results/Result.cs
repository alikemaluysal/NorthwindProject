using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success) // iki parametre gönderilirse bu hem alttaki tek parametreli versiyonu hem de iki parametreli versiyonu çalıştırır
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string? Message { get; }
    }
}
