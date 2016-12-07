using System;
using System.Collections.Generic;
using System.Linq;
using Akademia5Gra.Creatures;

namespace Akademia5Gra
{
    public class World
    {
        private Random _rnd;                                        // Random - klasa do losowania liczb
        private int _windowsHeight;
        private int _windowsWidth;
        private List<Creature> _creatureList;

        public World(int windowsHeight = 20, int windowsWidth = 40) // parametry domyślne, jeśli nie prześlemy parametrów do funkcji to będą one miały takie wartości. Jeśli prześlemy to wartości te się zmienią
        {
            _rnd = new Random();
            Console.WindowHeight = windowsHeight;
            Console.WindowWidth = windowsWidth;
            _windowsHeight = windowsHeight - 1;
            _windowsWidth = windowsWidth;
            CreateCreatureList();
        }

        private void CreateCreatureList()
        {
            _creatureList = new List<Creature>();
            int amountOfCreatures = _windowsHeight*_windowsWidth*15/100;

            for (int i = 0; i < amountOfCreatures / 3; i++)         // całe piękno dziedziczenia, czyli do listy zawierającej obiekty klasy Creature dodajemy obiekty klas dziedziczących po Creature
            {                                                       // ma to sens, ponieważ klasy te muszą zawierać to samo wnętrze co Creature, a są jeszcze dodatkowo wzbogacone
                _creatureList.Add(new Thief(_windowsWidth,_windowsHeight));
                _creatureList.Add(new Wizard(_windowsWidth,_windowsHeight));
                _creatureList.Add(new Warrior(_windowsWidth,_windowsHeight));
            }

            foreach (var creature in _creatureList)
            {
                RandAndSetCoordinates(creature);
            }
        }

        private void RandAndSetCoordinates(Creature creature)
        {
            int coordX, coordY;

            do
            {
                coordX = _rnd.Next(0, _windowsWidth);
                coordY = _rnd.Next(0, _windowsHeight);
            } while (_creatureList.Exists(x => x.XCoordinate == coordX && x.YCoordinate == coordY));    // przerażające LINQ, więcej o tym na następnych zajęciach

            creature.XCoordinate = coordX;
            creature.YCoordinate = coordY;
        }
    }
}
