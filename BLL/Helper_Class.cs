using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.BLL
{
  public static  class Helper_Class
    {
        public static string GetMd5(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using (MD5 md5 = MD5.Create())
            {
                byte[] bytes = System.Text.Encoding.Default.GetBytes(str);
                byte[] md5Byte = md5.ComputeHash(bytes);
                for (int i = 0; i < md5Byte.Length; i++)
                {
                    stringBuilder.Append(md5Byte[i].ToString("x2"));
                }
            }
            return stringBuilder.ToString();
        }

    }
}
