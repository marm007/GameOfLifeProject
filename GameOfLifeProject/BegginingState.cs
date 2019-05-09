using System;
using System.Drawing;
using System.Windows.Forms;

public class BegginingStates
{
    public static void Oscilator(Grid grid, GameOfLife gameOfLife, PictureBox pictureBox)
    {
        int sizeX = grid.SizeX;
        int sizeY = grid.SizeY;

        gameOfLife.Tab[sizeY / 2, sizeX / 2] = 1;
        gameOfLife.Tab[sizeY / 2 + 1, sizeX / 2] = 1;
        gameOfLife.Tab[sizeY / 2 - 1, sizeX / 2] = 1;

        gameOfLife.Display(pictureBox.CreateGraphics(), grid.CellSize);
    }

    public static int[,] Oscilator(Grid grid, int[,] tab)
    {
        int sizeX = grid.SizeX;
        int sizeY = grid.SizeY;

        tab = new int[sizeY, sizeX];
        for (int i = 0; i < grid.SizeY; i++)
        {

            for (int j = 0; j < grid.SizeX; j++)
            {
                tab[i, j] = 0;
            }
        }

        tab[sizeY / 2, sizeX / 2] = 1;
        tab[sizeY / 2 + 1, sizeX / 2] = 1;
        tab[sizeY / 2 - 1, sizeX / 2] = 1;

        return tab;

    }


    public static void Random(Grid grid, GameOfLife gameOfLife, PictureBox pictureBox)
    {
        Random random = new Random();

        int sizeX = grid.SizeX;
        int sizeY = grid.SizeY;

        for (int i = 0; i < 50; i++)
        {
            int x = random.Next(0, sizeX);
            int y = random.Next(0, sizeY);

            gameOfLife.Tab[y, x] = 1;
        }

        gameOfLife.Display(pictureBox.CreateGraphics(), grid.CellSize);
    }

    public static int[,] Random(Grid grid, int[,] tab)
    {
        Random random = new Random();

        int sizeX = grid.SizeX;
        int sizeY = grid.SizeY;

        tab = new int[sizeY, sizeX];
        for (int i = 0; i < grid.SizeY; i++)
        {

            for (int j = 0; j < grid.SizeX; j++)
            {
                tab[i, j] = 0;
            }
        }

        for (int i = 0; i < 50; i++)
        {
            int x = random.Next(0, sizeX);
            int y = random.Next(0, sizeY);

            tab[y, x] = 1;
        }

        return tab;
    }



    public static void Immutable(Grid grid, GameOfLife gameOfLife, PictureBox pictureBox)
    {
        int sizeX = grid.SizeX;
        int sizeY = grid.SizeY;

        gameOfLife.Tab[sizeY / 2 - 1, sizeX / 2] = 1;
        gameOfLife.Tab[sizeY / 2 - 1, sizeX / 2 - 1] = 1;

        gameOfLife.Tab[sizeY / 2, sizeX / 2 - 2] = 1;

        gameOfLife.Tab[sizeY / 2 + 1, sizeX / 2] = 1;
        gameOfLife.Tab[sizeY / 2 + 1, sizeX / 2 - 1] = 1;

        gameOfLife.Tab[sizeY / 2, sizeX / 2 + 1] = 1;

        gameOfLife.Display(pictureBox.CreateGraphics(), grid.CellSize);
    }

    public static int[,] Immutable(Grid grid, int[,] tab)
    {
        int sizeX = grid.SizeX;
        int sizeY = grid.SizeY;

        tab = new int[sizeY, sizeX];
        for (int i = 0; i < grid.SizeY; i++)
        {

            for (int j = 0; j < grid.SizeX; j++)
            {
                tab[i, j] = 0;
            }
        }

        tab[sizeY / 2 - 1, sizeX / 2] = 1;
        tab[sizeY / 2 - 1, sizeX / 2 - 1] = 1;

        tab[sizeY / 2, sizeX / 2 - 2] = 1;

        tab[sizeY / 2 + 1, sizeX / 2] = 1;
        tab[sizeY / 2 + 1, sizeX / 2 - 1] = 1;

        tab[sizeY / 2, sizeX / 2 + 1] = 1;

        return tab;
    }



    public static void QueenBee(Grid grid, GameOfLife gameOfLife, PictureBox pictureBox)
    {
        int sizeX = grid.SizeX;
        int sizeY = grid.SizeY;

        gameOfLife.Tab[sizeY / 2, sizeX / 2 - 10] = 1;
        gameOfLife.Tab[sizeY / 2, sizeX / 2 - 9] = 1;
        gameOfLife.Tab[sizeY / 2 - 1, sizeX / 2 - 10] = 1;
        gameOfLife.Tab[sizeY / 2 - 1, sizeX / 2 - 9] = 1;


        gameOfLife.Tab[sizeY / 2 - 1, sizeX / 2 - 5] = 1;
        gameOfLife.Tab[sizeY / 2 - 2, sizeX / 2 - 4] = 1;
        gameOfLife.Tab[sizeY / 2 - 3, sizeX / 2 - 3] = 1;

        gameOfLife.Tab[sizeY / 2, sizeX / 2 - 4] = 1;
        gameOfLife.Tab[sizeY / 2 + 1, sizeX / 2 - 3] = 1;



        gameOfLife.Tab[sizeY / 2 - 2, sizeX / 2 - 2] = 1;
        gameOfLife.Tab[sizeY / 2 - 1, sizeX / 2 - 2] = 1;
        gameOfLife.Tab[sizeY / 2, sizeX / 2 - 2] = 1;



        gameOfLife.Tab[sizeY / 2 + 1, sizeX / 2 - 1] = 1;
        gameOfLife.Tab[sizeY / 2 + 2, sizeX / 2 - 1] = 1;

        gameOfLife.Tab[sizeY / 2 - 3, sizeX / 2 - 1] = 1;
        gameOfLife.Tab[sizeY / 2 - 4, sizeX / 2 - 1] = 1;



        gameOfLife.Tab[sizeY / 2, sizeX / 2 + 11] = 1;
        gameOfLife.Tab[sizeY / 2, sizeX / 2 + 10] = 1;
        gameOfLife.Tab[sizeY / 2 - 1, sizeX / 2 + 11] = 1;
        gameOfLife.Tab[sizeY / 2 - 1, sizeX / 2 + 10] = 1;

        gameOfLife.Display(pictureBox.CreateGraphics(), grid.CellSize);
    }

    public static int[,] QueenBee(Grid grid, int[,] tab)
    {
        int sizeX = grid.SizeX;
        int sizeY = grid.SizeY;

        tab = new int[sizeY, sizeX];
        for (int i = 0; i < grid.SizeY; i++)
        {

            for (int j = 0; j < grid.SizeX; j++)
            {
                tab[i, j] = 0;
            }
        }

        // TODO aut of range

        tab[sizeY / 2, sizeX / 2 - 10] = 1;
        tab[sizeY / 2, sizeX / 2 - 9] = 1;
        tab[sizeY / 2 - 1, sizeX / 2 - 10] = 1;
        tab[sizeY / 2 - 1, sizeX / 2 - 9] = 1;


        tab[sizeY / 2 - 1, sizeX / 2 - 5] = 1;
        tab[sizeY / 2 - 2, sizeX / 2 - 4] = 1;
        tab[sizeY / 2 - 3, sizeX / 2 - 3] = 1;

        tab[sizeY / 2, sizeX / 2 - 4] = 1;
        tab[sizeY / 2 + 1, sizeX / 2 - 3] = 1;



        tab[sizeY / 2 - 2, sizeX / 2 - 2] = 1;
        tab[sizeY / 2 - 1, sizeX / 2 - 2] = 1;
        tab[sizeY / 2, sizeX / 2 - 2] = 1;



        tab[sizeY / 2 + 1, sizeX / 2 - 1] = 1;
        tab[sizeY / 2 + 2, sizeX / 2 - 1] = 1;

        tab[sizeY / 2 - 3, sizeX / 2 - 1] = 1;
        tab[sizeY / 2 - 4, sizeX / 2 - 1] = 1;



        tab[sizeY / 2, sizeX / 2 + 11] = 1;
        tab[sizeY / 2, sizeX / 2 + 10] = 1;
        tab[sizeY / 2 - 1, sizeX / 2 + 11] = 1;
        tab[sizeY / 2 - 1, sizeX / 2 + 10] = 1;

        return tab;
    }



    public static void Glider(Grid grid, GameOfLife gameOfLife, PictureBox pictureBox)
    {
        int sizeX = grid.SizeX;
        int sizeY = grid.SizeY;

        gameOfLife.Tab[sizeY / 2, sizeX / 2 - 1] = 1;
        gameOfLife.Tab[sizeY / 2, sizeX / 2 + 1] = 1;
        gameOfLife.Tab[sizeY / 2, sizeX / 2] = 1;

        gameOfLife.Tab[sizeY / 2 - 1, sizeX / 2 + 1] = 1;
        gameOfLife.Tab[sizeY / 2 - 2, sizeX / 2] = 1;

        gameOfLife.Display(pictureBox.CreateGraphics(), grid.CellSize);
    }

    public static int[,] Glider(Grid grid, int[,] tab)
    {
        int sizeX = grid.SizeX;
        int sizeY = grid.SizeY;

        tab = new int[sizeY, sizeX];
        for (int i = 0; i < grid.SizeY; i++)
        {

            for (int j = 0; j < grid.SizeX; j++)
            {
                tab[i, j] = 0;
            }
        }

        tab[sizeY / 2, sizeX / 2 - 1] = 1;
        tab[sizeY / 2, sizeX / 2 + 1] = 1;
        tab[sizeY / 2, sizeX / 2] = 1;

        tab[sizeY / 2 - 1, sizeX / 2 + 1] = 1;
        tab[sizeY / 2 - 2, sizeX / 2] = 1;

        return tab;
    }
}
