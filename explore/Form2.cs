using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace explore
{
    public partial class Form2 : Form
    {
        List<Thread> threadList = new List<Thread>();
        bool i = true;


        public Form2()
        {
            InitializeComponent();
        }
      
        public void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            threadList = new List<Thread>();
            List<string> listTextBox = new List<string>();
            listTextBox.Add(textBox2.Text);
            listTextBox.Add(textBox3.Text);
            listTextBox.Add(textBox4.Text);
             int x = 1;
            i = true;

            foreach (var item in listTextBox)
            {
                Random rd = new Random();
                int rng = rd.Next(500, 1000);


                TextnTime tt = new TextnTime() ;
                tt.Text = item;
                tt.Time = x * rng;
                x++;

                ParameterizedThreadStart start = new ParameterizedThreadStart(TextBox1);
                Thread thread = new Thread(start);
                threadList.Add(thread);
                thread.Start(tt);
            }

            //ThreadStart a = new ThreadStart(TextBox1);
            //thread_1 = new Thread(a);
            //ThreadStart b = new ThreadStart(TextBox2);
            //thread_2 = new Thread(b);
            //ThreadStart c = new ThreadStart(TextBox3);
            //thread_3 = new Thread(c);
          //  thread_1.Start();
            //thread_2.Start();
            //thread_3.Start();
        }
        private void TextBox1(object textntime)
        {
            TextnTime time = (TextnTime)textntime;
            while (i == true)
            {
                Action<string> ac = new Action<string>(SetValue);
                this.Invoke(ac, time.Text);
                Thread.Sleep(time.Time);
            }
        }
        //private void TextBox2()
        //{
        //    while (true)
        //    {
        //        Action ac = new Action(SetValue2);
        //        this.Invoke(ac);
        //        Thread.Sleep(2000);
        //    }


        //}
        //private void TextBox3()
        //{
        //    while (true)
        //    {
        //        Action ac = new Action(SetValue3);
        //        this.Invoke(ac);
        //        Thread.Sleep(1000);
        //    }


        //}

        private void SetValue(string text)
        {
            textBox1.Text = textBox1.Text + Environment.NewLine + text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = false;

        }


    }
}
