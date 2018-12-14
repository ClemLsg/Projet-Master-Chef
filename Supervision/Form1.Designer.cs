namespace Supervision
{
    partial class frm_spv
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_clients = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_clientsgroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_plate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_table = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_clients
            // 
            this.tb_clients.Location = new System.Drawing.Point(176, 36);
            this.tb_clients.Name = "tb_clients";
            this.tb_clients.Size = new System.Drawing.Size(100, 20);
            this.tb_clients.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Groupes de clients";
            // 
            // tb_clientsgroup
            // 
            this.tb_clientsgroup.Location = new System.Drawing.Point(176, 62);
            this.tb_clientsgroup.Name = "tb_clientsgroup";
            this.tb_clientsgroup.Size = new System.Drawing.Size(100, 20);
            this.tb_clientsgroup.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Plats servis";
            // 
            // tb_plate
            // 
            this.tb_plate.Location = new System.Drawing.Point(176, 88);
            this.tb_plate.Name = "tb_plate";
            this.tb_plate.Size = new System.Drawing.Size(100, 20);
            this.tb_plate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tables utilisées";
            // 
            // tb_table
            // 
            this.tb_table.Location = new System.Drawing.Point(176, 114);
            this.tb_table.Name = "tb_table";
            this.tb_table.Size = new System.Drawing.Size(100, 20);
            this.tb_table.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_spv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_table);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_plate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_clientsgroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_clients);
            this.Name = "frm_spv";
            this.Text = "frm_spv";
            this.Load += new System.EventHandler(this.frm_spv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_clientsgroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_plate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_table;
        private System.Windows.Forms.Button button1;
    }
}

