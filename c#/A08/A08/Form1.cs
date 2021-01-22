using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace A08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Car car;
        SoundPlayer hornPlayer = new SoundPlayer(@"sounds\horn.wav");
        SoundPlayer enginePlayer = new SoundPlayer(@"sounds\engine.wav");

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCars.Items.Add(new Car("Porsche", 250));
            comboBoxCars.Items.Add(new Car("Opel", 90));
            comboBoxCars.Items.Add(new Car("Ferrari", 370));
            comboBoxCars.DisplayMember = "Brand";
            
        }

        private void comboBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            breakButton.Enabled = true;
            accButton.Enabled = true;
            car = comboBoxCars.SelectedItem as Car;
            kmhBox.Text = Convert.ToString(car.Speed);
            gearBox.Text = Convert.ToString(car.Gear);
            if (car.EngineStarted)
            {
                engineLight.BackColor = Color.LightGreen;
            }
            else
            {
                engineLight.BackColor = Color.Silver;
            }
            psLabel.Text = Convert.ToString(car.Ps) + " PS";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (car.Speed == 0)
            {
                if (car.EngineStarted)
                {
                    car.EngineStarted = false;
                    engineLight.BackColor = Color.Silver;
                }
                else
                {
                    car.EngineStarted = true;
                    engineLight.BackColor = Color.LightGreen;
                    enginePlayer.Play();
                }
            }

            
            
        }

        private void accButton_MouseDown(object sender, MouseEventArgs e)
        {
            accTimer.Enabled = true;
            accTimer.Start();
        }

        private void accButton_MouseUp(object sender, MouseEventArgs e)
        {
            accTimer.Stop();
        }
        private void accTimer_Tick(object sender, EventArgs e)
        {
            if (car.EngineStarted)
            {
                car.Accelerate();
                kmhBox.Text = Convert.ToString(car.Speed);
                gearBox.Text = Convert.ToString(car.Gear);
            }

        }

        private void breakButton_MouseDown(object sender, MouseEventArgs e)
        {
            breakTimer.Enabled = true;
            breakTimer.Start();
        }

        private void breakButton_MouseUp(object sender, MouseEventArgs e)
        {
            breakTimer.Stop();
        }
        private void breakTimer_Tick(object sender, EventArgs e)
        {
            car.Break();
            kmhBox.Text = Convert.ToString(car.Speed);
            gearBox.Text = Convert.ToString(car.Gear);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (car.EngineStarted)
            {
                hornPlayer.Play();
            }
            
        }
    } 


}
