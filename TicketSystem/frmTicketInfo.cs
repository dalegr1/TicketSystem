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
            text = text.Replace("N/A,New Ticket,1/1/2000 12:00:00 PM,0,0"
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
           

    }
}


