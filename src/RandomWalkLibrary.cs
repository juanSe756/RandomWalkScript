using System;

namespace RandomWalkLibrary
{
    public static class RandomWalk
    {
        //Se instancia un objeto de tipo random para posteriormente generar un entero
        private static readonly Random random = new Random();

        /// <summary>
        /// Dependiendo de un numero pseudoaleatorio genera una coordenada x,y dentro de una tupla
        /// </summary>
        /// <param name="position">Tupla(x,y) de la posicion inicial </param>
        /// <param name="stepsToDo">Cantidad de pixeles/unidades que avanzará en cada paso que se de con random Walk</param>
        /// <returns>Una tupla con una coordenada X,Y</returns>
        public static Tuple<int, int> PerformRandomWalk(Tuple<int, int> position, int stepsToDo)
        {
            //numero psudoaleatorio entre 0 y 4 que determinará cierta dirección para avanzar
            int direction = random.Next(0, 4);
            //Avance en x o en y dependiendo la dirección tomada
            int displacementX = 0;
            int displacementY = 0;
            //clasificación del avance en x o en y según la dirección 
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
            //suma de la posicion original y el avance en x,y dado 
            int newX = position.Item1 + displacementX;
            int newY = position.Item2 + displacementY;
            //nueva posicion del objecto/personaje
            return Tuple.Create(newX, newY);
        }
    }
}
