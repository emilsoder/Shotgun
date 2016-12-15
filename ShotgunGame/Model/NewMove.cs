namespace ShotgunGame.Model
{
    public class NewMove
    {
        public static void Shoot()
        {
            AIEngineModel.GenerateValue();
            GameModel.ShootMove();
        }

        public static void Block()
        {
            AIEngineModel.GenerateValue();
            GameModel.BlockMove();
        }

        public static void Reload()
        {
            AIEngineModel.GenerateValue();
            GameModel.ReloadMove();
        }
    }
}