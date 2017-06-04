using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lis2013HISWSTest;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    class Do
    {

        public static bool IsBase64Formatted(string input)
        {
            try
            {
                Convert.FromBase64String(input);
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 对字符串base64解码,然后根据版本解压缩
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string kankanStr(string str) {
            // 获得版本
            str = str.Trim();
            string re = "";
            string version = "";
            if (str.StartsWith("H4"))
            {
                version = "old";

            }
            else {
                version = "new";
            }

            // 如果是old,base64解码,解压缩GZip
            if (version == "old")
            {
              re= ZipHelper.GZipDecompressString(str);
            }
           

            // 如果是new
           if (version=="new")
           {
              // 解码
               str = str.Substring(1);
               byte[] a= Convert.FromBase64String(str);
               
              // 解压缩
             re= Encoding.UTF8.GetString(ZlibHelper.deCompressBytes(a));
           }

           return re;


        }


        /// <summary>
        /// 对未修改未压缩的重新压缩编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string chongxinBianMa(string str)
        {
            // 替换
            // str = tihuan(str);
            // 压缩
           byte[] a= ZlibHelper.compressBytes(UTF8Encoding.UTF8.GetBytes(str));

            // 编码
           return  "0"+Convert.ToBase64String(a);

        }

        public static string tihuan(string str) {

           string re=  str.Replace("diesel-locomotive", "locomotive").Replace("flame-thrower-ammo", "flamethrower-ammo").Replace(
                "flame-thrower", "flamethrower").Replace("small-pump", "pump");

           return re;
        
        }



    }
}
