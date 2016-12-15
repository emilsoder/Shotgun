#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace ShotgunGame.View
{
    partial class MainView
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
            this.btn_Shoot = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btn_Block = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btn_Reload = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cBullets = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lbl_cScore = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lbl_pScore = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lbl_pBullets = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lbl_cMove = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lbl_pMove = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lbl_GameResult = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Shoot
            // 
            this.btn_Shoot.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btn_Shoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btn_Shoot.BeforeTouchSize = new System.Drawing.Size(100, 27);
            this.btn_Shoot.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shoot.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Shoot.IsBackStageButton = false;
            this.btn_Shoot.Location = new System.Drawing.Point(0, 105);
            this.btn_Shoot.Name = "btn_Shoot";
            this.btn_Shoot.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.btn_Shoot.Size = new System.Drawing.Size(100, 27);
            this.btn_Shoot.TabIndex = 1;
            this.btn_Shoot.Text = "Shoot";
            this.btn_Shoot.UseVisualStyle = true;
            this.btn_Shoot.Click += new System.EventHandler(this.btn_Shoot_Click);
            // 
            // btn_Block
            // 
            this.btn_Block.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btn_Block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btn_Block.BeforeTouchSize = new System.Drawing.Size(100, 27);
            this.btn_Block.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Block.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Block.IsBackStageButton = false;
            this.btn_Block.Location = new System.Drawing.Point(0, 138);
            this.btn_Block.Name = "btn_Block";
            this.btn_Block.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.btn_Block.Size = new System.Drawing.Size(100, 27);
            this.btn_Block.TabIndex = 2;
            this.btn_Block.Text = "Block";
            this.btn_Block.UseVisualStyle = true;
            this.btn_Block.Click += new System.EventHandler(this.btn_Block_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btn_Reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btn_Reload.BeforeTouchSize = new System.Drawing.Size(100, 27);
            this.btn_Reload.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Reload.IsBackStageButton = false;
            this.btn_Reload.Location = new System.Drawing.Point(0, 171);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.btn_Reload.Size = new System.Drawing.Size(100, 27);
            this.btn_Reload.TabIndex = 3;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyle = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.lbl_cBullets);
            this.gradientPanel1.Controls.Add(this.lbl_cScore);
            this.gradientPanel1.Controls.Add(this.lbl_pScore);
            this.gradientPanel1.Controls.Add(this.lbl_pBullets);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(273, 89);
            this.gradientPanel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "CPU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bullets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bullets";
            // 
            // lbl_CpuBullets
            // 
            this.lbl_cBullets.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lbl_cBullets.BeforeTouchSize = new System.Drawing.Size(42, 23);
            this.lbl_cBullets.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lbl_cBullets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cBullets.Location = new System.Drawing.Point(218, 29);
            this.lbl_cBullets.Name = "lbl_CpuBullets";
            this.lbl_cBullets.Size = new System.Drawing.Size(42, 23);
            this.lbl_cBullets.TabIndex = 3;
            this.lbl_cBullets.Text = "0";
            this.lbl_cBullets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CpuScore
            // 
            this.lbl_cScore.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lbl_cScore.BeforeTouchSize = new System.Drawing.Size(42, 23);
            this.lbl_cScore.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lbl_cScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cScore.Location = new System.Drawing.Point(218, 52);
            this.lbl_cScore.Name = "lbl_CpuScore";
            this.lbl_cScore.Size = new System.Drawing.Size(42, 23);
            this.lbl_cScore.TabIndex = 2;
            this.lbl_cScore.Text = "0";
            this.lbl_cScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PlayerScore
            // 
            this.lbl_pScore.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lbl_pScore.BeforeTouchSize = new System.Drawing.Size(42, 23);
            this.lbl_pScore.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lbl_pScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pScore.Location = new System.Drawing.Point(10, 52);
            this.lbl_pScore.Name = "lbl_PlayerScore";
            this.lbl_pScore.Size = new System.Drawing.Size(42, 23);
            this.lbl_pScore.TabIndex = 1;
            this.lbl_pScore.Text = "0";
            this.lbl_pScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PlayerBullets
            // 
            this.lbl_pBullets.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lbl_pBullets.BeforeTouchSize = new System.Drawing.Size(42, 23);
            this.lbl_pBullets.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lbl_pBullets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pBullets.Location = new System.Drawing.Point(10, 29);
            this.lbl_pBullets.Name = "lbl_PlayerBullets";
            this.lbl_pBullets.Size = new System.Drawing.Size(42, 23);
            this.lbl_pBullets.TabIndex = 0;
            this.lbl_pBullets.Text = "0";
            this.lbl_pBullets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.Gray,
            System.Drawing.Color.Silver,
            System.Drawing.Color.DarkGray});
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.gradientLabel1.BorderAppearance = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientLabel1.BorderColor = System.Drawing.Color.Gray;
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.ForeColor = System.Drawing.Color.Black;
            this.gradientLabel1.Location = new System.Drawing.Point(121, 160);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(141, 23);
            this.gradientLabel1.TabIndex = 5;
            this.gradientLabel1.Text = "CPU MOVE";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CpuMove
            // 
            this.lbl_cMove.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lbl_cMove.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.lbl_cMove.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lbl_cMove.Location = new System.Drawing.Point(121, 183);
            this.lbl_cMove.Name = "lbl_CpuMove";
            this.lbl_cMove.Size = new System.Drawing.Size(141, 23);
            this.lbl_cMove.TabIndex = 6;
            this.lbl_cMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.SlateGray,
            System.Drawing.Color.Silver,
            System.Drawing.Color.LightSlateGray});
            this.gradientLabel2.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.gradientLabel2.BorderAppearance = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientLabel2.BorderColor = System.Drawing.Color.Gray;
            this.gradientLabel2.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gradientLabel2.Location = new System.Drawing.Point(121, 105);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(141, 23);
            this.gradientLabel2.TabIndex = 8;
            this.gradientLabel2.Text = "YOUR MOVE";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PlayerMove
            // 
            this.lbl_pMove.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lbl_pMove.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.lbl_pMove.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lbl_pMove.Location = new System.Drawing.Point(121, 128);
            this.lbl_pMove.Name = "lbl_PlayerMove";
            this.lbl_pMove.Size = new System.Drawing.Size(141, 23);
            this.lbl_pMove.TabIndex = 7;
            this.lbl_pMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GameResult
            // 
            this.lbl_GameResult.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.DimGray,
            System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))))});
            this.lbl_GameResult.BeforeTouchSize = new System.Drawing.Size(273, 52);
            this.lbl_GameResult.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lbl_GameResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_GameResult.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GameResult.Location = new System.Drawing.Point(0, 246);
            this.lbl_GameResult.Name = "lbl_GameResult";
            this.lbl_GameResult.Size = new System.Drawing.Size(273, 52);
            this.lbl_GameResult.TabIndex = 9;
            this.lbl_GameResult.Text = "Game result";
            this.lbl_GameResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarColor = System.Drawing.Color.Silver;
            this.CaptionButtonColor = System.Drawing.Color.DimGray;
            this.CaptionButtonHoverColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(273, 298);
            this.Controls.Add(this.lbl_GameResult);
            this.Controls.Add(this.gradientLabel2);
            this.Controls.Add(this.lbl_pMove);
            this.Controls.Add(this.lbl_cMove);
            this.Controls.Add(this.gradientLabel1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_Block);
            this.Controls.Add(this.btn_Shoot);
            this.Name = "MainView";
            this.ShowIcon = false;
            this.Text = "MetroForm1";
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        public Syncfusion.Windows.Forms.Tools.GradientLabel lbl_cBullets;
        public Syncfusion.Windows.Forms.Tools.GradientLabel lbl_cScore;
        public Syncfusion.Windows.Forms.Tools.GradientLabel lbl_pScore;
        public Syncfusion.Windows.Forms.Tools.GradientLabel lbl_pBullets;
        public Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        public Syncfusion.Windows.Forms.Tools.GradientLabel lbl_cMove;
        public Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel2;
        public Syncfusion.Windows.Forms.Tools.GradientLabel lbl_pMove;
        public Syncfusion.Windows.Forms.Tools.GradientLabel lbl_GameResult;
        public Syncfusion.Windows.Forms.ButtonAdv btn_Shoot;
        public Syncfusion.Windows.Forms.ButtonAdv btn_Block;
        public Syncfusion.Windows.Forms.ButtonAdv btn_Reload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}