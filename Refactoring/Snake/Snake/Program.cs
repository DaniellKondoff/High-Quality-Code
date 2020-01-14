using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Snake
{
    class Program
    {
        private static ICollection<Position> CreatePositions()
        {
            return new Position[]
            {
                new Position(0, 1), // right
                new Position(0, -1), // left
                new Position(1, 0), // down
                new Position(-1, 0), // up
            };
        }

        private static ICollection<Position> CreateObstacles()
        {
            var obstacles =  new List<Position>()
            {
                new Position(12, 12),
                new Position(14, 20),
                new Position(7, 7),
                new Position(19, 19),
                new Position(6, 9),
            };

            foreach (Position obstacle in obstacles)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(obstacle.col, obstacle.row);
                Console.Write("=");
            }

            return obstacles;
        }

        private static Queue<Position> CreateSnake()
        {
            Queue<Position> snakeElements = new Queue<Position>();
            for (int i = 0; i <= 5; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }

            return snakeElements;
        }

        private static Position CreateRondomElement()
        {
            Random randomNumbersGenerator = new Random();

            return new Position(randomNumbersGenerator.Next(0, Console.WindowHeight),
                    randomNumbersGenerator.Next(0, Console.WindowWidth));
        }

        private static void AddGameObject(Position position, ConsoleColor? color, char symbol)
        {
            Console.SetCursorPosition(position.col, position.row);
            if(color.HasValue)
                Console.ForegroundColor = color.Value;
            Console.Write(symbol);
        }

        static Position CreateNotColidingsPosition(Queue<Position> snakeElements, List<Position> obstacles)
        {
            Position position;
            do
            {
                position = CreateRondomElement();
            }
            while (snakeElements.Contains(position) || obstacles.Contains(position));

            return position;
        }

        private static Direction GetDirection(Direction oldDirection)
        {
            Direction direction = oldDirection;

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                if (userInput.Key == ConsoleKey.LeftArrow)
                {
                    if (oldDirection != Direction.Right) direction = Direction.Left;
                }
                if (userInput.Key == ConsoleKey.RightArrow)
                {
                    if (oldDirection != Direction.Left) direction = Direction.Right;
                }
                if (userInput.Key == ConsoleKey.UpArrow)
                {
                    if (oldDirection != Direction.Down) direction = Direction.Up;
                }
                if (userInput.Key == ConsoleKey.DownArrow)
                {
                    if (oldDirection != Direction.Up) direction = Direction.Down;
                }
            }

            return direction;
        }

        static void Main(string[] args)
        {
            int lastFoodTime = 0;
            int negativePoints = 0;

            Position[] directions = CreatePositions().ToArray();

            double sleepTime = 100;
            Direction direction = Direction.Right;
            
            Console.BufferHeight = Console.WindowHeight;
            lastFoodTime = Environment.TickCount;
            List<Position> obstacles = CreateObstacles().ToList();
            Queue<Position> snakeElements = CreateSnake();

            Position food = CreateNotColidingsPosition(snakeElements, obstacles);

            AddGameObject(food, ConsoleColor.Yellow, '@');

            foreach (Position position in snakeElements)
            {
                AddGameObject(position, ConsoleColor.DarkGray, '*');
            }

            while (true)
            {
                negativePoints++;

                direction = GetDirection(direction);

                Position snakeHead = snakeElements.Last();
                Position nextDirection = directions[(int)direction];

                Position snakeNewHead = new Position(snakeHead.row + nextDirection.row,
                    snakeHead.col + nextDirection.col);

                if (snakeNewHead.col < 0) snakeNewHead.col = Console.WindowWidth - 1;
                if (snakeNewHead.row < 0) snakeNewHead.row = Console.WindowHeight - 1;
                if (snakeNewHead.row >= Console.WindowHeight) snakeNewHead.row = 0;
                if (snakeNewHead.col >= Console.WindowWidth) snakeNewHead.col = 0;

                if (snakeElements.Contains(snakeNewHead) || obstacles.Contains(snakeNewHead))
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game over!");
                    int userPoints = (snakeElements.Count - 6) * 100 - negativePoints;
                    userPoints = Math.Max(userPoints, 0);
                    Console.WriteLine("Your points are: {0}", userPoints);
                    return;
                }

                AddGameObject(snakeHead, ConsoleColor.DarkGray, '*');

                snakeElements.Enqueue(snakeNewHead);

                char headSymbol = '>';
                if (direction == Direction.Right) headSymbol = ('>');
                if (direction == Direction.Left) headSymbol = ('<');
                if (direction == Direction.Up) headSymbol = ('^');
                if (direction == Direction.Down) headSymbol = ('v');

                AddGameObject(snakeNewHead, ConsoleColor.Gray, headSymbol);

                if (snakeNewHead.col == food.col && snakeNewHead.row == food.row)
                {
                    // feeding the snake
                    food = CreateNotColidingsPosition(snakeElements, obstacles);

                    AddGameObject(food, ConsoleColor.Yellow, '@');

                    sleepTime--;

                    Position obstacle = new Position();
                    do
                    {
                        obstacle = CreateRondomElement();
                    }
                    while (snakeElements.Contains(obstacle) ||
                        obstacles.Contains(obstacle) ||
                        (food.row != obstacle.row && food.col != obstacle.row));
                    obstacles.Add(obstacle);

                    AddGameObject(obstacle, ConsoleColor.Cyan, '=');
                }
                else
                {
                    // moving...
                    Position last = snakeElements.Dequeue();
                    AddGameObject(last, null, ' ');
                }

                if (Environment.TickCount - lastFoodTime >= Constans.FoodDissapearTime)
                {
                    negativePoints = negativePoints + 50;
                    AddGameObject(food, null, ' ');

                    food = CreateNotColidingsPosition(snakeElements, obstacles);

                    lastFoodTime = Environment.TickCount;
                }

                AddGameObject(food, ConsoleColor.Yellow, '@');

                sleepTime -= 0.01;

                Thread.Sleep((int)sleepTime);
            }
        }
    }
}