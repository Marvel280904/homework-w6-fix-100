using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_W6
{
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        List<Button> b1 = new List<Button>();
        List<Button> b2 = new List<Button>();
        List<string> SudahTerjawab = new List<string>();
        string[] jawaban = File.ReadAllText("Wordle Word List.txt").Split(',');
        List<string> keyboard = new List<string>() {"Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M"};
        public static int size = 0; int count = 0; int x = 0; int y = 0; int judul = 0; int counter = 10;
        string words = ""; string judulgame = "WORDLE"; string tebakkata = ""; int wordlist = 0;
        int loc = 0; int indx = 0; int four = 4; int nb = 0; int lagi = 0; int cekmenang = 0;
        int cekdelete = 0; int a1 = 0; int a2 = 4; int kalah = 0; int a3 = 0; int a4 = 4;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Button a = new Button();
                    a.Tag = "button" + count;
                    a.Size = new Size(55, 55);
                    a.Font = new Font(a.Font.FontFamily, 20, FontStyle.Bold);
                    a.Location = new Point(5 + x, 5 + y);
                    b1.Add(a);
                    x += 55;
                    count++;
                }
                x = 0;
                y += 55;
            }
            foreach (Button btn in b1)
            {
                this.Controls.Add(btn);
            }

            count = 0;
            x = 0;
            y = 0;
            for (int i = 1; i <= 3; i++)
            {
                if (i == 3)
                {
                    counter -= 1;
                    loc += 30;
                }
                for (int j = 1; j <= counter; j++)
                {
                    Button b = new Button();
                    b.Tag = keyboard[count];
                    b.Text = keyboard[count];
                    b.Size = new Size(50, 50);
                    b.Font = new Font(b.Font.FontFamily, 18, FontStyle.Bold);
                    b.Location = new Point(305 + x + loc, 240 + y);
                    b2.Add(b);
                    x += 55;
                    count++;
                }
                x = 0;
                y += 55;
                loc += 25;
                counter--;
            }
            foreach (Button btn in b2)
            {
                this.Controls.Add(btn);
                btn.Click += btn2_Click;
            }

            
            words = jawaban[rnd.Next(0, jawaban.Length)];
            MessageBox.Show(words);
            desain.Text = "";
            timer.Start();
        }
        
        public void cekwordlist()
        {
            wordlist = 0;
            for(int n = 0; n < jawaban.Length; n++)
            {
                if (tebakkata == jawaban[n].ToString().ToUpper())
                {
                    wordlist = 1;
                }
            }
            if (wordlist != 1)
            {
                MessageBox.Show(tebakkata + " is not on the word list");
            }
            else
            {
                cekposisi();
                cekkalah();
                four += 5;
                nb += 5;
                cekdelete += 5;
            }
        }

        public void cekposisi()
        {
            lagi = 0;
            cekmenang = 0;
            SudahTerjawab.Clear();
            // cek hijau
            for (int i = 0; i < 5; i++)
            {
                SudahTerjawab.Add(words[i].ToString().ToUpper());
            }

            for (int i = nb; i <= four; i++)
            {
                if (b1[i].Text == words[lagi].ToString().ToUpper())
                {
                    b1[i].BackColor = Color.LightGreen;
                    SudahTerjawab[lagi] = "0";
                    cekmenang++;
                }
                lagi++;
            }
            if (cekmenang == 5)
            {
                MessageBox.Show("Wins");
                this.Close();
            }
            
            // cek kuning
            for (int i = a1; i <= a2; i++)
            {
                foreach (string cekhijau in SudahTerjawab)
                {
                    if (b1[i].Text == cekhijau && b1[i].BackColor !=Color.LightGreen)
                    {
                        b1[i].BackColor = Color.Yellow;
                        SudahTerjawab.Remove(b1[i].Text);
                        break;
                    }
                }
            }
            a2 += 5;
            a1 += 5;
        }

        public void cekkalah()
        {
            if (indx == (size * 5))
            {
                if (cekmenang != 5)
                {
                    MessageBox.Show("Lose");
                    this.Close();
                }
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (indx <= four  && (size * 5) != indx)
            {
                Button sndr = sender as Button;
                foreach (Button btn in b2)
                {
                    if (btn.Tag == sndr.Tag)
                    {
                        b1[indx].Text = btn.Text;
                    }
                }
                indx++;
                
            }   
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (judul == judulgame.Length)
            {
                judul = 0;
                desain.Text = "";
            }
            if (judul < judulgame.Length)
            {
                desain.Text = desain.Text + judulgame[judul];
                judul++;
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            tebakkata = "";
            if (indx == four + 1)
            {
                for (int i = nb; i <= four; i++)
                {
                    tebakkata += b1[i].Text; 
                }
                cekwordlist();
     
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (b1[cekdelete].Text != "")
            {
                b1[indx-1].Text = "";
                indx--;
                
            }
        }
    }
}
