using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Security_System_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bag.Open();
        }

        public enum enmOtag 
        {
            Umumy,
            Mobil,
            Gizlin
        }
        private Form1.enmOtag action;

        MySqlConnection bag = new MySqlConnection("server=169.254.74.134; port=3306; username=root; password=; database=security_system;");
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Visible = false;
            //bag.Close();
            //Magl_gorkez();
            //this.WindowState = FormWindowState.Maximized;
            Form2 esasy = new Form2();
            DialogResult dialogresult = esasy.ShowDialog();
            //esasy.WindowState = FormWindowState.Maximized;
            //this.Hide();
            
        }
        public void UmumyBashlat() 
        {
            this.action = enmOtag.Umumy;
            timer1.Enabled = true;
            label1.Visible = false;
            //bag.Close();
            Umumy_Magl_gorkez();
            this.WindowState = FormWindowState.Maximized;
        }

        public void MobilizasiyaBashlat()
        {
            this.action = enmOtag.Mobil;
            timer1.Enabled = false;
            label1.Visible = false;
            //bag.Close();
            Mobil_Magl_gorkez();
            this.WindowState = FormWindowState.Maximized;
        }

        public void GizlinBashlat()
        {
            this.action = enmOtag.Gizlin;
            timer1.Enabled = false;
            label1.Visible = false;
            //bag.Close();
            Gizlin_Magl_gorkez();
            this.WindowState = FormWindowState.Maximized;
        }


        private void RowyHasaplapAlertEtdir()
        {
            throw new NotImplementedException();
        }

        private void Umumy_Magl_gorkez()
        {
            try
            {
                //bag.Open();
                System.Data.DataTable dtt = new System.Data.DataTable();
                MySqlDataAdapter daa = new MySqlDataAdapter("select * from alert_times order by no DESC", bag);
                daa.Fill(dtt);
                data_grd.DataSource = dtt.DefaultView;
                data_grd.BorderStyle = BorderStyle.FixedSingle;
                data_grd.Columns[0].DefaultCellStyle.Font = new Font("Century Gothic", 20, FontStyle.Bold);
                data_grd.Columns[1].DefaultCellStyle.Font = new Font("Century Gothic", 20, FontStyle.Bold);
                data_grd.Columns[2].DefaultCellStyle.Font = new Font("Century Gothic", 20, FontStyle.Bold);
                data_grd.Columns[3].Visible = false;
                data_grd.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                data_grd.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //data_grd.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
                data_grd.Columns[0].Width = 250;
                data_grd.Columns[1].Width = 1200;
                for (int i = 0; i < data_grd.Rows.Count; i++)
                {
                    data_grd.Rows[i].Height = 75;
                    data_grd.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    data_grd.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
                }
                for (int k = 0; k < data_grd.Rows.Count; k++) { data_grd.Rows[k].Selected = false; }
                //bag.Close();
                timer1.Start();
            }
            catch (Exception ex)
            {
                timer1.Stop();
                if (ex.Message == "Unable to connect to any of the specified MySQL hosts.")
                {
                    MessageBox.Show("Maglumat bazasy işe göýberilmedik! Haýyş edýän bazany işlediň!");
                }
                else
                {
                    //MessageBox.Show(ex.Message);
                    Console.WriteLine(ex.Message);
                    Form1_Load(MessageBoxButtons.OK, null);
                }
            }
        }

        private void Mobil_Magl_gorkez()
        {
            try
            {
                //bag.Open();
                System.Data.DataTable dtt = new System.Data.DataTable();
                MySqlDataAdapter daa = new MySqlDataAdapter("select * from alert_times where nomer = '1' order by no DESC", bag);
                daa.Fill(dtt);
                data_grd.DataSource = dtt.DefaultView;
                data_grd.BorderStyle = BorderStyle.FixedSingle;
                data_grd.Columns[0].DefaultCellStyle.Font = new Font("Century Gothic", 20, FontStyle.Bold);
                data_grd.Columns[1].DefaultCellStyle.Font = new Font("Century Gothic", 20, FontStyle.Bold);
                data_grd.Columns[2].DefaultCellStyle.Font = new Font("Century Gothic", 20, FontStyle.Bold);
                data_grd.Columns[3].Visible = false;
                data_grd.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                data_grd.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //data_grd.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                data_grd.Columns[0].Width = 250;
                data_grd.Columns[1].Width = 1200;
                for (int i = 0; i < data_grd.Rows.Count; i++)
                {
                    data_grd.Rows[i].Height = 75;
                    data_grd.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    data_grd.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
                }
                for (int k = 0; k < data_grd.Rows.Count; k++) { data_grd.Rows[k].Selected = false; }
                //bag.Close();
                timer1.Start();
            }
            catch (Exception ex)
            {
                timer1.Stop();
                if (ex.Message == "Unable to connect to any of the specified MySQL hosts.")
                {
                    MessageBox.Show("Maglumat bazasy işe göýberilmedik! Haýyş edýän bazany işlediň!");
                }
                else
                {
                    //MessageBox.Show(ex.Message);
                    Console.WriteLine(ex.Message);
                    Form1_Load(MessageBoxButtons.OK, null);
                }
            }
        }

        private void Gizlin_Magl_gorkez()
        {
            try
            {
                //bag.Open();
                System.Data.DataTable dtt = new System.Data.DataTable();
                MySqlDataAdapter daa = new MySqlDataAdapter("select * from alert_times where nomer = '2' order by no DESC", bag);
                daa.Fill(dtt);
                data_grd.DataSource = dtt.DefaultView;
                data_grd.BorderStyle = BorderStyle.FixedSingle;
                data_grd.Columns[0].DefaultCellStyle.Font = new Font("Century Gothic", 20, FontStyle.Bold);
                data_grd.Columns[1].DefaultCellStyle.Font = new Font("Century Gothic", 20, FontStyle.Bold);
                data_grd.Columns[2].DefaultCellStyle.Font = new Font("Century Gothic", 20, FontStyle.Bold);
                data_grd.Columns[3].Visible = false;
                data_grd.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                data_grd.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //data_grd.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                data_grd.Columns[0].Width = 250;
                data_grd.Columns[1].Width = 1200;
                for (int i = 0; i < data_grd.Rows.Count; i++)
                {
                    data_grd.Rows[i].Height = 75;
                    data_grd.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    data_grd.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
                }
                for (int k = 0; k < data_grd.Rows.Count; k++) { data_grd.Rows[k].Selected = false; }
                //bag.Close();
                timer1.Start();
            }
            catch (Exception ex)
            {
                timer1.Stop();
                if (ex.Message == "Unable to connect to any of the specified MySQL hosts.")
                {
                    MessageBox.Show("Maglumat bazasy işe göýberilmedik! Haýyş edýän bazany işlediň!");
                }
                else
                {
                    //MessageBox.Show(ex.Message);
                    Console.WriteLine(ex.Message);
                    Form1_Load(MessageBoxButtons.OK, null);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            Tazele();
        }

        private void Tazele()
        {
            if (this.action == enmOtag.Umumy)
            {
                try
                {
                    //bag.Open();
                    System.Data.DataTable dtt = new System.Data.DataTable();
                    MySqlDataAdapter daa = new MySqlDataAdapter("select * from alert_times order by no DESC", bag);
                    daa.Fill(dtt);
                    data_grd.DataSource = dtt.DefaultView;
                    data_grd.BorderStyle = BorderStyle.FixedSingle;
                    data_grd.Columns[0].DefaultCellStyle.Font = new Font("Century Gothic", 20, FontStyle.Bold);
                    data_grd.Columns[1].DefaultCellStyle.Font = new Font("Century Gothic", 20, FontStyle.Bold);
                    data_grd.Columns[2].DefaultCellStyle.Font = new Font("Century Gothic", 20, FontStyle.Bold);
                    data_grd.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    data_grd.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //data_grd.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    data_grd.Columns[0].Width = 250;
                    data_grd.Columns[1].Width = 1200;
                    for (int i = 0; i < data_grd.Rows.Count; i++)
                    {
                        data_grd.Rows[i].Height = 75;
                        data_grd.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                        data_grd.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
                    }
                    for (int k = 0; k < data_grd.Rows.Count; k++) { data_grd.Rows[k].Selected = false; }
                    //bag.Close();
                    //RowyHasaplapAlertEtdir();
                    if (bag.State == ConnectionState.Open)
                    {
                        timer1.Start();
                    }
                    else
                    {
                        timer1.Stop();
                    }
                }
                catch (Exception ex)
                {
                    timer1.Stop();
                    if (ex.Message == "Unable to connect to any of the specified MySQL hosts.")
                    {
                        MessageBox.Show("Maglumat bazasy işe göýberilmedik! Haýyş edýän bazany işlediň!");
                    }
                    else
                    {
                        //MessageBox.Show(ex.Message);
                        Console.WriteLine(ex.Message);
                        Form1_Load(MessageBoxButtons.OK, null);
                    }
                }
            }
            else if (this.action == enmOtag.Mobil) 
            {
                Mobil_Magl_gorkez();
            }
            else if (this.action == enmOtag.Gizlin)
            {
                Gizlin_Magl_gorkez();
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(3000, "Duýduryş!", "Penjire gizlin görnüşe geçirildi!", ToolTipIcon.Info);
            }
        }

        private void penjiräniAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }

        private void çykToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            for (int k = 0; k < data_grd.Rows.Count; k++) { data_grd.Rows[k].Selected = false; }
            //bag.Close();
            timer1.Enabled = true;
            label1.Visible = false;
            Tazele();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
                pictureBox3.ImageLocation = "pics//off.png";
                timer1.Stop();
                System.Console.WriteLine("Off");
            }
            else
            {
                bag.Open();
                pictureBox3.ImageLocation = "pics//on.png";
                timer1.Start();
                System.Console.WriteLine("On");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Visible = false;
            //bag.Close();
            //Magl_gorkez();
            //this.WindowState = FormWindowState.Maximized;
            Form2 esasy = new Form2();
            DialogResult dialogresult = esasy.ShowDialog();
            //esasy.WindowState = FormWindowState.Maximized;
            //this.Hide();
        }
    }
}
