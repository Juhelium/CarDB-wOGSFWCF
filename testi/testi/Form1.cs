using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testi.ServiceReference1;
namespace testi
{
    public partial class Form1 : Form
    {
        //ServiceReference1.Service1Client
        //Uri url = new Uri("http://localhost:51224/Service1.svc");
        Service1Client palvelu = new Service1Client();
        int ID;
        public Form1()
        {
            // controlmain = new controller.MainController();          //doot 🎺
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ID =SetCount(ID);
            DisplayMerkki();
            DisplayMalli();
            DisplayFuel();
            DisplayColor();
        }

        private int SetCount(int id)
        {
            ServiceReference1.Auto auto = new ServiceReference1.Auto();
            return id = auto.Id;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void testOrSomethingToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        bool tryconn = palvelu();
        //        if (tryconn == true)
        //        {
        //            MessageBox.Show("The code decides to work somehow!");
        //        }
        //        else
        //        {
        //            MessageBox.Show("☭Straight to Gulag☭");
        //        }
        //    }
        //    catch (Exception rip)
        //    {
        //        MessageBox.Show(rip.ToString());
        //    }
        //}

        private void merkkibox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int merkinmalli = (int)merkkibox.SelectedIndex;
            var malli = palvelu.getAutoModelsByMakerId(merkinmalli);
            mallibox.DataSource = malli;
            mallibox.ValueMember = "MalliId";
            mallibox.DisplayMember = "Malliname";
        }

        private void DisplayMerkki()
        {
            var merkki = palvelu.getAllAutoMakersFromDatabase1();
            merkkibox.DataSource = merkki;
            merkkibox.ValueMember = "Id";
            merkkibox.DisplayMember = "Valmistaja";
        }

        private void DisplayMalli()
        {
            ServiceReference1.Malli model = new ServiceReference1.Malli();
            var malli = palvelu.getAutoModelsByMakerId(model.MalliId);
            mallibox.DataSource = malli;
            mallibox.ValueMember = "MalliId";
            mallibox.DisplayMember = "Malliname";
        }

        private void DisplayFuel()
        {
            var fuel = palvelu.GetAutoFuels(ID);
            fuelbox.DataSource = fuel;
            fuelbox.ValueMember = "FuelId";
            fuelbox.DisplayMember = "FuelName";
        }

        private void DisplayColor()
        {
            var color = palvelu.GetAutoColors();
            colorbox.DataSource = color;
            colorbox.ValueMember = "ColorId";
            colorbox.DisplayMember = "ColorName";
        }

        private void addstuff_Click(object sender, EventArgs e)
        {
            int affected=0;
            ServiceReference1.Auto car = new ServiceReference1.Auto();
            car.Hinta = int.Parse(hintabox.Text);
            car.Mottoritila = decimal.Parse(motilabox.Text);
            car.Mittarilukema = int.Parse(mittariluksbox.Text);
            car.Merkki = (int)merkkibox.SelectedValue;
            car.Malli = (int)mallibox.SelectedValue;
            car.Color = (int)colorbox.SelectedValue;
            car.Fuel = (int)fuelbox.SelectedValue;
            car.Pvm = pvmBox.Value;
            affected=palvelu.saveAutoIntoDatabase(car);
            MessageBox.Show(affected+" rows affected.");
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            ServiceReference1.Auto carnext = palvelu.GetNextAuto(ID);
            ID = carnext.Id;  
            DisplayCar(carnext);
        }

        private void pervbutton_Click(object sender, EventArgs e)
        {
            ServiceReference1.Auto carperv = palvelu.GetPrevious(ID);
            ID = carperv.Id;
            DisplayCar(carperv);
        }

        private void DisplayCar(ServiceReference1.Auto car)
        {
            mittariluksbox.Text = car.Mittarilukema.ToString();
            motilabox.Text = car.Mottoritila.ToString();
            hintabox.Text = car.Hinta.ToString();
            merkkibox.SelectedValue = car.Merkki;
            mallibox.SelectedValue = car.Malli;
            fuelbox.SelectedValue = car.Fuel;
            colorbox.SelectedValue = car.Color;
            pvmBox.Value = car.Pvm;
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            int affected = 0;
            //ServiceReference1.Auto car = new ServiceReference1.Auto();
            affected = palvelu.DelCar(ID);
            MessageBox.Show(affected+" rows affected.");
        }
    }
}
