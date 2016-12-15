using System;
using ShotgunGame.Model;
using System.Drawing;
using ShotgunGame.Presenters;

namespace ShotgunGame.View
{
    public partial class MainView : Syncfusion.Windows.Forms.MetroForm
    {
        public MainView()
        {
            InitializeComponent();
            CheckPlayerBullets();
        }

        private void SetLabels()
        {
            lbl_cBullets.Text = CounterModel.cBullets.ToString();
            lbl_cMove.Text = Presenter.cMove;
            lbl_cScore.Text = CounterModel.cScore.ToString();
            lbl_pBullets.Text = CounterModel.pBullets.ToString();
            lbl_pMove.Text = Presenter.pMove;
            lbl_pScore.Text = CounterModel.pScore.ToString();
            lbl_GameResult.Text = Presenter.gameResult;
        }

        NewMove newMove = new NewMove();

        private void btn_Shoot_Click(object sender, EventArgs e)
        {
            NewMove.Shoot();
            CheckPlayerBullets();
            SetLabels();
        }

        private void btn_Block_Click(object sender, EventArgs e)
        {
            NewMove.Block();
            SetLabels();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            NewMove.Reload();
            CheckPlayerBullets();
            SetLabels();
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
    }
}