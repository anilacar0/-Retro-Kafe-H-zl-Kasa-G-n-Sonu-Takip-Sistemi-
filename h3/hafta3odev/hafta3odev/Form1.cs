namespace hafta3odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class veriler()
        {
            public static int alim = 0; // alinan anlik masa
            public static int vergi = 0; // anlinan anlik vergi
            public static int hesap = 0; // alinan toplam + bahşiş


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            String[] kahveler = { "Small Coffee : 200tl ", "Medium Coffee : 300tl ", "Large Coffee : 400tl " };
            String[] frozenlar = { "Small Frozen : 200tl ", "Medium Frozen : 300tl ", "Large Frozen : 400tl " };
            String[] caylar = { "Small Tea : 50tl ", "Medium Tea : 100tl ", "Large Tea : 150tl " };

            //String tur = "";
            int i = 0;
            for (i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0) listBox1.Items.Add(kahveler[j]);
                    if (i == 1) listBox1.Items.Add(frozenlar[j]);
                    if (i == 2) listBox1.Items.Add(caylar[j]);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if ("anil" == textBox3.Text)
            {
                string bahsisx = textBox4.Text;
                veriler.alim += 220;
                if (int.TryParse(bahsisx, out int bahsis))
                {
                    veriler.hesap = veriler.hesap + 220 + bahsis;

                }
                else veriler.hesap += 220;
                //MessageBox.Show(veriler.hesap.ToString());
            }
            else MessageBox.Show("satici bulunamadı");

        }

        private void ortak_click(object sender, EventArgs e)
        {
            if ("anil" == textBox3.Text)
            {
                string bahsisx = textBox4.Text;
                Button tiklananbtn = (Button)sender;
                switch (tiklananbtn.Name)
                {
                    case "smcof":
                        veriler.alim += 220;
                        veriler.vergi += 20;
                        break;
                    case "mdcof":
                        veriler.alim += 330;
                        veriler.vergi += 30;
                        break;
                    case "lgcof":
                        veriler.alim += 440;
                        veriler.vergi += 40;
                        break;
                    case "smfro":
                        veriler.alim += 220;
                        veriler.vergi += 20;
                        break;
                    case "mdfro":
                        veriler.alim += 330;
                        veriler.vergi += 30;
                        break;
                    case "lgfro":
                        veriler.alim += 440;
                        veriler.vergi += 40;
                        break;
                    case "smtea":
                        veriler.alim += 50;
                        veriler.vergi += 5;
                        break;
                    case "mdtea":
                        veriler.alim += 100;
                        veriler.vergi += 10;
                        break;
                    case "lgtea":
                        veriler.alim += 150;
                        veriler.vergi += 15;
                        break;
                }
                int aratoplam = veriler.alim - veriler.vergi;
                label18.Text = aratoplam.ToString();
                label19.Text = veriler.vergi.ToString();
                label20.Text = veriler.alim.ToString();
            }
            else MessageBox.Show("satici bulunamadı");
            textBox4.Text = "";
        }
        private void button20_Click(object sender, EventArgs e){
            if (veriler.alim > 0)
            {
                MessageBox.Show("toplam tutar : " + veriler.alim.ToString());
                veriler.hesap += veriler.alim;
                veriler.alim = 0;
                label18.Text = "";
                label19.Text = "";
                label20.Text = "";
                textBox4.Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e){
            MessageBox.Show("Toplam gün sonu kazancı : "+veriler.hesap.ToString());
        }
    }
}
