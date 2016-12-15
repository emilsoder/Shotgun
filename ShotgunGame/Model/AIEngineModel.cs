using System;

namespace ShotgunGame.Model
{
    public class AIEngineModel
    {
        public static void GenerateValue()
        {
            Generator generator = new Generator();
            GameModel.returnValue = generator.generatedValue;
        }
    }

    public static class RandomGenerator
    {
        public static readonly Random randomNumber = new Random();
    }

    public class Generator
    {
        public int generatedValue { get; set; }

        public Generator()
        {
            if (CounterModel.cBullets >= 3)
            {
                generatedValue = 4;
            }
            else
            {
                generatedValue = RandomGenerator.randomNumber.Next(1, 4);
            }
        }
    }
}
