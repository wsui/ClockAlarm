using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using TaskScheduler;
using System.Threading;
using System.Timers;

namespace ClockAlarm
{
    /*
     * author:woon 
     * date:2018/05/31
     */
    public partial class Form1 : Form
    {
        //配置文件路径
        String config_path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ColokAlarm";
        //配置文件
        String config_file = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ColokAlarm\\clockalarm.txt";
        //应用程序路径和名称
        String exe_path = Application.ExecutablePath;
        //背景间隔0.5秒闪烁
        System.Timers.Timer timer = new System.Timers.Timer();
        bool star = false; //背景是否闪烁
        bool is_exit = false; // 1点击关闭
        bool is_max = false;//最大化
        public Form1()
        {
            InitializeComponent();
            //this.Opacity = 0.8d;
            //this.StartPosition = FormStartPosition.CenterScreen;
            readSetting();
        }

        private void 文字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //输入提醒内容
            string str = Interaction.InputBox("输入", "提醒内容更改", "输入提醒内容", -1,-1);
            if (str != "")
            {
                button1.Text = str;
                writeSetting();
            }
        }


        private void 设置时间间隔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //设置计划任务
            if (OptScheduler.IsExists("ClockAlarmSchedule"))
            {
                OptScheduler.DeleteTask("ClockAlarmSchedule");
            }
            SetTimeForm f2 = new SetTimeForm();
            f2.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 取消提醒ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //取消计划任务
            if (OptScheduler.IsExists("ClockAlarmSchedule"))
            {
                OptScheduler.DeleteTask("ClockAlarmSchedule");
                MessageBox.Show("已取消定时提醒任务！");
            }
            else 
            {
                MessageBox.Show("未设置提醒任务！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //点击界面退出
            if (is_exit) {
                this.Close();
            }
            //鼠标点击显示和关闭菜单
            if (menuStrip1.Visible == false)
            {
                menuStrip1.Visible = true;
            }
            else
            {
                menuStrip1.Visible = false;
            }
        }

        private void changecolor(object source, ElapsedEventArgs e)
        {
            button1.BackColor = GetRandomColor();//设置背景为随机色
        }

        public System.Drawing.Color GetRandomColor()
        {
            //生成随机颜色
            Random RandomNum_First = new Random(Guid.NewGuid().GetHashCode());
            Random RandomNum_Sencond = new Random(Guid.NewGuid().GetHashCode());

            int int_Red = RandomNum_First.Next(256);
            int int_Green = RandomNum_Sencond.Next(256);
            int int_Blue = (int_Red + int_Green > 400) ? 0 : 400 - int_Red - int_Green;
            int_Blue = (int_Blue > 255) ? 255 : int_Blue;
            return System.Drawing.Color.FromArgb(100,int_Red, int_Green, int_Blue);
        }

        private void 背景闪烁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            star = !star;
            writeSetting();
        }

        private void 点击退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_exit = !is_exit;
            writeSetting();
        }

        private void 全屏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_max = !is_max;
            writeSetting();
            if (is_max)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
            else {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        //读取设置文件并设置选项
        public void readSetting() {
            if (File.Exists(config_file))
            {
                //获取背景闪烁和点击退出菜单项
                ToolStripItem[] starItems = menuStrip1.Items.Find("背景闪烁ToolStripMenuItem", true);
                ToolStripItem[] exitItems = menuStrip1.Items.Find("点击退出ToolStripMenuItem", true);
                ToolStripItem[] maxItems = menuStrip1.Items.Find("最大化ToolStripMenuItem", true);
               
                try
                {
                    //读取设置文件
                    FileStream fs = new FileStream(config_file, FileMode.Open, FileAccess.Read);
                    TextReader tr = new StreamReader(fs, Encoding.UTF8);
                    button1.Text = tr.ReadLine();
                    if (tr.ReadLine().Equals("1"))
                    {
                        star = true;
                        //背景闪烁，并设置文字颜色为白色
                        starItems[0].Text = "背景闪烁√";
                        button1.ForeColor = Color.White;
                        timer.Enabled = true;
                        timer.Interval = 500; //执行间隔时间,单位为毫秒; 这里实际间隔为10分钟  
                        timer.Start();
                        timer.Elapsed += new System.Timers.ElapsedEventHandler(changecolor);
                    }
                    else
                    {
                        star = false;
                        starItems[0].Text = "背景闪烁×";
                    }
                    if (tr.ReadLine().Equals("1"))
                    {
                        is_exit = true;
                        exitItems[0].Text = "点击界面关闭√";
                    }
                    else
                    {
                        is_exit = false;
                        exitItems[0].Text = "点击界面关闭×";
                    }
                    if (tr.ReadLine().Equals("1"))
                    {
                        is_max = true;
                        maxItems[0].Text = "最大化√";
                        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    }
                    else
                    {
                        is_max = false;
                        maxItems[0].Text = "最大化×";
                    }
                    tr.Close();
                    fs.Close();
                }
                catch{
                    MessageBox.Show("读取配置出错");
                }
            }
        }

        //写入配置并更改选项
        public void writeSetting() {
            if (!Directory.Exists(config_path))
            {
                Directory.CreateDirectory(config_path);
            }
            //获取背景闪烁和点击退出菜单项
            ToolStripItem[] starItems = menuStrip1.Items.Find("背景闪烁ToolStripMenuItem", true);
            ToolStripItem[] exitItems = menuStrip1.Items.Find("点击退出ToolStripMenuItem", true);
            ToolStripItem[] maxItems = menuStrip1.Items.Find("最大化ToolStripMenuItem", true);
            TextWriter tw = new StreamWriter(config_file, false, Encoding.UTF8);
            tw.WriteLine(button1.Text);
            if (star)
            {
                tw.WriteLine("1");
                starItems[0].Text = "背景闪烁√";
                button1.ForeColor = Color.White;
                timer.Enabled = true;
                timer.Interval = 500; //执行间隔时间,单位为毫秒; 这里实际间隔为10分钟  
                timer.Start();
                timer.Elapsed += new System.Timers.ElapsedEventHandler(changecolor);
            }
            else
            {
                tw.WriteLine("0");
                starItems[0].Text = "背景闪烁×";
                timer.Enabled = false;
                button1.ForeColor = Color.Black;
                button1.BackColor = System.Drawing.Color.Transparent;//取消颜色
            }
            if (is_exit)
            {
                tw.WriteLine("1");
                exitItems[0].Text = "点击界面关闭√";
            }
            else
            {
                tw.WriteLine("0");
                exitItems[0].Text = "点击界面关闭×";
            }
            if (is_max)
            {
                tw.WriteLine("1");
                maxItems[0].Text = "最大化√";
            }
            else {
                tw.WriteLine("0");
                maxItems[0].Text = "最大化×";
            }
            tw.Close();
        }

    }
}
