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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Ticket obj = ticketBindingSource.Current as Ticket;
            if (obj != null)
            {
                using(frmTicketInfo frm = new frmTicketInfo(obj))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ticketBindingSource.Add(new Ticket()
            {
                Name = "Daniel",
                DefectType = "Security Defect",
                Date = Convert.ToDateTime("01/01/2000"),
                Time = Convert.ToDateTime("12:00 PM"),
                Batch = 3,
                Station = 17
            });
            ticketBindingSource.Add(new Ticket()
            {
                Name = "Bob",
                DefectType = "Other",
                Date = Convert.ToDateTime("05/22/2012"),
                Time = Convert.ToDateTime("4:00 PM"),
                Batch = 12,
                Station = 6
            });
        }


    }
}
