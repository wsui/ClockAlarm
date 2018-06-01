using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskScheduler;

namespace ClockAlarm
{
    public partial class SetTimeForm : Form
    {
        int hour = 0;
        int minute = 0;
        String exe_path = Application.ExecutablePath; //应用程序路径和名称
        public SetTimeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hour = (int)this.hour1.Value;
            minute = (int)this.minute1.Value;
            if (hour + minute == 0)
            {
                MessageBox.Show("间隔不能为0","错误提示");
                return;
            }
            if (hour > 23)
            {
                MessageBox.Show("小时不能超过23");
                hour1.Value = 23;
                return;
            }
            if (minute > 59)
            {
                MessageBox.Show("分钟不能超过59");
                minute1.Value = 59;
                return;
            }
            //创建者
            var creator = "ClockAlarm";
            //计划任务名称
            var taskName = "ClockAlarmSchedule";
            //执行的程序路径
            var path = exe_path;
            //计划任务执行的频率 PT1M一分钟  PT1H30M 90分钟
            var interval = "PT" + hour + "H" + minute + "M";
            //开始时间 请遵循 yyyy-MM-ddTHH:mm:ss 格式
            DateTime currentTime = DateTime.Now;
            currentTime = currentTime.AddHours(hour);
            currentTime = currentTime.AddMinutes(minute);
            var startBoundary = currentTime.ToString("yyyy-MM-ddTHH:mm:ss");  // "2015-04-09T14:27:25";

            var description = "这是一个定时提醒休息的计划任务，由程序ClockAlarm.exe创建和管理";
            _TASK_STATE state = OptScheduler.CreateTaskScheduler(creator, taskName, path, interval, startBoundary, description);
            if (state == _TASK_STATE.TASK_STATE_RUNNING)
            {
                String msg = "";
                if (hour > 0)
                {
                    msg = hour + "小时" + minute + "分钟间隔提醒任务添加成功!";
                }
                else
                {
                    msg = minute + "分钟间隔提醒任务添加成功!";
                }
                MessageBox.Show(msg);
            }
            this.Close();
            Application.Exit();
        }
    }
}
