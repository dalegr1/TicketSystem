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
            txtDate.Text = TicketInfo.Date.ToString();
            txtTime.Text = TicketInfo.Time.ToString();
            txtBatch.Text = TicketInfo.Batch.ToString();
            txtStation.Text = TicketInfo.Station.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
                using (StreamWriter sw = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + "Tickets.txt"))
                {
                    sw.WriteLine(txtName.Text + "," +
                                 txtDefectType.Text + "," +
                                 txtDate.Text + "," +
                                 txtTime.Text + "," +
                                 txtBatch.Text + "," +
                                 txtStation.Text);
                    sw.Close();
                    Process.Start(AppDomain.CurrentDomain.BaseDirectory + "Tickets.txt");
                }
        }
            /*
            Form Form1 = new Form();
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;

            string[] textData = System.IO.File.ReadAllLines("Tickets.Txt");
            string[] headers = textData[0].Split(',');

            DataTable dataTable1 = new DataTable();
            foreach (string header in headers)
                dataTable1.Columns.Add(header, typeof(string), null);
            for (int i = 1; i < textData.Length; i++)
                dataTable1.Rows.Add(textData[i].Split(','));

            dataGridView.DataSource = dataTable1;
            Form1.Controls.Add(dataGridView);
            Form1.ShowDialog();
            */
        

    }
}


