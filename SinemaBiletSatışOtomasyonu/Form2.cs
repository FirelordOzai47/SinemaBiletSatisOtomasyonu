using SinemaBiletSatışOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletSatışOtomasyonu
{
    public partial class Form2 : Form
    {
        public Form2(List<Movie> _movies, Form1 _form1)
        {
            InitializeComponent();
            movies = _movies;
            form1 = _form1;
        }


        List<Movie> movies;
        Form1 form1;
        Movie selectedMovie;
        Session selectedSession;

        public void ListDetail(int _movieIndex, string _time, string _date)
        {

            selectedMovie = movies[_movieIndex];
            selectedSession = selectedMovie.sessions.Find(session => session.date == _date && session.time == _time);
            lblTime.Text = $"{_date}-{_time}";
            lblDakika.Text = selectedMovie.munite;
            lblÜcret.Text = selectedMovie.price.ToString() + " TL";
            pbSelectedPicture.Image = Image.FromFile(selectedMovie.picturePath);
            lblFilmİsmi.Text = selectedMovie.movieName.ToString();
            CheckChairStatus();

        }
        private void CheckChairStatus()
        {
            foreach (Control item in grbChairs.Controls)
            {
                if (item is Button)
                {

                    string row = item.Tag.ToString();
                    string number = item.Text;
                    item.Enabled = true;
                    foreach (Chair chair in selectedSession.chairs)
                    {
                        if (chair.row == row && chair.number == number)
                        {
                            if (chair.status)
                            {
                                item.BackColor = Color.DarkRed;
                                item.Enabled = false;
                            }
                            else
                            {
                                item.BackColor = Color.LightGreen;
                            }
                            break;
                        }
                    }

                }
            }
        }
        List<Chair> chairs = new List<Chair>();

        private void button24_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string row = button.Tag.ToString();
            string number = button.Text;
            Chair chair = selectedSession.chairs.Find(c => c.row == row && c.number == number);
            if (button.BackColor.Name != "Blue")
            {
                chairs.Add(chair);
                button.BackColor = Color.Blue;
            }
            else
            {
                chairs.Remove(chair);
                button.BackColor = Color.LightGreen;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (chairs.Count == 0)
            {
                MessageBox.Show("Lütfen en Az Bir Koltuk Seçiniz");
                return;
            }
            Sales sales = new Sales();
            sales.movieName = selectedMovie.movieName;
            sales.count = chairs.Count;
            sales.sessionTime = $"{selectedSession.date}-{selectedSession.time}";
            sales.totalPrice = CalculatePrice();

            foreach (Chair chair in chairs)
            {
                chair.status = true;
            }

            MessageBox.Show(sales.ToString());
            ChangePage();
        }
        private void ChangePage()
        {
            rbSmall.Checked = rbMedium.Checked = rbBig.Checked = false;
            chairs.Clear();
            this.Hide();
            form1.Show();
        }
        private decimal CalculatePrice()
        {
            decimal price = selectedMovie.price * chairs.Count;
            if (rbSmall.Checked)
            {
                price += 5;
            }
            else if (rbMedium.Checked)
            {
                price += 10;
            }
            else if (rbBig.Checked)
            {
                price += 13;
            }
            return price;   
            
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangePage();
        }
    }
    }

