namespace Homeworks;

internal class Program
{
    const int BoardWidth = 20;
    const int BoardHeight = 10;

    static int Score = 0;
    static int addScore = 0;
    static int threadSleepTime = 100;

    const int Up = 0, Down = 1, Left = 2, Right = 3;

    struct Position { public int X, Y; }



    static void Main ()
    {
        Console.WriteLine("Snake Game");
        Console.WriteLine("Start Game - y, Exit - n");
        if (Console.ReadLine() == "y") {
            Console.WriteLine("Game difficulty: Easy - e, Medium - m, Hard - h");
            GameDifficulty(Console.ReadLine());
        }
        else Environment.Exit(0);
    }

    static void GameDifficulty (string? answ)
    {
        if (answ == null) Environment.Exit(0);

        switch (answ) {
            case "e":
                threadSleepTime = 300;
                addScore = 1;
                InitGame();
                break;
            case "m":
                threadSleepTime = 100;
                addScore = 10;
                InitGame();
                break;
            case "h":
                threadSleepTime = 70;
                addScore = 30;
                InitGame();
                break;
        }
    }

    static void InitGame ()
    {
        Console.CursorVisible = false;
        Console.WindowWidth = BoardWidth + 20;
        Console.WindowHeight = BoardHeight + 10;

        int currentDirect = Right;
        var snake = new List<Position> { new Position { X = BoardWidth / 2, Y = BoardHeight / 2 } };
        var random = new Random();
        var food = FoodPosition(random, snake);

        while (true) {
            if (Console.KeyAvailable)
                currentDirect = GetNextDirect(Console.ReadKey(true).Key, currentDirect);

            var head = snake[0];
            switch (currentDirect) {
                case Up: head.Y = (head.Y - 1 + BoardHeight) % BoardHeight; break;
                case Down: head.Y = (head.Y + 1) % BoardHeight; break;
                case Left: head.X = (head.X - 1 + BoardWidth) % BoardWidth; break;
                case Right: head.X = (head.X + 1) % BoardWidth; break;
            }

            snake.Insert(0, head);

            if (head.X == food.X && head.Y == food.Y) {
                food = FoodPosition(random, snake);
                Score += addScore;
            }
            else {
                snake.RemoveAt(snake.Count - 1);
            }

            if (Collision(snake, head)) {
                Console.WriteLine("Game Over!");
                Console.WriteLine($"Score: {Score}");
                Console.ReadLine();
                break;
            }


            Console.Clear();
            DrawBoard(snake, food);
            Thread.Sleep(threadSleepTime);
        }
    }

    static int GetNextDirect (ConsoleKey key, int currentDirect)
    {
        if (key == ConsoleKey.UpArrow && currentDirect != Down)
            return Up;
        else if (key == ConsoleKey.DownArrow && currentDirect != Up)
            return Down;
        else if (key == ConsoleKey.LeftArrow && currentDirect != Right)
            return Left;
        else if (key == ConsoleKey.RightArrow && currentDirect != Left)
            return Right;
        else
            return currentDirect;
    }

    static bool Collision (List<Position> snake, Position head)
    {
        for (int i = 1; i < snake.Count; i++) {
            if (snake[i].X == head.X && snake[i].Y == head.Y) {
                return true;
            }
        }
        return false;
    }

    static Position FoodPosition (Random random, List<Position> snake)
    {
        Position food;
        do {
            food = new Position { X = random.Next(0, BoardWidth), Y = random.Next(0, BoardHeight) };
        } while (snake.Contains(food));

        return food;
    }

    static void DrawBoard (List<Position> snake, Position food)
    {
        for (int y = 0; y < BoardHeight; y++) {
            for (int x = 0; x < BoardWidth; x++) {
                if (snake.Exists(pos => pos.X == x && pos.Y == y))
                    Console.Write("#");

                else if (food.X == x && food.Y == y)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}