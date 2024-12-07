using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsernameNormalization
{
    internal enum ErrorCode
    {
        InvalidCharacters,
        InvalidLength
    }
    internal class ErrorMessage
    {
        private readonly Dictionary<ErrorCode, string> _ErrorMessage = new Dictionary<ErrorCode, string> 
        {
            {ErrorCode.InvalidLength,"Invalid username（3文字以上15文字以内）" },
            {ErrorCode.InvalidCharacters,"Invalid username（英数字とアンダースコアのみ）" }
        };

        public static string getErrorMessage(ErrorCode errorCode) 
        {
            ErrorMessage errorMessage = new ErrorMessage();
            if(errorMessage._ErrorMessage.TryGetValue(errorCode, out string message)) { 
                return message;
            }
            else
            {
                return "Unknown error";
            }
        }
    }
}
