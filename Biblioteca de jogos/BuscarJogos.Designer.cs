﻿namespace Biblioteca_de_jogos
{
    partial class BuscarJogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarJogos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnTelaInicial = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMeusFavoritos = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLancamento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.resLancamento = new System.Windows.Forms.Label();
            this.resGenero = new System.Windows.Forms.Label();
            this.resNota = new System.Windows.Forms.Label();
            this.btnFavoritar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.resultsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameResultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imgGames = new System.Windows.Forms.PictureBox();
            this.cbJogos = new System.Windows.Forms.ComboBox();
            this.gameDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resultsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gameResultBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lblDev = new System.Windows.Forms.Label();
            this.lblPubli = new System.Windows.Forms.Label();
            this.resPubli = new System.Windows.Forms.Label();
            this.resDev = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameResultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameResultBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTelaInicial,
            this.btnMeusFavoritos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Size = new System.Drawing.Size(84, 20);
            this.btnTelaInicial.Text = "Tela Inicial";
            this.btnTelaInicial.Click += new System.EventHandler(this.btnTelaInicial_Click);
            // 
            // btnMeusFavoritos
            // 
            this.btnMeusFavoritos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeusFavoritos.Name = "btnMeusFavoritos";
            this.btnMeusFavoritos.Size = new System.Drawing.Size(113, 20);
            this.btnMeusFavoritos.Text = "Meus Favoritos";
            this.btnMeusFavoritos.Click += new System.EventHandler(this.btnMeusFavoritos_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(18, 70);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(445, 18);
            this.lblSubtitle.TabIndex = 10;
            this.lblSubtitle.Text = "Utilize a caixa de seleção para saber mais sobre determinado jogo";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 35);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 29);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Buscar Jogos";
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataMember = "results";
            this.resultsBindingSource.DataSource = this.gameResultBindingSource;
            // 
            // gameResultBindingSource
            // 
            this.gameResultBindingSource.DataSource = typeof(Biblioteca_de_jogos.Models.GameResult);
            // 
            // gameDetailsBindingSource
            // 
            this.gameDetailsBindingSource.DataSource = typeof(Biblioteca_de_jogos.Models.GameDetails);
            // 
            // lblLancamento
            // 
            this.lblLancamento.AutoSize = true;
            this.lblLancamento.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancamento.Location = new System.Drawing.Point(22, 203);
            this.lblLancamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLancamento.Name = "lblLancamento";
            this.lblLancamento.Size = new System.Drawing.Size(115, 18);
            this.lblLancamento.TabIndex = 13;
            this.lblLancamento.Text = "Lançamento:";
            this.lblLancamento.Visible = false;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(21, 235);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(73, 18);
            this.lblGenero.TabIndex = 14;
            this.lblGenero.Text = "Gênero:";
            this.lblGenero.Visible = false;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(21, 332);
            this.lblNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(131, 18);
            this.lblNota.TabIndex = 15;
            this.lblNota.Text = "Nota da crítica:";
            this.lblNota.Visible = false;
            // 
            // resLancamento
            // 
            this.resLancamento.AutoSize = true;
            this.resLancamento.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLancamento.Location = new System.Drawing.Point(184, 203);
            this.resLancamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resLancamento.Name = "resLancamento";
            this.resLancamento.Size = new System.Drawing.Size(0, 18);
            this.resLancamento.TabIndex = 17;
            // 
            // resGenero
            // 
            this.resGenero.AutoSize = true;
            this.resGenero.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resGenero.Location = new System.Drawing.Point(184, 235);
            this.resGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resGenero.Name = "resGenero";
            this.resGenero.Size = new System.Drawing.Size(0, 18);
            this.resGenero.TabIndex = 18;
            // 
            // resNota
            // 
            this.resNota.AutoSize = true;
            this.resNota.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resNota.Location = new System.Drawing.Point(184, 332);
            this.resNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resNota.Name = "resNota";
            this.resNota.Size = new System.Drawing.Size(0, 18);
            this.resNota.TabIndex = 19;
            // 
            // btnFavoritar
            // 
            this.btnFavoritar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavoritar.Location = new System.Drawing.Point(233, 150);
            this.btnFavoritar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFavoritar.Name = "btnFavoritar";
            this.btnFavoritar.Size = new System.Drawing.Size(146, 23);
            this.btnFavoritar.TabIndex = 20;
            this.btnFavoritar.Text = "Favoritar";
            this.btnFavoritar.UseVisualStyleBackColor = true;
            this.btnFavoritar.Visible = false;
            this.btnFavoritar.Click += new System.EventHandler(this.btnFavoritar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(21, 150);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // resultsBindingSource1
            // 
            this.resultsBindingSource1.DataMember = "results";
            this.resultsBindingSource1.DataSource = this.gameResultBindingSource;
            // 
            // gameResultBindingSource1
            // 
            this.gameResultBindingSource1.DataSource = typeof(Biblioteca_de_jogos.Models.GameResult);
            // 
            // imgGames
            // 
            this.imgGames.Location = new System.Drawing.Point(406, 175);
            this.imgGames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgGames.Name = "imgGames";
            this.imgGames.Size = new System.Drawing.Size(355, 205);
            this.imgGames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGames.TabIndex = 23;
            this.imgGames.TabStop = false;
            // 
            // cbJogos
            // 
            this.cbJogos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.resultsBindingSource, "id", true));
            this.cbJogos.DataSource = this.gameDetailsBindingSource1;
            this.cbJogos.DisplayMember = "name";
            this.cbJogos.DropDownHeight = 268;
            this.cbJogos.DropDownWidth = 357;
            this.cbJogos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJogos.FormattingEnabled = true;
            this.cbJogos.IntegralHeight = false;
            this.cbJogos.Location = new System.Drawing.Point(22, 113);
            this.cbJogos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbJogos.MaxLength = 100;
            this.cbJogos.Name = "cbJogos";
            this.cbJogos.Size = new System.Drawing.Size(357, 22);
            this.cbJogos.TabIndex = 24;
            this.cbJogos.ValueMember = "id";
            // 
            // gameDetailsBindingSource1
            // 
            this.gameDetailsBindingSource1.DataSource = typeof(Biblioteca_de_jogos.Models.GameDetails);
            // 
            // resultsBindingSource2
            // 
            this.resultsBindingSource2.DataMember = "results";
            this.resultsBindingSource2.DataSource = this.gameResultBindingSource1;
            // 
            // gameResultBindingSource2
            // 
            this.gameResultBindingSource2.DataSource = typeof(Biblioteca_de_jogos.Models.GameResult);
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.Location = new System.Drawing.Point(21, 298);
            this.lblDev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(146, 18);
            this.lblDev.TabIndex = 25;
            this.lblDev.Text = "Desenvolvedora:";
            this.lblDev.Visible = false;
            // 
            // lblPubli
            // 
            this.lblPubli.AutoSize = true;
            this.lblPubli.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPubli.Location = new System.Drawing.Point(21, 266);
            this.lblPubli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPubli.Name = "lblPubli";
            this.lblPubli.Size = new System.Drawing.Size(108, 18);
            this.lblPubli.TabIndex = 26;
            this.lblPubli.Text = "Publicadora:";
            this.lblPubli.Visible = false;
            // 
            // resPubli
            // 
            this.resPubli.AutoSize = true;
            this.resPubli.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resPubli.Location = new System.Drawing.Point(184, 266);
            this.resPubli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resPubli.Name = "resPubli";
            this.resPubli.Size = new System.Drawing.Size(0, 18);
            this.resPubli.TabIndex = 27;
            // 
            // resDev
            // 
            this.resDev.AutoSize = true;
            this.resDev.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resDev.Location = new System.Drawing.Point(183, 298);
            this.resDev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resDev.MaximumSize = new System.Drawing.Size(210, 0);
            this.resDev.Name = "resDev";
            this.resDev.Size = new System.Drawing.Size(0, 18);
            this.resDev.TabIndex = 28;
            // 
            // BuscarJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 427);
            this.Controls.Add(this.resDev);
            this.Controls.Add(this.resPubli);
            this.Controls.Add(this.lblPubli);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.cbJogos);
            this.Controls.Add(this.imgGames);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnFavoritar);
            this.Controls.Add(this.resNota);
            this.Controls.Add(this.resGenero);
            this.Controls.Add(this.resLancamento);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblLancamento);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BuscarJogos";
            this.Text = "Buscar Jogos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameResultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameResultBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMeusFavoritos;
        private System.Windows.Forms.ToolStripMenuItem btnTelaInicial;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLancamento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label resLancamento;
        private System.Windows.Forms.Label resGenero;
        private System.Windows.Forms.Label resNota;
        private System.Windows.Forms.Button btnFavoritar;
        private System.Windows.Forms.BindingSource gameDetailsBindingSource;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private System.Windows.Forms.BindingSource gameResultBindingSource;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource resultsBindingSource1;
        private System.Windows.Forms.BindingSource gameResultBindingSource1;
        private System.Windows.Forms.PictureBox imgGames;
        private System.Windows.Forms.ComboBox cbJogos;
        private System.Windows.Forms.BindingSource resultsBindingSource2;
        private System.Windows.Forms.BindingSource gameResultBindingSource2;
        private System.Windows.Forms.BindingSource gameDetailsBindingSource1;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblPubli;
        private System.Windows.Forms.Label resPubli;
        private System.Windows.Forms.Label resDev;
    }
}