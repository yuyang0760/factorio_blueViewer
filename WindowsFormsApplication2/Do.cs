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

        public static string regexTihuan(string ff,string c) {
            ////
            string[] strArr = ff.Split(',');
            //  "count":39
            Regex reg = new Regex(@"""" + c + @""":\d{1,6}");
            MatchCollection mc = reg.Matches(ff);

           

            // 把ff分割为数组
            string[] fenge = reg.Split(ff);
            // 把数组再拼起来

            string pinjie = "";
            for (int i = 0; i < fenge.Length; i++)
            {


                if (i == fenge.Length - 1)
                {
                    pinjie += fenge[i];

                }
                else
                {

                    if (strArr.Length - 1 >= i)
                    {
                        pinjie += fenge[i] + @"""" + c+ @""":" + strArr[i];


                    }
                    else
                    {
                        pinjie += fenge[i] + @"""" + c + @""":" + strArr[strArr.Length - 1];

                    }
                }

            }
          return pinjie;

        }


        /// <summary>
        /// s是没有逗号分割的
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string musicTihuan(string s, string leixing)
        {

            Dictionary<string, string> dic = new Dictionary<string, string>();
            string s1 = "";
            string s2 = "";

            // 3,4,5,6,7
            if (leixing == "piano")
            {
                s1 = "0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48";

                s2 = "0,4s,4s#,5s,5s#,6s,6s#,7s,1d,1d#,2d,2d#,3d,4d,4d#,5d,5d#,6d,6d#,7d,1,1#,2,2#,3,4,4#,5,5#,6,6#,7,1g,1g#,2g,2g#,3g,4g,4g#,5g,5g#,6g,6g#,7g,1h,1h#,2h,2h#,3h";

            }

            // 2,3,4,5
            if (leixing == "bass" || leixing == "saw" || leixing == "square" || leixing == "lead")
            {
                s1 = "0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36";

                s2 = "0,4a,4a#,5a,5a#,6a,6a#,7a,1s,1s#,2s,2s#,3s,4s,4s#,5s,5s#,6s,6s#,7s,1d,1d#,2d,2d#,3d,4d,4d#,5d,5d#,6d,6d#,7d,1,1#,2,2#,3";

            }

            // 5,6,7,8
            if (leixing == "celesta" || leixing == "vibraphone")
            {
                s1 = "0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36";

                s2 = "0,4,4#,5,5#,6,6#,7,1g,1g#,2g,2g#,3g,4g,4g#,5g,5g#,6g,6g#,7g,1h,1h#,2h,2h#,3h,4h,4h#,5h,5h#,6h,6h#,7h,1j,1j#,2j,2j#,3j";

            }

            // 4,5,6,7
            if (leixing == "plucked")
            {
                s1 = "0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36";

                s2 = "0,4d,4d#,5d,5d#,6d,6d#,7d,1,1#,2,2#,3,4,4#,5,5#,6,6#,7,1g,1g#,2g,2g#,3g,4g,4g#,5g,5g#,6g,6g#,7g,1h,1h#,2h,2h#,3h";

            }
            // 3,4,5,6
            if (leixing == "steel-drum")
            {
                s1 = "0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36";

                s2 = "0,4s,4s#,5s,5s#,6s,6s#,7s,1d,1d#,2d,2d#,3d,4d,4d#,5d,5d#,6d,6d#,7d,1,1#,2,2#,3,4,4#,5,5#,6,6#,7,1g,1g#,2g,2g#,3g";

            }




            string[] s3 = s1.Split(',');
            string[] s4 = s2.Split(',');

            // 赋值
            for (int i = 0; i < s3.Length; i++)
            {
                dic.Add(s4[i], s3[i]);
            }
            char[] cc = s.ToCharArray();

            // 拼接
            string pin = "";
            for (int i = 0; i < cc.Length; i++)
            {

                pin += cc[i].ToString() + ",";

            }
            pin = pin.Substring(0, pin.Length - 1);
            // 替换
            pin = pin.Replace(",g", "g").Replace(",d", "d").Replace(",s", "s").Replace(",h", "h").Replace(",j", "j").Replace(",a", "a").Replace(",#", "#");

            // 逗号分割,替换
            string[] s5 = pin.Split(',');
            string re = "";
            for (int i = 0; i < s5.Length; i++)
            {
                re += dic[s5[i]] + ",";

            }

            // 去掉最后的逗号
            re = re.Substring(0, re.Length - 1);
            return re;




        }


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
        public static string kankanStr(string str)
        {
            // 获得版本
            str = str.Trim();
            string re = "";
            string version = "";
            if (str.StartsWith("H4"))
            {
                version = "old";

            }
            else
            {
                version = "new";
            }

            // 如果是old,base64解码,解压缩GZip
            if (version == "old")
            {
                re = ZipHelper.GZipDecompressString(str);
            }


            // 如果是new
            if (version == "new")
            {
                // 解码
                str = str.Substring(1);
                byte[] a = Convert.FromBase64String(str);

                // 解压缩
                re = Encoding.UTF8.GetString(ZlibHelper.deCompressBytes(a));
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
            byte[] a = ZlibHelper.compressBytes(UTF8Encoding.UTF8.GetBytes(str));

            // 编码
            return "0" + Convert.ToBase64String(a);

        }

        public static string tihuan(string str)
        {

            string re = str.Replace("diesel-locomotive", "locomotive").Replace("flame-thrower-ammo", "flamethrower-ammo").Replace(
                 "flame-thrower", "flamethrower").Replace("small-pump", "pump");

            return re;

        }



    }
}
