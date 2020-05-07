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
                using (frmTicketInfo frm = new frmTicketInfo(obj))
                {
                    frm.ShowDialog();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            using (var reader = new StreamReader("Tickets.txt"))
            {
                List<string> Name = new List<string>();
                List<string> DefectType = new List<string>();
                List<string> Date = new List<string>();
                List<string> Time = new List<string>();
                List<string> Batch = new List<string>();
                List<string> Station = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Name.Add(values[0]);
                    DefectType.Add(values[1]);
                    Date.Add(values[2]);
                    Time.Add(values[3]);
                    Batch.Add(values[4]);
                    Station.Add(values[5]);

                }
                for (int x = 0; x < File.ReadLines("Tickets.txt").Count(); x++)
                    ticketBindingSource.Add(new Ticket()
                    {
                        Name = Name[x],
                        DefectType = DefectType[x],
                        Date = Convert.ToDateTime(Date[x]),
                        Time = Convert.ToDateTime(Time[x]),
                        Batch = Convert.ToInt32(Batch[x]),
                        Station = Convert.ToInt32(Station[x])
                    });
            }
            /*
            ticketBindingSource.Add(new Ticket()
            {
                Name = "N/A",
                DefectType = "New Ticket",
                Date = Convert.ToDateTime("01/01/2000"),
                Time = Convert.ToDateTime("00:00"),
                Batch = Convert.ToInt32("0"),
                Station = Convert.ToInt32("0")
            });*/
        }
    }
}
