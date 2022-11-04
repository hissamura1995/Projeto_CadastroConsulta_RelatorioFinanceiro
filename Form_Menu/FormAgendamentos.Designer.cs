namespace Projeto_CadastroConsulta_RelatorioFinanceiro.Form_Menu
{
    partial class FormAgendamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CPFCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonePrincipal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneSecundario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataHoraAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPFCliente,
            this.NomeCliente,
            this.TelefonePrincipal,
            this.TelefoneSecundario,
            this.DataHoraAgendamento,
            this.StatusAgendamento});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(999, 372);
            this.dataGridView1.TabIndex = 10;
            // 
            // CPFCliente
            // 
            this.CPFCliente.HeaderText = "CPF";
            this.CPFCliente.Name = "CPFCliente";
            this.CPFCliente.Width = 150;
            // 
            // NomeCliente
            // 
            this.NomeCliente.HeaderText = "Nome";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.Width = 350;
            // 
            // TelefonePrincipal
            // 
            this.TelefonePrincipal.HeaderText = "Telefone Primário";
            this.TelefonePrincipal.Name = "TelefonePrincipal";
            // 
            // TelefoneSecundario
            // 
            this.TelefoneSecundario.HeaderText = "Telefone Secundário";
            this.TelefoneSecundario.Name = "TelefoneSecundario";
            // 
            // DataHoraAgendamento
            // 
            this.DataHoraAgendamento.HeaderText = "Data/Hora Agendamento";
            this.DataHoraAgendamento.Name = "DataHoraAgendamento";
            this.DataHoraAgendamento.Width = 150;
            // 
            // StatusAgendamento
            // 
            this.StatusAgendamento.HeaderText = "Status";
            this.StatusAgendamento.Name = "StatusAgendamento";
            this.StatusAgendamento.Width = 120;
            // 
            // FormAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 429);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(218, 80);
            this.Name = "FormAgendamentos";
            this.Text = "Agendamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonePrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneSecundario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHoraAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusAgendamento;
    }
}