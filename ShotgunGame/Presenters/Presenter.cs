namespace ShotgunGame.Presenters
{
    public class Presenter
    {
        public static string cMove = "";
        public static string pMove = "";
        public static string gameResult = "";

        #region GAMERESULT TEXT STRINGS
        public readonly static string BothGetBullet = "Both gains a bullet!";
        public readonly static string BothLoseBullet = "Both lose a bullet!";

        public readonly static string pWin = "You killed CPU, which means you win!";
        public readonly static string cWin = "You die! CPU wins this time!";

        public readonly static string pLoseBullet = "You lose a bullet!";
        public readonly static string cLoseBullet = "CPU loses a bullet!";

        public readonly static string tie = "It´s a tie!";

        public readonly static string pGetBullet = "You get a bullet!";
        public readonly static string cGetBullet = "CPU gets a bullet!";

        #endregion

        #region PLAYER SHOOT
        public static void ShootShoot()
        {
            //BOTH LOSE A BULLET
            cMove = "Shoot";
            pMove = "Shoot";
            gameResult = BothLoseBullet;
        }
        public static void ShootBlock()
        {
            //PLAYER LOSE A BULLET
            cMove = "Block";
            pMove = "Shoot";
            gameResult = pLoseBullet;
        }
        public static void ShootReload()
        {
            //PLAYER WINS + LOSES A BULLET
            cMove = "Reload";
            pMove = "Shoot";
            gameResult = pWin;
        }
        #endregion

        #region PLAYER BLOCK
        public static void BlockShoot()
        {
            //CPU LOSE A BULLET
            cMove = "Shoot";
            pMove = "Block";
            gameResult = cLoseBullet;
        }
        public static void BlockBlock()
        {
            //NOTHING HAPPENDS
            cMove = "Block";
            pMove = "Block";
            gameResult = tie;

        }
        public static void BlockReload()
        {
            //CPU GETS A BULLET
            cMove = "Reload";
            pMove = "Block";
            gameResult = cGetBullet;
        }
        #endregion

        #region PLAYER RELOAD
        public static void ReloadShoot()
        {
            //PLAYER LOSE + CPU LOSE A BULLET
            cMove = "Shoot";
            pMove = "Reload";
            gameResult = cWin;
        }
        public static void ReloadBlock()
        {
            //PLAYER GETS A BULLET
            cMove = "Block";
            pMove = "Reload";
            gameResult = pGetBullet;
        }
        public static void ReloadReload()
        {
            //BOTH GETS A BULLET
            cMove = "Reload";
            pMove = "Reload";
            gameResult = BothGetBullet;
        }
        #endregion
    }
}
