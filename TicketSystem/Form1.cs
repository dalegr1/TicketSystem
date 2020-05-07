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
            if (!File.Exists("Tickets.txt"))
            {
                File.Create("Tickets.txt").Close();
                using (StreamWriter sw = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + "Tickets.txt"))
                {
                   // sw.WriteLine("N/A,N/A,1/1/2000 12:00:00 PM,0,0");
                    sw.Close();
                }
            }
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Ticket obj = ticketBindingSource.Current as Ticket;
            if (obj != null)
            {
                using (frmTicketInfo frm = new frmTicketInfo(obj))
                {
                    frm.ShowDialog();
                    Refresh();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ticketBindingSource.Add(new Ticket()
            {
                Name = "N/A",
                DefectType = "N/A",
                DateAndTime = Convert.ToDateTime("1/1/2000 12:00:00 PM"),
                Batch = 0,
                Station = 0
            });
            using (StreamWriter sw = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + "Tickets.txt"))
            {
                sw.WriteLine("N/A,N/A,1/1/2000 12:00:00 PM,0,0");
                sw.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        public void Refresh()
        {
            this.dataGridView.Rows.Clear();
            using (var reader = new StreamReader("Tickets.txt"))
            {
                List<string> Name = new List<string>();
                List<string> DefectType = new List<string>();
                List<string> DateAndTime = new List<string>();
                List<string> Batch = new List<string>();
                List<string> Station = new List<string>();
                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (!(line == ""))
                    {
                        Name.Add(values[0]);
                        DefectType.Add(values[1]);
                        DateAndTime.Add(values[2]);
                        Batch.Add(values[3]);
                        Station.Add(values[4]);
                    }

                }
                for (int x = 0; x < File.ReadLines("Tickets.txt").Count(); x++)
                {
                    // Aqui es donde estoy trabajando ahora intentando que se ponga rojo
                    // la row que tiene un TicketAge > 14 dias
                    TimeSpan TicketAge = (DateTime.Now - Convert.ToDateTime(DateAndTime[x]));
                    if ( TicketAge.TotalDays > 14)
                    {     
                        ticketBindingSource.Add(new Ticket()
                        {
                            Name = Name[x],
                            DefectType = DefectType[x],
                            DateAndTime = Convert.ToDateTime(DateAndTime[x]),
                            Batch = Convert.ToInt32(Batch[x]),
                            Station = Convert.ToInt32(Station[x])
                        });
                        dataGridView.Rows[x].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        ticketBindingSource.Add(new Ticket()
                        {
                            Name = Name[x],
                            DefectType = DefectType[x],
                            DateAndTime = Convert.ToDateTime(DateAndTime[x]),
                            Batch = Convert.ToInt32(Batch[x]),
                            Station = Convert.ToInt32(Station[x])
                        });
                    }
                    
                    
                }
            }
        }
    }
            
}
