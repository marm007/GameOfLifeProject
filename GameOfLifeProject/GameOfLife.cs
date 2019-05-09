using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class GameOfLife
{
    private static int THREE_NEIGHBOURS = 3;
    private static int TWO_NEIGHBOURS = 2;

    private static int LIFE = 1;
    private static int DEAD = 0;

    private System.Drawing.Pen circuitPen = new System.Drawing.Pen(Color.Black, 1);
    private System.Drawing.SolidBrush cellBrushClear = new System.Drawing.SolidBrush(SystemColors.Control);
    private object lockObject = new object();

    private int[,] tab;

	public GameOfLife(int sizeX, int sizeY)
	{
        this.tab = new int[sizeY, sizeX];

        for (int i = 0; i < sizeY; i++)
        {
            for (int j = 0; j < sizeX; j++)
            {
                this.tab[i, j] = 0;
            }
        }
    }

    public int[,] Tab { get => tab; set => tab = value; }

    public void Display(Graphics g, int cellSize)
    {
       System.Drawing.SolidBrush cellBrush = new System.Drawing.SolidBrush(Color.Red);

        for (int i = 0; i < this.tab.GetLength(0); i++)
        {
            for (int j = 0; j < this.tab.GetLength(1); j++)
            {
                if (this.tab[i, j] == 1)
                {
                    //lock (lockObject)
                   // {
                        g.FillRectangle(cellBrush, j * cellSize + 1, i * cellSize + 1,
                            cellSize - 1, cellSize - 1);
                   // }
                }
            }
        }
    }

    public void Display(Graphics g, int x, int y, int state, int cellSize)
    {
        System.Drawing.SolidBrush cellBrush = new System.Drawing.SolidBrush(Color.Red);
        System.Drawing.SolidBrush cellBrushClear = new System.Drawing.SolidBrush(SystemColors.Control);
        
          
        if (state == 1)
            g.FillRectangle(cellBrush, (x) * cellSize + 1, (y) * cellSize + 1,
                cellSize - 1, cellSize - 1);
        else
            g.FillRectangle(cellBrushClear, (x) * cellSize + 1, (y) * cellSize + 1,
                cellSize - 1, cellSize - 1);

    }

    public void DisplayAs(PictureBox pictureBox,  int cellSize)
    {
        System.Drawing.SolidBrush cellBrush = new System.Drawing.SolidBrush(Color.Red);
        System.Drawing.SolidBrush cellBrushClear = new System.Drawing.SolidBrush(SystemColors.Control);

        var bmp = new Bitmap(this.tab.GetLength(1)*cellSize, this.tab.GetLength(0) * cellSize);
        var img = Graphics.FromImage(bmp);


        for (int i = 0; i < this.tab.GetLength(0); i++)
        {
            for (int j = 0; j < this.tab.GetLength(1); j++)
            {
                if (this.tab[i, j] == 1)
                {
                    img.FillRectangle(cellBrush, j * cellSize + 1, i * cellSize + 1,
                        cellSize - 1, cellSize - 1);
                }
            }
        }

        pictureBox.Image = bmp;

    }

    public void Simulate(PictureBox p, int cellSize)
    {
        Graphics g = p.CreateGraphics();

        int sizeX = this.tab.GetLength(1);
        int sizeY = this.tab.GetLength(0);

        int[,] tabTmp = new int[sizeY, sizeX];
      
        for (int i = 0; i < sizeY; i++)
        {
            for (int j = 0; j < sizeX; j++)
            {


                int s_l = -200;
                int s_p = -200;

                int s_d = -200;
                int s_g = -200;

                int s_g_l = -200;
                int s_g_p = -200;

                int s_d_l = -200;
                int s_d_p = -200;

                int cellBegin = this.tab[i, j];
                int cellEnd = this.tab[i, j];

                int x_l = j - 1 < 0 ? sizeX - 1 : j - 1;
                int x_p = j + 1 >= sizeX ? 0 : j + 1;
                int y_d = i + 1 >= sizeY ? 0 : i + 1;
                int y_g = i - 1 < 0 ? sizeY - 1 : i - 1;

                s_l = tab[i, x_l];
                s_p = tab[i, x_p];
                s_d = tab[y_d, j];
                s_g = tab[y_g, j];

                s_d_l = tab[y_d, x_l];
                s_d_p = tab[y_d, x_p];

                s_g_l = tab[y_g, x_l];
                s_g_p = tab[y_g, x_p];

              
                int sumN = s_l + s_p + s_d + s_g + s_d_l + s_d_p + s_g_l + s_g_p;

                if (sumN == THREE_NEIGHBOURS && cellBegin == DEAD)
                {
                    // rodzi sie
                    cellEnd = LIFE;

                }
                else if ((sumN == THREE_NEIGHBOURS || sumN == TWO_NEIGHBOURS) && cellBegin == LIFE)
                {
                    // nie zmienia stanu, pozostaje zywa
                    cellEnd = LIFE;
                }
                else if (sumN > THREE_NEIGHBOURS && cellBegin == LIFE)
                {
                    // za duzo sasiadow, umiera z natloku
                    cellEnd = DEAD;

                }
                else if (sumN < TWO_NEIGHBOURS && cellBegin == LIFE)
                {
                    // za malo sasiadow, umiera z samotnosci
                    cellEnd = DEAD;
                }
                tabTmp[i, j] = cellEnd;

                if (cellEnd != cellBegin)
                {
                  Display(g, j, i, cellEnd, cellSize);
                }
            }
        }

        this.tab = tabTmp;

        //DisplayAs(p, cellSize);
    }

}
