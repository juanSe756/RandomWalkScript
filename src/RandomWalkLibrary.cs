using System;

namespace RandomWalkLibrary
{
    public static class RandomWalk
    {
        private static readonly Random random = new Random();

        public static Tuple<int, int> PerformRandomWalk(Tuple<int, int> position, int stepsToDo)
        {
            int direction = random.Next(0, 4);

            int displacementX = 0;
            int displacementY = 0;

            switch (direction)
            {
                case 0: // Arriba
                    displacementY = stepsToDo;
                    break;
                case 1: // Abajo
                    displacementY = -stepsToDo;
                    break;
                case 2: // Izquierda
                    displacementX = -stepsToDo;
                    break;
                case 3: // Derecha
                    displacementX = stepsToDo;
                    break;
            }

            int newX = position.Item1 + displacementX;
            int newY = position.Item2 + displacementY;

            return Tuple.Create(newX, newY);
        }
    }
}
