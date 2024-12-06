using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UsernameNormalization
{
    internal class Validation
    {
        // コンストラクタ
        public Validation() { }

        public bool exitUnnecessaryCharInUsername(string username, string pattern) 
        {
            if (username != Regex.Replace(username, pattern, ""))
            {
                return true;
            }
            return false;
        }

        public string doFormatUsername(string username)
        {
            string returnUsername = username;

            // 先頭、末尾を削除
            returnUsername = returnUsername.TrimStart('_');
            returnUsername = returnUsername.TrimEnd('_');

            // 中間を削除
            returnUsername = Regex.Replace(returnUsername, "[_]+", "_");

            return returnUsername;
        }

    }
}
