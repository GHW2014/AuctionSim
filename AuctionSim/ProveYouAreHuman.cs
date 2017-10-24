using System;
using System.Drawing;
using System.Windows.Forms;

namespace AuctionSim
{
    public partial class ProveYouAreHuman : Form
    {
        string RandomCode = "";
        public ProveYouAreHuman()
        {
            InitializeComponent();
        }

        public ProveYouAreHuman(MainForm f)
        {
            InitializeComponent();
            this.Owner = f;
            this.Location = new Point(f.Location.X + 430, f.Location.Y + 270);

        }

        private void ProveYouAreHuman_Load(object sender, EventArgs e)
        {
            MainForm.fInVerify = true;
            MainForm.fVerifyResult = false;
            MainForm.fAntiRobot = true;
        }

        public void Init(int Price)
        {
            lblOutput.Text = "您的出价为：" + Price.ToString() + "元";
            RandomCode = CreateRandomCode(4);
            CreateImage(RandomCode);
            this.ShowDialog();
        }

        /// 生成随机码
        /// </summary>
        /// <param name="length">随机码个数</param>
        /// <returns></returns>
        private string CreateRandomCode(int length)
        {
            int rand;
            char code;
            string randomcode = String.Empty;

            //生成一定长度的验证码
            System.Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                rand = random.Next();
                code = (char)('0' + (char)(rand % 10));
                //if (rand % 3 == 0)
                //{
                //    code = (char)('A' + (char)(rand % 26));
                //}
                //else
                //{
                //    code = (char)('0' + (char)(rand % 10));
                //}

                randomcode += code.ToString();
            }
            return randomcode;
        }

        /// <summary>
        /// 创建随机码图片
        /// </summary>
        /// <param name="randomcode">随机码</param>
        private void CreateImage(string randomcode)
        {
            int randAngle = 15; //随机转动角度
            Bitmap map = new Bitmap(120, 44);//创建图片背景
            Graphics graph = Graphics.FromImage(map);
            graph.Clear(Color.AliceBlue);//清除画面，填充背景
            graph.DrawRectangle(new Pen(Color.Black, 0), 0, 0, map.Width - 1, map.Height - 1);//画一个边框
                                                                                              //graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//模式

            Random rand = new Random();

            //背景噪点生成
            Pen blackPen = new Pen(Color.LightGray, 0);
            for (int i = 0; i < 50; i++)
            {
                int x = rand.Next(0, map.Width);
                int y = rand.Next(0, map.Height);
                graph.DrawRectangle(blackPen, x, y, 1, 1);
            }


            //验证码旋转，防止机器识别
            char[] chars = randomcode.ToCharArray();//拆散字符串成单字符数组

            //文字距中
            StringFormat format = new StringFormat(StringFormatFlags.NoClip);
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            //定义颜色
            Color[] c = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };
            //定义字体
            string[] font = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体" };
            int cindex = rand.Next(7);

            for (int i = 0; i < chars.Length; i++)
            {
                int findex = rand.Next(5);

                Font f = new System.Drawing.Font(font[findex], 24, System.Drawing.FontStyle.Bold);//字体样式(参数2为字体大小)
                Brush b = new System.Drawing.SolidBrush(c[cindex]);

                Point dot = new Point(14, 24);
                //graph.DrawString(dot.X.ToString(),fontstyle,new SolidBrush(Color.Black),10,150);//测试X坐标显示间距的
                float angle = rand.Next(-randAngle, randAngle);//转动的度数

                graph.TranslateTransform(dot.X, dot.Y);//移动光标到指定位置
                graph.RotateTransform(angle);
                graph.DrawString(chars[i].ToString(), f, b, 1, 1, format);
                //graph.DrawString(chars[i].ToString(),fontstyle,new SolidBrush(Color.Blue),1,1,format);
                graph.RotateTransform(-angle);//转回去
                graph.TranslateTransform(6, -dot.Y);//移动光标到指定位置，每个字符紧凑显示，避免被软件识别
            }
            //生成图片
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            map.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            //Response.ClearContent();
            //Response.ContentType = "image/gif";
            //Response.BinaryWrite(ms.ToArray());
            ptbRead.Image = System.Drawing.Image.FromStream(ms);
            graph.Dispose();
            map.Dispose();
        }

        private void rtbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only accept number
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rtbInput.Text == RandomCode)
            {
                MainForm.fVerifyResult = true;
            }
            else
            {
                MainForm.fVerifyResult = false;
            }
            this.Close();
            MainForm.fAntiRobot = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProveYouAreHuman_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.fInVerify = false;
            MainForm.fStartAntiRobot = true;
        }
    }
}
