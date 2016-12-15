#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using ShotgunGame.Model;
using ShotgunGame.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
namespace ShotgunGame.View.Forms
{
    public partial class MainForm : Office2010Form, IMainForm
    {
        NewMove newMove = new NewMove();
        public MainForm()
        {
            InitializeComponent();
            pictureBox1.Image = null;
            CheckPlayerBullets();
            buttonAdv1.Visible = false;
            panel_Left_pMove.Visible = false;

            lbl_GameResult.Visible = false;
        }
        public string GameResultTxt
        {
            get
            {
                return lbl_GameResult.Text;
            }

            set
            {
                lbl_GameResult.Text = value;
            }
        }

        public Image ResultImage
        {
            get
            {
                return picBox_ResultImage.Image;
            }
            set
            {
                picBox_ResultImage.Image = value;
            }
        }


        #region Animations

        #region PANELS
        public void LeftPanelVisibility()
        {
            panel_Left.Visible = false;
            panel_Left_pMove.Visible = true;
        }
        #endregion

        #region MOUSEHOVER IMAGE DISPLAYER
        private void btn_Shoot_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pistolShoot;
        }
        private void btn_Reload_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.reload_mirrored;
        }
        private void btn_Block_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.BlockImage1;
        }
        private void btn_Shoot_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
        private void btn_Reload_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
        private void btn_Block_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
        private void picBox_cMove_Click(object sender, EventArgs e)
        {

        }
        private void btn_Shotgun_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.arnoldLoading;
        }
        private void btn_Shotgun_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
        #endregion

        #region TIMERS
        int blink;
        private void timer_shotGunBtn_Tick(object sender, EventArgs e)
        {
            blink++;

            if (blink == 1)
            {
                btn_Shotgun.BackColor = Color.OrangeRed;
            }
            else if (blink == 2)
            {
                btn_Shotgun.BackColor = Color.FromArgb(22, 165, 220);
                blink = 0;
            }
        }
        #endregion

        #region IMAGE GRAPHICS
        public void SetResultImage(Image img)
        {
            try
            {
                picBox_ResultImage.Image = img;

            }
            catch (Exception)
            {
                picBox_ResultImage.Image = null;
            }
        }
        public void SetResultImage()
        {
            GraphicsPresenter gp = new GraphicsPresenter(this);
            gp.SetImage_PicBoxCpu(this);
        }
        public void SetPlayerImage (Image img)
        {
            picBox_pMove.Image = img; 
        }
        public void SetCpuImage(Image img)
        {
            try
            {
                picBox_cMove.Image = img;
            }
            catch (Exception)
            {
                picBox_cMove.Image = null;
            }
        }
        public void SetCpuImage()
        {
            try
            {
                if (lbl_cMove.Text == "Shoot")
                {
                    SetCpuImage(Properties.Resources.shoot_mirrored);
                }
                else if (lbl_cMove.Text == "Block")
                {
                    SetCpuImage(Properties.Resources.BlockImage1);
                }
                else if (lbl_cMove.Text == "Reload")
                {
                    SetCpuImage(Properties.Resources.reloading);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }

        private void SetLabels()
        {
            lbl_cBullets.Text = CounterModel.cBullets.ToString();
            lbl_cScore.Text = CounterModel.cScore.ToString();
            lbl_pBullets.Text = CounterModel.pBullets.ToString();
            lbl_pScore.Text = CounterModel.pScore.ToString();
            lbl_cMove.Text = Presenter.cMove;
            lbl_pMove.Text = Presenter.pMove;
            lbl_GameResult.Text = Presenter.gameResult;

            CheckPlayerBullets();
            SetCpuImage();
            panel_Left.Visible = false;
            SetResultImage();
            ShotGunEnabled();
            buttonAdv1.Visible = true;
        } 
        public void SetPropertiesOnShsotgun()
        {
            lbl_cBullets.Text = CounterModel.cBullets.ToString();
            lbl_cScore.Text = CounterModel.cScore.ToString();
            lbl_pBullets.Text = CounterModel.pBullets.ToString();
            lbl_pScore.Text = CounterModel.pScore.ToString();
            lbl_cMove.Text = Presenter.cMove;
            lbl_pMove.Text = Presenter.pMove;
            lbl_GameResult.Text = Presenter.gameResult;
        }
        #endregion
        #endregion

        #region BUTTON EVENTHANDLERS
        private void btn_Shoot_Click(object sender, EventArgs e)
        {
            NewMove.Shoot();
            LeftPanelVisibility();
            SetPlayerImage(Properties.Resources.pistolShoot);
            SetLabels();
            lbl_GameResult.Visible = true;
        }
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            NewMove.Reload();
            LeftPanelVisibility();
            SetPlayerImage(Properties.Resources.reload_mirrored);
            SetLabels();
            lbl_GameResult.Visible = true;
        }
        private void btn_Block_Click(object sender, EventArgs e)
        {
            NewMove.Block();
            LeftPanelVisibility();
            SetPlayerImage(Properties.Resources.BlockImage1);
            SetLabels();
            lbl_GameResult.Visible = true;
        }
        private void btn_playAgain_Click(object sender, EventArgs e)
        {
            picBox_cMove.Image = null;
            picBox_pMove.Image = null;
            picBox_ResultImage.Image = null;
            lbl_cMove.Text = null;
            lbl_pMove.Text = null;

            panel_Left.Visible = true;
            buttonAdv1.Visible = false;
            panel_Left_pMove.Visible = false;

            lbl_GameResult.Visible = false;
        }
        private void btn_Shotgun_Click(object sender, EventArgs e)
        {
            ShotGunForm shotGunForm = new ShotGunForm();
            CounterModel.ResetOnShotGun();
            #region PROPERTIES
            btn_Shoot.Enabled = false;
            panel_ShotGunBtn.Visible = false;
            panel_ShotGunBtn.SendToBack();
            timer_shotGunBtn.Stop();
            picBox_cMove.Image = null;
            picBox_ResultImage.Image = null;
            picBox_pMove.Image = null;
            #endregion
            SetPropertiesOnShsotgun();
            shotGunForm.ShowDialog();
        }
        #endregion

        #region VIEW FUNCTIONS
        public void ShotGunEnabled()
        {
            if (GameModel.returnValue == 4 && CounterModel.pBullets >= 3)
            {
                ShotGunForm shotGunForm = new ShotGunForm();
                shotGunForm.gradientLabel1.Text = "BOTH GOT SHOTGUN!! BOTH WIN THE GAME!";
                shotGunForm.pictureBox1.Image = Properties.Resources.nopants;
                shotGunForm.ShowDialog();
                CounterModel.ResetOnShotGun();
            }
            if (CounterModel.pBullets >= 3)
            {
                panel_ShotGunBtn.Visible = true;
                panel_ShotGunBtn.SendToBack();
                timer_shotGunBtn.Interval = 300;
                timer_shotGunBtn.Start();
            }
            else if (GameModel.returnValue == 4)
            {
                picBox_cMove.Image = null;
                picBox_ResultImage.Image = null;
                picBox_pMove.Image = null;
                CounterModel.ResetOnShotGun();
                SetPropertiesOnShsotgun();
            }
        }

        public void CheckPlayerBullets()
        {
            if (CounterModel.pBullets == 0)
            {
                btn_Shoot.Enabled = false;
                btn_Shoot.BackColor = Color.Red;
            }
            else if (CounterModel.pBullets != 0)
            {
                btn_Shoot.Enabled = true;
                btn_Shoot.BackColor = Color.White;
            }
        }
        #endregion

        #region NOT IN USE
        private void FadePanelsTimer_Tick(object sender, EventArgs e)
        {
            //    panel_Left_pMove.Visible = true;

            //    panelWidth = panel_Left_pMove.Width;
            //    new_PanelWidth = panelWidth + 10;

            //    if (new_PanelWidth < 260)
            //    {
            //        panel_Left_pMove.Width = new_PanelWidth;
            //    }
            //    else if (new_PanelWidth > 260)
            //    {
            //        Left_FadePanelsTimer.Stop();
            //    }
            //}
            //public void right_FadeOutPanel()
            //{
            //    right_FadePanelsTimer.Interval = 10;
            //    right_FadePanelsTimer.Start();
        }
        private void right_FadePanelsTimer_Tick(object sender, EventArgs e)
        {
            //panelWidth = panel_Right.Width;
            //new_PanelWidth = panelWidth + 10;

            //if (new_PanelWidth < 260)
            //{
            //    panel_Right.Width = new_PanelWidth;
            //}
            //else if (new_PanelWidth > 260)
            //{
            //    right_FadePanelsTimer.Stop();
            //}
        }
        #endregion
    }

    public interface IMainForm
    {
        string GameResultTxt { get; set; }
        Image ResultImage { get; set; }

    }
}
