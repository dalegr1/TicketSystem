using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            txtDate.Text = TicketInfo.Date.ToString();
            txtTime.Text = TicketInfo.Time.ToString();
            txtBatch.Text = TicketInfo.Batch.ToString();
            txtStation.Text = TicketInfo.Station.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
