using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 质数计算器
{
    public partial class Frame : Form
    {
        private long intDown;
        private long intUp;
        private int k = 0;
        private static long[] list = new long[5000];

        public Frame()
        {
            PrimeNumberTable primeNumberTable = new PrimeNumberTable();
            list = primeNumberTable.getList();
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            textBoxRes.ForeColor = Color.Black;
            textBoxRes.Text = "";
            string textNum = null;
            double time1 = Convert.ToDouble(DateTime.Now.ToString("ss"));
            if (textBoxDown.Text == "" || textBoxUp.Text == "")
            {
                textBoxRes.ForeColor = Color.Red;
                textBoxRes.Text = "请输入正确的质数区间";
            }
            else if (intDown > intUp) {
                textBoxRes.ForeColor = Color.Red;
                textBoxRes.Text = "区间下界必须小于区间上界";
            }
            else {
                for (long i = intDown; i <= intUp; i++) {
                    bool flag = true;
                    if (i < 10)
                    {
                        if (i == 1 || i == 2 || i == 3 || i == 5 || i == 7)
                        {
                            textNum = textNum + i + "   ";
                            k = k + 1;
                        }
                    }
                    else {
                        long k = i / 2;
                        foreach (long j in list)
                        {
                            if (j >= k) break;
                            if (i % j == 0)
                            {
                                flag = false;
                                break;
                            }
                        }
                        /*for (long j = 2; j <= 7; j++)
                        {
                            if (j == 4 || j == 6)  continue;
                            if (i % j == 0)
                            {
                                flag = false;
                                break;
                            }
                        }*/
                        if (flag == true) {
                            textNum = textNum + i + "   ";
                            k = k + 1;
                        }
                    }
                    if (k == 10)
                    {
                        textNum = textNum + "\r\n";
                        // Console.WriteLine(k);
                        k = 0;
                    }

                }
            }
            k = 0;
            textBoxRes.Text = textBoxRes.Text + textNum;
            double time2 = Convert.ToDouble(DateTime.Now.ToString("ss"));
            if (time1 > time2) time2 = time2 + 60;
            MessageBox.Show("计算完毕，用时" + (time2 - time1) + "秒");
        }

        private void textBoxDown_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDown.Text != "") {
                Regex reg = new Regex("^[0-9]+$");
                Match ma = reg.Match(textBoxDown.Text);
                textBoxRes.ForeColor = Color.Black;
                textBoxRes.Text = "";
                if (ma.Success)
                {
                    intDown = Convert.ToInt64(textBoxDown.Text);
                    // Console.WriteLine(intDown);
                    return ;
                }
                else
                {
                    textBoxRes.ForeColor = Color.Red;
                    textBoxRes.Text = "区间下界的输入必须是数字";
                }
            }
        }

        private void textBoxUp_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUp.Text != "")
            {
                Regex reg = new Regex("^[0-9]+$");
                Match ma = reg.Match(textBoxUp.Text);
                textBoxRes.ForeColor = Color.Black;
                textBoxRes.Text = "";
                if (ma.Success)
                {
                    intUp = Convert.ToInt64(textBoxUp.Text);
                    // textBoxRes.Text = textBoxUp.Text;
                    // Console.WriteLine(intDown);
                    return;
                }
                else
                {
                    textBoxRes.ForeColor = Color.Red;
                    textBoxRes.Text = "区间上界的输入必须是数字";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frame2 frame2 = new Frame2(intDown, intUp, textBoxRes.Text ,list);
            frame2.ShowDialog();
            if (frame2.getFlag() == false) {
                textBoxRes.Text = "";
                textBoxUp.Text = "";
                textBoxDown.Text = "";
                string reTextRes = frame2.getTextRes();
                int numes = frame2.getNum();
                int ks = frame2.getK();
                double date = frame2.getDate();
                textBoxRes.Text = textBoxRes + reTextRes;
                MessageBox.Show("该文件共有" + numes + "个数，其中有" + ks + "个质数，用时" + date + "秒");
            }
        }

        private void juadge_Click(object sender, EventArgs e)
        {
            int nums = 0;
            string textNum = null;
            textBoxRes.ForeColor = Color.Black;
            textBoxRes.Text = "";
            double time1 = Convert.ToDouble(DateTime.Now.ToString("ss"));
            if (textBoxDown.Text == "" || textBoxUp.Text == "")
            {
                textBoxRes.ForeColor = Color.Red;
                textBoxRes.Text = "请输入正确的质数区间";
            }
            else if (intDown > intUp)
            {
                textBoxRes.ForeColor = Color.Red;
                textBoxRes.Text = "区间下界必须小于区间上界";
            }
            else
            {
                for (long i = intDown; i <= intUp; i++)
                {
                    bool flag = true;
                    if (i < 10)
                    {
                        if (i == 1 || i == 2 || i == 3 || i == 5 || i == 7)
                        {
                            textNum = textNum + i + "      是质数\r\n";
                            nums++;
                        }
                    }
                    else
                    {
                        long k = i / 2;
                        foreach (long j in list)
                        {
                            if (j >= k) break;
                            if (i % j == 0)
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (flag == true)
                        {
                            textNum = textNum + i + "       是质数\r\n";
                            nums++;
                        }
                    }
                }
            }
            textBoxRes.Text = textBoxRes.Text + textNum;
            double time2 = Convert.ToDouble(DateTime.Now.ToString("ss"));
            if (time1 > time2) time2 = time2 + 60;
            MessageBox.Show("该区间共有"+ (intUp - intDown) + "个整数，其中有" + nums + "个质数，用时" + (time2-time1) + "秒");
        }
    }
}
