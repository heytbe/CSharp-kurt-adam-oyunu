using kurtadamsaldirisi.Models;

namespace kurtadamsaldirisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        Account account= new Account();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            account.userName = txtUserName.Text;
            account.race = cmbheytbe.SelectedItem.ToString();
            account.branch = cmbBranch.SelectedItem.ToString();
            account.weapon = txtWeapon.Text;
            ChangeState(false);
            ChangeVisible(true);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lblHealt.Width = 250;
            lblhumanhealt.Width = 250;
            pcbWolfMan.Visible = true;

        }

        public void ChangeState(bool state)
        {
            txtUserName.Enabled = state;
            txtWeapon.Enabled = state;
            cmbBranch.Enabled = state;
            cmbRace.Enabled = state;
            btnSelect.Enabled = state;
        }

        public void ChangeVisible(bool isVisible)
        {
            lblHealt.Visible = pcbWolfMan.Visible = btnAttack.Visible = lblhumanhealt.Visible = isVisible;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            account.Attack();
            lblHealt.Width -= account.damage;
            MessageBox.Show($"Düþmana {account.damage} kadar hasar verdiniz");
            account.HumanHealt();
            lblhumanhealt.Width -= account.humanHealt;
            MessageBox.Show($"Ýnsana {account.humanHealt} kadar hasar verdiniz");
            if(lblHealt.Width<=0) {
                MessageBox.Show("Düþmaný Yendiniz");
                pcbWolfMan.Visible = false;
            }else if(lblhumanhealt.Width<=0)
            {
                MessageBox.Show("Ýnsan yenildi");
            }
        }
    }
}