using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Wash_Simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
    

      

        public void timer1_Tick(object sender, EventArgs e)
        {
           
            
            textBox1.Text = WashDuration.ToString();
            WashDuration--;
            label1.Text = "Washing";
            if (WashDuration == -1)
            {
            timer1.Stop();
            timer2.Start();
            }

        }

        public void timer2_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DryDuration.ToString();
            DryDuration--;        
            label1.Text = "Drying";
            if (DryDuration == -1)
            {   
              //  label1.Text = "Car is cleaned.";
                timer2.Stop();
                timer3.Start();
                //button1.Enabled = true;
                //button1.Text = "Clean Next Car";
                
            }
        }

            //A CarWash is made as cw
             Carwash CW = new Carwash();
             CarWashManager CWM = new CarWashManager();
             int WashDuration;
             int DryDuration;
             int IndoorDuration;

        public void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
                /* CW.ResetWash();
                 CW.ResetDry();
                 CW.WashTimeSet(CWM.CurCar());          
                 WashDuration = CW.WashTime;
                 DryDuration = CW.DryTime;*/

                 CW.job(CWM.CurCar(), out WashDuration, out DryDuration, out IndoorDuration);

                 label2.Text = CWM.CurCar().size;
                 pName.Text = CWM.CurCar().CarName;
                 if (CWM.islastcar())
                 {
                     label1.Text = "There are no more cars to clean.";
                 }
                 else
                 { 
                     this.timer1.Start();
                     this.timer1.Enabled = true;
                     CWM.NextCar();
                 }
                 

            



            // A Volkwagon comes in with the size of Wagon.
            /*Vehicle Volkswagon = new Vehicle("Wagon");
            //CW will now set the time for the car.   
            cw.WashTimeSet(Volkswagon);
            cw.DryTimeSet(Volkswagon);
            WashDuration = cw.WashTime;
            DryDuration = cw.DryTime;*/
                  
            // Plan is put a WashTime and DryTime in timer. Car from list sets time and then gets cleaned.
            //After the timer runs out, it loops back and updates the car.
            // When the list ends the simulation ends.
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            textBox1.Text = IndoorDuration.ToString();
            IndoorDuration--;
            label1.Text = "Cleaning Interior";
            if (IndoorDuration == -1)
            {
                label1.Text = "Car is cleaned.";
                timer3.Stop();
                button1.Enabled = true;
                button1.Text = "Clean Next Car";

            }
        }

        
    }
}
