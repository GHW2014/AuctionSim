using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace AuctionSim
{
    public partial class MainForm : Form
    {
        int FlowSeconds = 0;
        System.Timers.Timer timer;
        DateTime FlowSequence = Convert.ToDateTime("11:27:00");

        int AcceptPrice;
        private int cntBid = 1;
        private int BidPrice = 100;
        private string BidTime = "10:36:23";

        string strLineHead = "2016年3月16日上海个人非营业性客车额度拍卖会" + "\n"
            + "投放额度数：8310" + "\n"
            + "目前已投标人数：221109" + "\n"
            + "拍卖会起止时间：10:30至11:30" + "\n"
            + "首次出价时段：10:30至11:00" + "\n"
            + "修改出价时段：11:00至11:30" + "\n\n";
        string strLine1 = "    目前为修改出价时段";
        string strLine2 = "\n系统当前时间：";
        string strLine3 = "\n目前最低可成交价：";
        string strLine4 = "\n最低可成交价出价时间：";
        string strLine5 = "\n目前数据库接受处理价格区间：";

        string strBidInforPreHead = "您第";
        string strBidInforPostHead = "次出价";
        string strBidInfor1 = "\n出价金额：";
        string strBidInfor2 = "\n出价时间：2016-03-16 ";
        string strBidInfor3 = "\n出价方式：网络出价";
        
        public static bool fInVerify = false;
        public static bool fVerifyResult = false;
        public static bool fAntiRobot = false;
        public static bool fStartAntiRobot = false;
        private int cntAntiRobot = 0;

        private int Scheme = 0;
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            System.Random random = new Random();
            Scheme = random.Next(5);

            rtbOutput.BackColor = Color.White;
            rtbOutput.ReadOnly = true;

            MessageBox.Show("即将进入最后三分钟模拟流程，点击OK键继续");
            DisplayBidStatus();
            StartProcess();
        }

        private void StartProcess()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Thread.CurrentThread.IsBackground = false;

            FlowSeconds++;
            FlowSequence = FlowSequence.AddSeconds(1);
            AcceptPrice = CalculatePrice(FlowSeconds);
            DisplayInfor();
            if (true == fStartAntiRobot)
            {
                if (cntAntiRobot++ > 5)
                {
                    cntAntiRobot = 0;
                    fAntiRobot = false;
                    fStartAntiRobot = false;
                }
            }
            if (180 == FlowSeconds)
            {
                EndProcess();
            }
        }

        private void EndProcess()
        {
            try
            {
                timer.Stop();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "ProveYouAreHuman")
                    {
                        frm.Close();
                        break;
                    }
                }
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "InforBox")
                    {
                        frm.Close();
                        break;
                    }
                }
                tbxPriceAdd.Enabled = false;
                tbxPriceBid.Enabled = false;
                btnAdd.Enabled = false;
                btnBid.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                MessageBox.Show("模拟结束，点击查看拍卖结果！");
                if (BidPrice >= AcceptPrice)
                {
                    InforBox ifb = new InforBox(this);
                    ifb.OutputInfor("恭喜您成交了，\n中标价格："+ BidPrice.ToString());
                }
                else
                {
                    InforBox ifb = new InforBox(this);
                    ifb.OutputInfor("对不起您没有成交，\n最低价格：" + AcceptPrice.ToString() + "\n您的出价：" + BidPrice.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DisplayInfor()
        {
            rtbOutput.Clear();
            rtbOutput.SelectionFont = new System.Drawing.Font("宋体", 10F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ((System.Byte)(0)));
            rtbOutput.SelectionColor = Color.Red;
            rtbOutput.AppendText(strLineHead);

            rtbOutput.SelectionFont = new System.Drawing.Font("宋体", 10F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ((System.Byte)(0)));
            rtbOutput.SelectionColor = Color.DarkCyan;
            rtbOutput.AppendText(strLine1);
            
            rtbOutput.SelectionFont = new System.Drawing.Font("宋体", 10F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ((System.Byte)(0)));
            rtbOutput.SelectionColor = Color.DarkCyan;
            rtbOutput.AppendText(strLine2);

            rtbOutput.SelectionFont = new System.Drawing.Font("宋体", 10F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,
                ((System.Byte)(0)));
            rtbOutput.SelectionColor = Color.Red;
            rtbOutput.AppendText(FlowSequence.ToString("HH:mm:ss"));

            rtbOutput.SelectionFont = new System.Drawing.Font("宋体", 10F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ((System.Byte)(0)));
            rtbOutput.SelectionColor = Color.DarkCyan;
            rtbOutput.AppendText(strLine3);

            rtbOutput.SelectionFont = new System.Drawing.Font("宋体", 10F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,
                ((System.Byte)(0)));
            rtbOutput.SelectionColor = Color.Red;
            rtbOutput.AppendText(AcceptPrice.ToString());

            rtbOutput.SelectionFont = new System.Drawing.Font("宋体", 10F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ((System.Byte)(0)));
            rtbOutput.SelectionColor = Color.DarkCyan;
            rtbOutput.AppendText(strLine4);

            rtbOutput.SelectionFont = new System.Drawing.Font("宋体", 10F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,
                ((System.Byte)(0)));
            rtbOutput.SelectionColor = Color.Red;
            rtbOutput.AppendText("");

            rtbOutput.SelectionFont = new System.Drawing.Font("宋体", 10F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ((System.Byte)(0)));
            rtbOutput.SelectionColor = Color.DarkCyan;
            rtbOutput.AppendText(strLine5);

            rtbOutput.SelectionFont = new System.Drawing.Font("宋体", 10F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,
                ((System.Byte)(0)));
            rtbOutput.SelectionColor = Color.Red;
            rtbOutput.AppendText((AcceptPrice - 300).ToString() + "至" + (AcceptPrice + 300).ToString());

            lblOutput.Text = "目前最低可成交价： " + AcceptPrice.ToString() + " 元";
        }

        private void DisplayBidStatus()
        {
            string tmp = strBidInforPreHead + cntBid.ToString() + strBidInforPostHead
                + strBidInfor1 + BidPrice.ToString()
                + strBidInfor2 + BidTime
                + strBidInfor3;
            lblBidStatus.Text = tmp;
        }

        int CalculatePrice(int s)
        {
            int y = 0;
            switch (Scheme)
            {
                case 0:
                    if (s > 140) { y = (int)(0.4 * (s - 140) + 818.67) * 100; }
                    else { y = 81800; }
                    break;
                case 1:
                    if (s > 140) { y = (int)(0.35 * (s - 140) + 841.33) * 100; }
                    else { y = 84100; }
                    break;
                case 2:
                    if (s > 140) { y = (int)(0.15 * (s - 140) + 819) * 100; }
                    else { y = 81900; }
                    break;
                case 3:
                    if (s > 140) { y = (int)(0.45 * (s - 140) + 816.33) * 100; }
                    else { y = 81600; }
                    break;
                case 4:
                    if (s > 140) { y = (int)(0.45 * (s - 140) + 813) * 100; }
                    else { y = 81300; }
                    break;
                default:
                    y = 85100;
                    break;
            }

            return y;
        }

        private void tbxPriceAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only accept number
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void tbxPriceBid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only accept number
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check price validity
            if (tbxPriceAdd.Text != "")
            {
                int data = Convert.ToInt32(tbxPriceAdd.Text);
                if (data % 100 == 0)
                {
                    data = AcceptPrice + data;
                    tbxPriceBid.Text = data.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int data = AcceptPrice - 300;
            tbxPriceBid.Text = data.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int data = AcceptPrice - 200;
            tbxPriceBid.Text = data.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int data = AcceptPrice - 100;
            tbxPriceBid.Text = data.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int data = AcceptPrice + 300;
            tbxPriceBid.Text = data.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int data = AcceptPrice + 200;
            tbxPriceBid.Text = data.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int data = AcceptPrice + 100;
            tbxPriceBid.Text = data.ToString();
        }

        private void btnBid_Click(object sender, EventArgs e)
        {
            // check price validity
            if (tbxPriceBid.Text == "") { return; }
            int data = Convert.ToInt32(tbxPriceBid.Text);
            if (data % 100 != 0) { return; }

            // limit two biding
            if (cntBid > 2)
            {
                InforBox ifb = new InforBox(this);
                ifb.OutputInfor("三次出价机会已用完！");
                return;
            }

            // anti robot check
            if (true == fAntiRobot)
            {
                InforBox ifb = new InforBox(this);
                ifb.OutputInfor("操作过于频繁！");
                return;
            }

            try
            {
                // check the verification code
                if (false == fInVerify)
                {
                    ProveYouAreHuman vbp = new ProveYouAreHuman(this);
                    vbp.Init(data);
                }
            }
            catch (Exception ex)
            {

            }

            if (true == fAntiRobot)
            {
                return;
            }

            // check random code verification
            if (false == fVerifyResult)
            {
                InforBox ifb = new InforBox(this);
                ifb.OutputInfor("验证码输入错误");
            }
            else
            {
                // check the price is validated
                if (data >= (AcceptPrice - 300) && data <= (AcceptPrice + 300))
                {
                    InforBox ifb = new InforBox(this);
                    ifb.OutputInfor("出价有效");
                    BidPrice = data;
                    cntBid += 1;
                    BidTime = FlowSequence.ToString("HH:mm:ss");
                    DisplayBidStatus();
                }
                else
                {
                    InforBox ifb = new InforBox(this);
                    ifb.OutputInfor("您的出价不在目前数据库接受处理价格区间");
                }
            }

        }
    }
}
