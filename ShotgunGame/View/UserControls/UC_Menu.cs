using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShotgunGame.Model;

namespace ShotgunGame.View.UserControls
{
    public partial class UC_Menu : UserControl
    {
        public UC_Menu()
        {
            InitializeComponent();
        }

        #region Animations
        private void btn_Shoot_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_Reload_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_Block_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_Shoot_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btn_Reload_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btn_Block_MouseLeave(object sender, EventArgs e)
        {

        }

        #endregion

        NewMove newMove = new NewMove();

        private void btn_Shoot_Click(object sender, EventArgs e)
        {
            NewMove.Shoot();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            NewMove.Block();
        }

        private void btn_Block_Click(object sender, EventArgs e)
        {
            NewMove.Reload();
        }
    }
}
