using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using SpeechLib;
using System.Timers;




namespace KelimeEzberle
{
    public partial class Form1 : Form
    {
        System.Threading.Timer timer;
        public  List<Kelime> klm;
        public List<int> yazilan = new List<int>();
       
        public Form1()
        {
            InitializeComponent();
            KelimeYukle();

           TimerCallback cb = new TimerCallback(Zamanlayıcı);           
            timer = new System.Threading.Timer(cb);   
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            Zamanlayıcı(sender);           
        }
        public void KelimeYukle()
        {
            try
            {
                string constr = "Server=LOCALHOST\\SQLEXPRESS; Database=Words; Trusted_Connection=True";
                SqlConnection con = new SqlConnection(constr);
                SqlCommand com = new SqlCommand("select * from SonVRS where Isactive=1", con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                con.Open();
                //DataTable dt = new DataTable();
                //da.Fill(dt);            
                SqlDataReader dr = com.ExecuteReader();
                klm = new List<Kelime>();
                while (dr.Read())
                {
                    klm.Add(new Kelime { Eng = dr[1].ToString(), TR = dr[2].ToString(), Read = dr[3].ToString() });
                }
            }
            catch
            {
                
            }
            
        }

        public Kelime RandomWord(List<Kelime> kelimess)
        {
            Random rnd = new Random();
            tekrarla:
            int indexx = rnd.Next(kelimess.Count());
            if (!yazilan.Contains(indexx))
            {
                yazilan.Add(indexx);
                return kelimess[indexx];
            }
            else
                goto tekrarla;

        }
        public void RecursiveMetot()
        {            
            Kelime klmSingle = RandomWord(klm);            
            if (klmSingle.Read.ToString() != null)
            {
                lblEnglish.Invoke(new MethodInvoker(delegate { lblEnglish.Text = klmSingle.Eng.ToString(); }));
                lblReadly.Invoke(new MethodInvoker(delegate { lblReadly.Text = klmSingle.Read.ToString(); }));
                lblTurkish.Invoke(new MethodInvoker(delegate {lblTurkish.Text = klmSingle.TR.ToString(); }));
                 this.Invoke(new MethodInvoker(delegate { this.WindowState = FormWindowState.Normal; }));
            }

            Thread.Sleep(50000);
            this.Invoke(new MethodInvoker(delegate { this.WindowState = FormWindowState.Minimized; }));            
          
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //RecursiveMetot();
            //lblTurkish.Invoke(new MethodInvoker(delegate { lblTurkish.Visible = true; }));
        }  

        private void btnDinle_Click(object sender, EventArgs e)
        {
            SpVoice konus = new SpVoice();
            konus.Speak(lblEnglish.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }            

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {

            if (this.WindowState==FormWindowState.Maximized)
            {
                //notifyIcon1.Visible = false;
                //this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.TopMost = true;
                Form1.ActiveForm.Show();
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            //notifyIcon1.Visible = false;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            Form1.ActiveForm.Show();           
        }
        private void Zamanlayıcı(object obj)
        {
            RecursiveMetot();
            timer.Change(45000, 500000); 
        }      

        private void NotifIconArea()
        {
            notifyIcon1.Visible = true;
            this.Visible = false;
            notifyIcon1.ShowBalloonTip(500, "Memorize Words", "I'm still here", ToolTipIcon.Info);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                NotifIconArea();
            }
            else
                notifyIcon1.Visible = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Change(-1, -1);                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zamanlayıcı(sender);
        }     
       
    }
}
