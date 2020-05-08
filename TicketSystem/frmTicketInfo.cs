using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace TicketSystem
{
    public partial class frmTicketInfo : Form
    {
        public Ticket TicketInfo { get; set; }
        public frmTicketInfo()
        {
            InitializeComponent();
        }
        public frmTicketInfo(Ticket std)
        {
            InitializeComponent();
            TicketInfo = std;
        }
        private void frmTicketInfo_Load(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you an administrator?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteButton.Enabled = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                DeleteButton.Enabled = false;
                DeleteButton.Text = "Disabled";
            }

            txtName.Text = TicketInfo.Name;
            txtDefectType.Text = TicketInfo.DefectType;
            txtDateAndTime.Text = TicketInfo.DateAndTime.ToString();
            txtBatch.Text = TicketInfo.Batch.ToString();
            txtStation.Text = TicketInfo.Station.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string text = File.ReadAllText("Tickets.txt");
            text = text.Replace(TicketInfo.Name + "," +
                                TicketInfo.DefectType + "," +
                                TicketInfo.DateAndTime.ToString() + "," +
                                Convert.ToString(TicketInfo.Batch) + "," +
                                Convert.ToString(TicketInfo.Station)
                                ,
                                txtName.Text + "," +
                                 txtDefectType.Text + "," +
                                 txtDateAndTime.Text + "," +
                                 txtBatch.Text + "," +
                                 txtStation.Text
                                );
            text = text.Replace("N/A,N/A,1/1/2000 12:00:00 PM,0,0"
                                ,
                                txtName.Text + "," +
                                 txtDefectType.Text + "," +
                                 txtDateAndTime.Text + "," +
                                 txtBatch.Text + "," +
                                 txtStation.Text
                                );
            File.WriteAllText("Tickets.txt", text);
            //Process.Start(AppDomain.CurrentDomain.BaseDirectory + "Tickets.txt");

        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {

            if (!File.Exists("ResolvedTickets.txt"))
            {
                File.Create("ResolvedTickets.txt").Close();
                using (StreamWriter sw = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + "ResolvedTickets.txt"))
                {
                    sw.WriteLine(txtName.Text + "," +
                                 txtDefectType.Text + "," +
                                 txtDateAndTime.Text + "," +
                                 txtBatch.Text + "," +
                                 txtStation.Text + "," +
                                 txtProblem.Text + "," +
                                 txtAction.Text);
                    sw.Close();

                    //  Process.Start(AppDomain.CurrentDomain.BaseDirectory + "ResolvedTickets.txt");
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + "ResolvedTickets.txt"))
                {
                    sw.WriteLine(txtName.Text + "," +
                                 txtDefectType.Text + "," +
                                 txtDateAndTime.Text + "," +
                                 txtBatch.Text + "," +
                                 txtStation.Text + "," +
                                 txtProblem.Text + "," +
                                 txtAction.Text);
                    sw.Close();
                    //Process.Start(AppDomain.CurrentDomain.BaseDirectory + "ResolvedTickets.txt");

                    
                }
            

            }
            string text = File.ReadAllText("Tickets.txt");
            text = text.Replace(TicketInfo.Name + "," +
                                TicketInfo.DefectType + "," +
                                TicketInfo.DateAndTime.ToString() + "," +
                                Convert.ToString(TicketInfo.Batch) + "," +
                                Convert.ToString(TicketInfo.Station) + "\r\n"
                                ,
                                ""
                                );
            File.WriteAllText("Tickets.txt", text);
            //Process.Start(AppDomain.CurrentDomain.BaseDirectory + "Tickets.txt");
        }
    }
}


