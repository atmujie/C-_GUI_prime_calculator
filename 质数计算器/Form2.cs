using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace 质数计算器
{
    public partial class Frame2 : Form
    {
        private long[] list = new long[5000];
        private bool Flag = true;
        private long intFileDown;
        private long intFileUp;
        private string textRes;
        private int k = 0;
        private int num = 0;
        private double date = 0;

        public Frame2()
        {
            InitializeComponent();
        }

        public Frame2(long intDown, long intUp, string text, long[] list)
        {
            InitializeComponent();
            this.intFileDown = intDown;
            this.intFileUp = intUp;
            this.textRes = text;
            this.list = list;
        }

        private bool juadgeFilePath() {
            if (textFilePath.Text == "")
            {
                textFilePath.Text = "请输入文件路径";
                return false;
            }
            else return true;
        }
        private void filePath_Click(object sender, EventArgs e)
        {

        }

        private void textFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (juadgeFilePath() == true)
                {
                    // 创建文件储存流，路径为写入路径
                    using (StreamWriter fileWriter = new StreamWriter(textFilePath.Text))
                    {
                        fileWriter.WriteLine("判定区间：" + intFileDown + "--" + intFileUp + "\n");
                        fileWriter.WriteLine(textRes);
                    }
                    this.Hide();
                }
            }
            catch {
                textFilePath.Text = "保存文件失败";
            }
        }

        private void leadFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (juadgeFilePath() == true)
                {
                    // 创建文件读取流，路径为写入路径
                    using (StreamReader fileRead = new StreamReader(textFilePath.Text))
                    {
                        string line;
                        textRes = null;
                        textRes = textRes + "\r\n";
                        double time1 = Convert.ToDouble(DateTime.Now.ToString("ss"));
                        // 从文件读取并显示行，直到文件的末尾
                        while ((line = fileRead.ReadLine()) != null)
                        {
                            // k++;
                            //if (k > 2)
                            //{
                            string textResLine = line;
                            try
                            {
                                bool flag = true;
                                long textResLong = Convert.ToInt64(textResLine);
                                if (textResLong < 10)
                                {
                                    if (textResLong == 1 || textResLong == 2 || textResLong == 3 || textResLong == 5 || textResLong == 7)
                                    {
                                        textRes = textRes + textResLong + "    是质数\r\n";
                                        k++;
                                    }
                                }
                                else
                                {
                                    long k = textResLong / 2;
                                    foreach (long j in list)
                                    {
                                        if (j >= k) break;
                                        if(textResLong % j == 0)
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                }
                                if (flag == true)
                                {
                                    textRes = textRes + textResLong + "    是质数\r\n";
                                    k++;
                                }
                                num++;
                            }
                            catch
                            {
                                Console.WriteLine("导入文件格式错误");
                            }
                            double time2 = Convert.ToDouble(DateTime.Now.ToString("ss"));
                            if (time1 > time2) time2 = time2 + 60;
                            date = time2 - time1;
                        }
                        Flag = false;
                        this.Hide();
                    }
                }
            }
            catch
            {
                textFilePath.Text = "导入文件失败,请检查文件名是否正确";
            }
        }

        public bool getFlag() {
            return Flag;
        }

        public string getTextRes()
        {
            return textRes;
        }

        public int getK()
        {
            return k;
        }

        public int getNum()
        {
            return num;
        }
        public double getDate() {
            return date;
        }
    }
}
