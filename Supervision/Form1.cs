using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supervision
{
    public partial class frm_spv : Form
    {
        public frm_spv()
        {
            InitializeComponent();
        }

        private void frm_spv_Load(object sender, EventArgs e)
        {
            tb_clients.ReadOnly = true;
            tb_clientsgroup.ReadOnly = true;
            tb_table.ReadOnly = true;
            tb_plate.ReadOnly = true;
            

            tb_clients.Text = Supervision.Clients.ToString();
            tb_clientsgroup.Text = Supervision.ClientsGroups.ToString();
            tb_plate.Text = Supervision.Plates.ToString();
            tb_table.Text = Supervision.TablesUsed.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
