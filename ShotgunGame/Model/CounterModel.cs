using ShotgunGame.View.Forms;

namespace ShotgunGame.Model
{
    public class CounterModel
    {
        #region FIELDS (PUB STAT INTEGERS)
        public static int pBullets = 0;
        public static int pScore = 0;
        public static int cBullets = 0;
        public static int cScore = 0;
        #endregion

        #region METHODS FOR COUNTER LOGIC
        public static void ResetOnShotGun()
        {
            pBullets = 0;
            pScore = 0;
            cBullets = 0;
            cScore = 0;
        }

        public static void PlayerScore(int score)
        {
            pScore = pScore + score;
        }
        public static void CpuScore(int score)
        {
            cScore = cScore + score;
        }
        public static void PlayerBullets(int bullets)
        {
            pBullets = pBullets + bullets;
        }
        public static void CpuBullets(int bullets)
        {
            cBullets = cBullets + bullets;
        }
        #endregion
    }
}
