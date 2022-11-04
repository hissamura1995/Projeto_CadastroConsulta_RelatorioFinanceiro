using System.Windows.Forms;

namespace Projeto_CadastroConsulta_RelatorioFinanceiro
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAgendamentos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.lblNomeUsuarioLogado = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.PanelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.button5);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.btnAgendamentos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(218, 548);
            this.panelMenu.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 359);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(218, 93);
            this.button5.TabIndex = 5;
            this.button5.Text = "    Início";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 266);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(218, 93);
            this.button4.TabIndex = 4;
            this.button4.Text = "    Início";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Image = global::Projeto_CadastroConsulta_RelatorioFinanceiro.Properties.Resources.boneco;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 173);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(218, 93);
            this.button3.TabIndex = 3;
            this.button3.Text = "    Pacientes";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAgendamentos
            // 
            this.btnAgendamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgendamentos.FlatAppearance.BorderSize = 0;
            this.btnAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamentos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgendamentos.Image = global::Projeto_CadastroConsulta_RelatorioFinanceiro.Properties.Resources.calendario;
            this.btnAgendamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendamentos.Location = new System.Drawing.Point(0, 80);
            this.btnAgendamentos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgendamentos.Name = "btnAgendamentos";
            this.btnAgendamentos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAgendamentos.Size = new System.Drawing.Size(218, 93);
            this.btnAgendamentos.TabIndex = 2;
            this.btnAgendamentos.Text = "    Agendamentos";
            this.btnAgendamentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgendamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgendamentos.UseVisualStyleBackColor = true;
            this.btnAgendamentos.Click += new System.EventHandler(this.btnAgendamentos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.btnLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(218, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // btnLogo
            // 
            this.btnLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(218, 80);
            this.btnLogo.TabIndex = 3;
            this.btnLogo.Text = "Logo";
            this.btnLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnMaximizar);
            this.panelTitulo.Controls.Add(this.btnFechar);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(218, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1021, 80);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(913, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 28);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Text = "O";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Location = new System.Drawing.Point(951, 2);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 28);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.Text = "O";
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(989, 2);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 28);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "O";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            this.btnFechar.MouseHover += new System.EventHandler(this.btnFechar_MouseHover);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(453, 24);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(63, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Início";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PanelCentral
            // 
            this.PanelCentral.Controls.Add(this.lblNomeUsuarioLogado);
            this.PanelCentral.Controls.Add(this.lblTimer);
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(218, 80);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(1021, 468);
            this.PanelCentral.TabIndex = 4;
            // 
            // lblNomeUsuarioLogado
            // 
            this.lblNomeUsuarioLogado.AutoSize = true;
            this.lblNomeUsuarioLogado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNomeUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuarioLogado.Location = new System.Drawing.Point(0, 0);
            this.lblNomeUsuarioLogado.Name = "lblNomeUsuarioLogado";
            this.lblNomeUsuarioLogado.Size = new System.Drawing.Size(138, 17);
            this.lblNomeUsuarioLogado.TabIndex = 7;
            this.lblNomeUsuarioLogado.Text = "Bem-vindo: [usuario]";
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(871, 2);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(44, 17);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "Timer";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 548);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.PanelCentral.ResumeLayout(false);
            this.PanelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAgendamentos;
        private Button btnFechar;
        private Button btnMinimizar;
        private Button btnMaximizar;
        private Timer timer;
        private Panel PanelCentral;
        private Label lblTimer;
        private Label lblNomeUsuarioLogado;
        private Button btnLogo;
    }
}

