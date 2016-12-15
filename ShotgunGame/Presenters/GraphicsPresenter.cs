using ShotgunGame.View.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShotgunGame.View;

namespace ShotgunGame.Presenters
{
    public class GraphicsPresenter
    {
        public IMainForm mainView;
        public GraphicsPresenter(IMainForm _mainView)
        {
            mainView = _mainView;
        }

        public void SetImage_PicBoxCpu(MainForm mainFrm)
        {
            if (mainView.GameResultTxt == null)
            {
                mainView.ResultImage = null;
            }
            else if (mainView.GameResultTxt == Presenter.BothGetBullet)
            {
                mainView.ResultImage = Properties.Resources.bothGainsABulletPic;
            }
            else if (mainView.GameResultTxt == Presenter.BothLoseBullet)
            {
                mainView.ResultImage = Properties.Resources.BothLoseBullet;
            }
            else if (mainView.GameResultTxt == Presenter.cGetBullet)
            {
                mainView.ResultImage = Properties.Resources.cGainsAbullet;
            }
            else if (mainView.GameResultTxt == Presenter.cLoseBullet)
            {
                mainView.ResultImage = Properties.Resources.cLoseBullet;
            }
            else if (mainView.GameResultTxt == Presenter.cWin)
            {
                mainView.ResultImage = Properties.Resources.ezgif_com_add_text_1_;
            }
            else if (mainView.GameResultTxt == Presenter.pGetBullet)
            {
                mainView.ResultImage = Properties.Resources.pGainsAbullet;
            }
            else if (mainView.GameResultTxt == Presenter.pLoseBullet)
            {
                mainView.ResultImage = Properties.Resources.pLoseBullet;
            }
            else if (mainView.GameResultTxt == Presenter.pWin)
            {
                mainView.ResultImage = Properties.Resources.ezgif_com_gif_maker_2_;
            }
            else if (mainView.GameResultTxt == Presenter.tie)
            {
                mainView.ResultImage = Properties.Resources.nothinghappends;
            }
        }
    }
}
