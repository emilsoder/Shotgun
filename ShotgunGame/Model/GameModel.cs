using ShotgunGame.Presenters;
using ShotgunGame.View.Forms;

namespace ShotgunGame.Model
{
    public class GameModel : CounterModel
    {        
        public static int playerMove { get; set; }
        public static int returnValue { get; set; }

        public static void RegenerateValue()
        {
            if (returnValue > 1)
            {
                if (playerMove == 1)
                {
                    ShootMove();
                }
                else if (playerMove == 2)
                {
                    BlockMove();
                }
                else if (playerMove == 3)
                {
                    ReloadMove();
                }
            }
            else if (returnValue == 1)
            {
                AIEngineModel.GenerateValue();
                RegenerateValue();
            }
        }

        public static void ShootMove()
        {
            //Shoot = 1;
            playerMove = 1;

            if (returnValue == 1)
            {
                if (cBullets == 0)
                {
                   RegenerateValue();
                }
                else if (cBullets != 0)
                {
                    PlayerBullets((-1));
                    CpuBullets((-1));
                    Presenter.ShootShoot();
                }
            }
            else if (returnValue == 2)
            {
                PlayerBullets((-1));
                Presenter.ShootBlock();
            }
            else if (returnValue == 3)
            {
                PlayerBullets(-1);
                PlayerScore(1);
                Presenter.ShootReload();
            }
            else if (returnValue == 4)
            {
                ShotGunForm shotGunForm = new ShotGunForm();
                shotGunForm.gradientLabel1.Text = "CPU WON THE GAME! YOU GOT SHOTGUNNED!";
                shotGunForm.pictureBox1.Image = Properties.Resources.ezgif_com_add_text_1_;
                shotGunForm.ShowDialog();
            }
        }
        public static void BlockMove()
        {
            //Block = 2;
            playerMove = 2;

            if (returnValue == 1)
            {
                if (cBullets != 0)
                {
                    CpuBullets((-1));
                    Presenter.BlockShoot();
                }
                else if (cBullets == 0)
                {
                    RegenerateValue();
                }
            }
            else if (returnValue == 2)
            {
                Presenter.BlockBlock();
            }
            else if (returnValue == 3)
            {
                CpuBullets(1);
                Presenter.BlockReload();
            }
            else if (returnValue == 4)
            {
                ShotGunForm shotGunForm = new ShotGunForm();
                shotGunForm.gradientLabel1.Text = "CPU WON THE GAME! YOU GOT SHOTGUNNED!";
                shotGunForm.pictureBox1.Image = Properties.Resources.ezgif_com_add_text_1_;
                shotGunForm.ShowDialog();
            }
        }
        public static void ReloadMove()
        {
            //Reload = 3;
            playerMove = 3;

            if (returnValue == 1)
            {
                if (cBullets == 0)
                {
                    RegenerateValue();
                }
                else if (cBullets != 0)
                {
                    CpuBullets(-1);
                    CpuScore(1);
                    Presenter.ReloadShoot();
                }
            }
            else if (returnValue == 2)
            {
                PlayerBullets(1);
                Presenter.ReloadBlock();
            }
            else if (returnValue == 3)
            {
                PlayerBullets(1);
                CpuBullets(1);
                Presenter.ReloadReload();
            }
            else if (returnValue == 4)
            {
                ShotGunForm shotGunForm = new ShotGunForm();
                shotGunForm.gradientLabel1.Text = "CPU WON THE GAME! YOU GOT SHOTGUNNED!";
                shotGunForm.pictureBox1.Image = Properties.Resources.ezgif_com_add_text_1_;
                shotGunForm.ShowDialog();
                CounterModel.ResetOnShotGun();
            }
        }

    }
}
