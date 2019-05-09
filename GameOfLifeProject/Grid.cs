using System;
using System.Drawing;
using System.Windows.Forms;

public class Grid
{
    private int cellSize = 20;

    private System.Drawing.Pen circuitPen = new System.Drawing.Pen(Color.Black, 1);
    private System.Drawing.Pen circuitPenClear = new System.Drawing.Pen(SystemColors.Control, 1);
    private System.Drawing.SolidBrush cellBrush = new System.Drawing.SolidBrush(Color.Red);
    private System.Drawing.SolidBrush cellBrushClear = new System.Drawing.SolidBrush(SystemColors.Control);

    private int sizeX;
    private int sizeY;

    public int SizeX { get => sizeX; set => sizeX = value; }
    public int SizeY { get => sizeY; set => sizeY = value; }
    public int CellSize { get => cellSize; set => cellSize = value; }

    public Grid(int sizeX, int sizeY)
	{
        this.sizeX = sizeX;
        this.sizeY = sizeY;
	}

    public Grid(PictureBox pictureBox)
	{
        this.sizeX = pictureBox.Width / this.cellSize;
        this.sizeY = pictureBox.Height / this.cellSize;
    }

    public void Draw(PictureBox pictureBox, System.Drawing.Graphics gg, GameOfLife gameOfLife,
        int sizeX, int sizeY, bool drawX, bool drawY)
    {

        System.Drawing.Graphics g = pictureBox.CreateGraphics();

        int maxSizeX = pictureBox.Width / this.cellSize;
        int maxSizeY = pictureBox.Height / this.cellSize;

        if (!drawX)
            maxSizeX = sizeX;

        if (!drawY)
            maxSizeY = sizeY;

        Console.WriteLine(maxSizeX);
        Console.WriteLine(sizeX);

        if (maxSizeX == sizeX)
        {
            // zmienia sie Y

            if (maxSizeY > sizeY && drawY)
            {

                for (int i = 0; i < sizeX; i++)
                {
                    for (int j = sizeY; j < maxSizeY; j++)
                    {
                        g.DrawRectangle(circuitPen, i * cellSize, j * cellSize,
                            cellSize, cellSize);
                    }
                }
            }
            else if (maxSizeY < sizeY && drawY)
            {
                for (int i = 0; i < sizeX; i++)
                {
                    for (int j = maxSizeY; j < sizeY; j++)
                    {
                        gameOfLife.Display(g, i, j, 0, cellSize);

                        g.DrawRectangle(circuitPenClear, i * cellSize, j * cellSize + 1,
                            cellSize, cellSize);
                    }
                }
            }



        }
        else if (maxSizeX < sizeX)
        {

            if (maxSizeY > sizeY)
            {
                if (drawX)
                {
                    for (int i = maxSizeX; i < sizeX; i++)
                    {
                        for (int j = 0; j < maxSizeY; j++)
                        {

                            if (sizeY < maxSizeY)
                                gameOfLife.Display(g, i, j, 0, cellSize);

                            g.DrawRectangle(circuitPenClear, i * cellSize + 1, j * cellSize,
                                cellSize, cellSize);
                        }
                    }
                }

                if (drawY)
                {
                    for (int i = 0; i < maxSizeX; i++)
                    {
                        for (int j = sizeY; j < maxSizeY; j++)
                        {

                            g.DrawRectangle(circuitPen, i * cellSize, j * cellSize,
                                cellSize, cellSize);
                        }
                    }
                }

            }
            else if (maxSizeY < sizeY)
            {
                if (drawX)
                {
                    for (int i = maxSizeX; i < sizeX; i++)
                    {
                        for (int j = 0; j < sizeY; j++)
                        {

                            if (maxSizeY < sizeY)
                                gameOfLife.Display(g, i, j, 0, cellSize);

                            g.DrawRectangle(circuitPenClear, i * cellSize + 1, j * cellSize,
                                cellSize, cellSize);
                        }
                    }
                }

                if (drawY)
                {
                    for (int i = 0; i < maxSizeX; i++)
                    {
                        for (int j = maxSizeY; j < sizeY; j++)
                        {

                            gameOfLife.Display(g, i, j, 0, cellSize);

                            g.DrawRectangle(circuitPenClear, i * cellSize, j * cellSize + 1,
                                cellSize, cellSize);
                        }
                    }
                }
            }
            else
            {
                if (drawX)
                {
                    for (int i = maxSizeX; i < sizeX; i++)
                    {
                        for (int j = 0; j < maxSizeY; j++)
                        {

                            gameOfLife.Display(g, i, j, 0, cellSize);

                            g.DrawRectangle(circuitPenClear, i * cellSize + 1, j * cellSize,
                                cellSize, cellSize);
                        }
                    }
                }
            }

        }
        else
        {
           
            if (maxSizeY > sizeY)
            {
                if (drawX)
                {
                    for (int i = sizeX; i < maxSizeX; i++)
                    {
                        for (int j = 0; j < maxSizeY; j++)
                        {

                            g.DrawRectangle(circuitPen, i * cellSize, j * cellSize,
                                cellSize, cellSize);
                        }
                    }
                }




                if (drawY)
                {
                    for (int i = 0; i < maxSizeX; i++)
                    {
                        for (int j = sizeY; j < maxSizeY; j++)
                        {
                            g.DrawRectangle(circuitPen, i * cellSize, j * cellSize,
                                cellSize, cellSize);
                        }
                    }
                }
            }
            else if (maxSizeY < sizeY)
            {

                if (drawY)
                {
                    for (int i = 0; i < maxSizeX; i++)
                    {
                        for (int j = maxSizeY; j < sizeY; j++)
                        {

                            gameOfLife.Display(g, i, j, 0, cellSize);

                            g.DrawRectangle(circuitPenClear, i * cellSize, j * cellSize + 1,
                                cellSize, cellSize);
                        }
                    }
                }


                if (drawX)
                {
                    for (int i = sizeX; i < maxSizeX; i++)
                    {
                        for (int j = 0; j < maxSizeY; j++)
                        {

                            g.DrawRectangle(circuitPen, i * cellSize, j * cellSize,
                            cellSize, cellSize);
                        }
                    }
                }


            }
            else
            {
                Console.WriteLine("HER131312E");
                if (drawX)
                {
                    for (int i = sizeX; i < maxSizeX; i++)
                    {
                        for (int j = 0; j < maxSizeY; j++)
                        {
                            g.DrawRectangle(circuitPen, i * cellSize, j * cellSize,
                                cellSize, cellSize);
                        }
                    }
                }

            }
        }
    }

    public void Draw(PaintEventArgs e)
    {
       for (int i = 0; i < sizeX; i ++)
             {

                 for (int j = 0; j < sizeY; j ++)
                 {
                     e.Graphics.DrawRectangle(circuitPen, i * cellSize, j * cellSize,
                         cellSize, cellSize);
                 }
             }
    }

    public void Draw(Graphics g)
    {
        for (int i = 0; i < sizeX; i++)
        {

            for (int j = 0; j < sizeY; j++)
            {
                g.DrawRectangle(circuitPen, i * cellSize, j * cellSize,
                    cellSize, cellSize);
            }
        }
    }

    public bool ComputeBounds(PictureBox pPictureBox, PictureBox pictureBox,
        GameOfLife gameOfLife, Graphics g)
    {
        Console.WriteLine("pPictureBox.Width");
        Console.WriteLine(pPictureBox.Width);
        Console.WriteLine("pictureBox.Width");
        Console.WriteLine(pictureBox.Width);

        bool drawX = false;
        bool drawY = false;

        int[,] tabTmp = gameOfLife.Tab;

        int startSizeX = this.sizeX;
        int startSizeY = this.sizeY;

        int previousSizeX = pPictureBox.Width / this.cellSize;
        int previousSizeY = pPictureBox.Height / this.cellSize;

        int maxSizeX = pictureBox.Width / this.cellSize;
        int maxSizeY = pictureBox.Height / this.cellSize;

        Console.WriteLine("AFAFAF");

        Console.WriteLine(this.sizeX);
        Console.WriteLine(previousSizeX);
        Console.WriteLine(maxSizeX);


        if (maxSizeX == previousSizeX && maxSizeY == previousSizeY)
        {
            previousSizeX = maxSizeX;
            previousSizeY = maxSizeY;
            return false;
        }
       
        if (this.sizeX == previousSizeX)
        {
            Console.WriteLine("xzczxc");
            drawX = true;
            this.sizeX = maxSizeX;
        }

        if (this.sizeY == previousSizeY)
        {
            drawY = true;
            this.sizeY = maxSizeY;
        }

        if (maxSizeX < this.sizeX)
        {
            Console.WriteLine("xzczxc");
            drawX = true;
            this.sizeX = maxSizeX;
        }

        if (maxSizeY < this.sizeY)
        {
            drawY = true;
            this.sizeY = maxSizeY;
        }

        


        gameOfLife.Tab = new int[sizeY, sizeX];
        for (int i = 0; i < sizeY; i++)
        {
            for (int j = 0; j < sizeX; j++)
            {
                gameOfLife.Tab[i, j] = 0;
            }
        }
        int y = sizeY < startSizeY ? sizeY : startSizeY;
        int x = sizeX < startSizeX ? sizeX : startSizeX;

        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                //Console.WriteLine("i = " + i + " j = " + j + " " + gameOfLife.Tab[i, j]);

                gameOfLife.Tab[i, j] = tabTmp[i, j];
                //Console.WriteLine("i = " + i + " j = " + j + " " + gameOfLife.Tab[i, j]);
            }
        }
        Console.WriteLine("sizeX");
        Console.WriteLine(sizeX);
        Console.WriteLine("sizeY");
        Console.WriteLine(sizeY);
        Draw(pictureBox, g, gameOfLife, startSizeX, startSizeY, drawX, drawY);


        return true;
    }

    public void RenderGridAndRefresh(Graphics g, PictureBox pictureBox)
    {
       // pictureBox.Refresh();

        int maxSizeX = pictureBox.Width / this.cellSize;
        int maxSizeY = pictureBox.Height / this.cellSize;

       

        g.FillRectangle(cellBrushClear, 0, 0, maxSizeX * cellSize + 1, maxSizeY * cellSize + 1 );

        for (int i = 0; i < sizeY ; i++)
        {
            for (int j = 0; j < sizeX ; j++)
            {
                g.DrawRectangle(circuitPen, j * cellSize, i * cellSize,
                    cellSize, cellSize);
            }
        }
    }

    public void SetNewCellSizeAndDraw(Graphics gg, PictureBox pictureBox, GameOfLife gameOfLife)
    {
        Graphics g = pictureBox.CreateGraphics();

        int maxSizeX = pictureBox.Width / this.cellSize + 1;
        int maxSizeY = pictureBox.Height / this.cellSize + 1;
        g.FillRectangle(cellBrushClear, 0, 0, maxSizeX * cellSize + 1, maxSizeY * cellSize + 1);

        int[,] tabTmp = gameOfLife.Tab;

        int startSizeX = this.sizeX;
        int startSizeY = this.sizeY;


        this.sizeX = pictureBox.Width / this.cellSize;
        this.sizeY = pictureBox.Height / this.cellSize;

        gameOfLife.Tab = new int[sizeY, sizeX];

        for (int i = 0; i < sizeY; i++)
        {
            for (int j = 0; j < sizeX; j++)
            {
                gameOfLife.Tab[i, j] = 0;
            }
        }

        int y = sizeY < startSizeY ? sizeY : startSizeY;
        int x = sizeX < startSizeX ? sizeX : startSizeX;

        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                gameOfLife.Tab[i, j] = tabTmp[i, j];
            }
        }

        for (int i = 0; i < sizeY; i++)
        {
            for (int j = 0; j < sizeX; j++)
            {
                g.DrawRectangle(circuitPen, j * cellSize, i * cellSize,
                    cellSize, cellSize);
            }
        }

        gameOfLife.Display(g, this.cellSize);
    }

}
