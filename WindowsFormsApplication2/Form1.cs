using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lis2013HISWSTest;
using System.IO;
using zlib;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string dllName = args.Name.Contains(",") ? args.Name.Substring(0, args.Name.IndexOf(',')) : args.Name.Replace(".dll", "");
            dllName = dllName.Replace(".", "_");
            if (dllName.EndsWith("_resources")) return null;
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager(GetType().Namespace + ".Properties.Resources", System.Reflection.Assembly.GetExecutingAssembly());
            byte[] bytes = (byte[])rm.GetObject(dllName);
            return System.Reflection.Assembly.Load(bytes);
        }

        public Form1()//看清楚这是窗体本来的初始化函数
        {
            //在InitializeComponent()之前调用

            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            InitializeComponent();
        }




    

  

        // 清空1
        private void bt_clear1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        // 清空2
        private void bt_clear2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        // 复制1
        private void bt_copy1_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            if (textBox1.Text != "" && textBox1.Text != null)
            {
                Clipboard.SetText(textBox1.Text);
            }
         
            MessageBox.Show("已复制到剪贴板");
        }

        // 复制2
        private void bt_copy2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            if (textBox3.Text != "" && textBox3.Text != null)
            {
                Clipboard.SetText(textBox3.Text);
            }
           
            MessageBox.Show("已复制到剪贴板");
        }
        // 粘贴
        private void bt_paste_Click(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
        }
        // 看看字符串
        private void bt_viewer_Click(object sender, EventArgs e)
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    StreamReader sr=   File.OpenText(@"C:\Users\yy\Desktop\模式二紧凑版加密\"+i+".txt");
           
            //    StreamWriter sw = File.CreateText(@"C:\Users\yy\Desktop\模式二紧凑版加密\b" + i + ".txt");
            //    sw.Write(Do.kankanStr(sr.ReadToEnd()));
            //    sr.Close();
            //    sw.Close();
            //}

            //return;


            if (textBox1.Text.Trim()=="")
            {
                MessageBox.Show("不能为空");
                return;

            }
           bool b= Do.IsBase64Formatted(textBox1.Text.Trim().Substring(1));
           if (b)
           {
               textBox2.Text = Do.kankanStr(textBox1.Text);
                //Clipboard.Clear();
                //Clipboard.SetText(textBox2.Text);
         
           }
           else {
               MessageBox.Show("貌似字符串格式不对,解析不出来啊!");
               return;
           }
           
        }

        // 修改后重新编码
        private void button1_Click(object sender, EventArgs e)
        {
           textBox3.Text=  Do.chongxinBianMa(textBox2.Text);
        }

     
        private void bt_modify_Click(object sender, EventArgs e)
        {
            string[] strArr = textBox5.Text.Trim().Replace("，",",").Replace(" ","").Split(',');
            for (int i = 0; i < strArr.Length; i++)
            {
                int result;
             if( !int.TryParse(strArr[i],out result)){
                
                 MessageBox.Show(@"好像是""修改为""的格式不太对,只能填写数字哦,用逗号分割");
             }
            }

            //  "count":39
            Regex reg = new Regex(@"""" + textBox6.Text + @""":[-+]?\d{1,12}");
            MatchCollection mc = reg.Matches(textBox2.Text);

            string ff = textBox2.Text;

            // 把ff分割为数组
            string[] fenge= reg.Split(ff);
            // 把数组再拼起来

            string pinjie="";
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
                        pinjie += fenge[i] + @"""" + textBox6.Text + @""":" + strArr[i];


                    }
                    else
                    {
                        pinjie += fenge[i] + @"""" + textBox6.Text + @""":" + strArr[strArr.Length - 1];

                    }
                }

            }
            textBox2.Text = pinjie;



            //for (int i = 0; i < mc.Count; i++)
            //{
            //    if (strArr.Length - 1 >= i)
            //    {
            //        ff = ff.Replace(mc[i].Value, @"""" + textBox6.Text + @""":" + strArr[i]);
                    
                    
            //    }
            //    else
            //    {
            //        ff = ff.Replace(mc[i].Value, @"""" + textBox6.Text + @""":" + strArr[strArr.Length - 1]);
            //    }


            //}

            //textBox2.Text = ff;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = Clipboard.GetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Text = Clipboard.GetText();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            if (textBox8.Text != "" && textBox8.Text != null)
            {
                Clipboard.SetText(textBox8.Text);
            }
 

            MessageBox.Show("已复制到剪贴板");
        }

        private void button8_Click(object sender, EventArgs e)
        {
           textBox8.Text =  Do.musicTihuan(textBox7.Text.Trim(),comboBox1.Text);
           int n = textBox8.Text.Split(',').Length;
           label5.Text = Math.Ceiling(n / 18.0)+"个常量箱";



        }

 

 
    }
}
