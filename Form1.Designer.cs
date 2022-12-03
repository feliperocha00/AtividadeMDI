namespace Concessionaria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seuCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarSeusCarrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirUmCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.seuCarroToolStripMenuItem,
            this.fornecedorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(344, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.atualizarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(101, 36);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(189, 36);
            this.createToolStripMenuItem.Text = "Cadastrar";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(189, 36);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(189, 36);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(189, 36);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click_1);
            // 
            // seuCarroToolStripMenuItem
            // 
            this.seuCarroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarSeusCarrosToolStripMenuItem,
            this.atualizarCadastroToolStripMenuItem,
            this.excluirUmCarroToolStripMenuItem});
            this.seuCarroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.seuCarroToolStripMenuItem.Name = "seuCarroToolStripMenuItem";
            this.seuCarroToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            this.seuCarroToolStripMenuItem.Text = "Seu Carro";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(317, 36);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // consultarSeusCarrosToolStripMenuItem
            // 
            this.consultarSeusCarrosToolStripMenuItem.Name = "consultarSeusCarrosToolStripMenuItem";
            this.consultarSeusCarrosToolStripMenuItem.Size = new System.Drawing.Size(317, 36);
            this.consultarSeusCarrosToolStripMenuItem.Text = "Consultar seus Carros";
            this.consultarSeusCarrosToolStripMenuItem.Click += new System.EventHandler(this.consultarSeusCarrosToolStripMenuItem_Click);
            // 
            // atualizarCadastroToolStripMenuItem
            // 
            this.atualizarCadastroToolStripMenuItem.Name = "atualizarCadastroToolStripMenuItem";
            this.atualizarCadastroToolStripMenuItem.Size = new System.Drawing.Size(317, 36);
            this.atualizarCadastroToolStripMenuItem.Text = "Atualizar Cadastro";
            this.atualizarCadastroToolStripMenuItem.Click += new System.EventHandler(this.atualizarCadastroToolStripMenuItem_Click);
            // 
            // excluirUmCarroToolStripMenuItem
            // 
            this.excluirUmCarroToolStripMenuItem.Name = "excluirUmCarroToolStripMenuItem";
            this.excluirUmCarroToolStripMenuItem.Size = new System.Drawing.Size(317, 36);
            this.excluirUmCarroToolStripMenuItem.Text = "Excluir um Carro";
            this.excluirUmCarroToolStripMenuItem.Click += new System.EventHandler(this.excluirUmCarroToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(147, 36);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1090, 549);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seuCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarSeusCarrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirUmCarroToolStripMenuItem;
    }
}

