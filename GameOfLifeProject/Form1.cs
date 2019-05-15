using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLifeProject
{
    public partial class Form1 : Form
    {
        private static int SLEEP_TIME = 100;
        private static int SLEEP_TIME_MIN = 10;

        private System.Drawing.Graphics g;
        private System.Drawing.Pen circuitPen = new System.Drawing.Pen(Color.Black, 1);
        private System.Drawing.Pen circuitPenClear = new System.Drawing.Pen(SystemColors.Control, 1);
        private System.Drawing.SolidBrush cellBrush = new System.Drawing.SolidBrush(Color.Red);
        private System.Drawing.SolidBrush cellBrushClear = new System.Drawing.SolidBrush(SystemColors.Control);

        bool flagStop = false;
        bool flagResize = false;
        bool isPlayling = false;

        bool clickedButton = false;

        private int[,] tab = null;

        Grid grid = null;

        GameOfLife gameOfLife = null;

        PictureBox pPictureBox = null;

        private BackgroundWorker gameOfLifeWorker = null;



        public Form1()
        {
            InitializeComponent();

            g = pictureBox1.CreateGraphics();
            pictureBox1.Paint += pictureBox1_Paint;

            startButton.Enabled = true;
            stopButton.Enabled = false;
            clearButton.Enabled = false;

        }

        void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            grid.Draw(e);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            grid = new Grid(pictureBox1);
            gameOfLife = new GameOfLife(grid.SizeX, grid.SizeY);
        }

        private void Form1_ResizeEnd(object sender, System.EventArgs e)
        {

            g = pictureBox1.CreateGraphics();

            if (!grid.ComputeBounds(pPictureBox, pictureBox1, gameOfLife, g))
            {
                flagResize = false;
                if (gameOfLifeWorker != null)
                {
                    isPlayling = true;

                    Simulate();
                }
                return;
            }

            gameOfLife.Display(pictureBox1.CreateGraphics(), grid.CellSize);


            widthBox.Text = grid.SizeX.ToString();
            heightBox.Text = grid.SizeY.ToString();

            if (flagResize)
            {
                flagResize = false;
                isPlayling = true;

                Simulate();
            }
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            pPictureBox = new PictureBox();
            pPictureBox.Width = pictureBox1.Width;
            pPictureBox.Height = pictureBox1.Height;

            if (gameOfLifeWorker != null && !flagResize && !flagStop)
            {
                flagResize = true;
                gameOfLifeWorker.CancelAsync();
            }
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            int x = coordinates.X / grid.CellSize;
            int y = coordinates.Y / grid.CellSize;

            if (x >= grid.SizeX || y >= grid.SizeY)
                return;

            gameOfLife.Tab[y, x] = gameOfLife.Tab[y, x] == 0 ? 1 : 0;

            //if (!isPlayling)
            gameOfLife.Display(pictureBox1.CreateGraphics(), x, y, gameOfLife.Tab[y, x], grid.CellSize);
        }



        private void startButton_Click(object sender, EventArgs e)
        {

            if (flagStop)
            {
                flagStop = false;
            }

            isPlayling = true;

            gameOfLifeWorker = new BackgroundWorker();
            gameOfLifeWorker.WorkerSupportsCancellation = true;

            Simulate();

            startButton.Enabled = false;
            stopButton.Enabled = true;
            clearButton.Enabled = false;


        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            isPlayling = false;
            flagStop = true;
            gameOfLifeWorker.CancelAsync();
            startButton.Enabled = true;
            stopButton.Enabled = false;
            clearButton.Enabled = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            int sizeX = grid.SizeX;
            int sizeY = grid.SizeY;

            pictureBox1.Refresh();
            flagStop = false;
            startButton.Enabled = true;
            stopButton.Enabled = false;
            clearButton.Enabled = false;

            for (int i = 0; i < sizeY; i++)
            {
                for (int j = 0; j < sizeX; j++)
                {
                    gameOfLife.Tab[i, j] = 0;
                }
            }
        }



        private void applySettings_Click(object sender, EventArgs e)
        {
            flagStop = true;

            if(gameOfLifeWorker != null)
                gameOfLifeWorker.CancelAsync();

            startButton.Enabled = true;
            stopButton.Enabled = false;
            clearButton.Enabled = true;

            int maxSizeX = pictureBox1.Width / grid.CellSize;
            int maxSizeY = pictureBox1.Height / grid.CellSize;

            int startSizeX = grid.SizeX;
            int startSizeY = grid.SizeY;

            int sizeX = grid.SizeX;
            int sizeY = grid.SizeY;

            int[,] tabTmp = gameOfLife.Tab;

           

            bool success = Int32.TryParse(this.widthBox.Text, out sizeX);
            if (!success)
            {
                sizeX = maxSizeX;
                widthBox.Text = sizeX.ToString();
            }

            if (sizeX > maxSizeX || sizeX <= 0)
            {
                sizeX = maxSizeX;
                widthBox.Text = sizeX.ToString();
            }

            success = Int32.TryParse(this.heightBox.Text, out sizeY);
            if (!success)
            {
                sizeY = maxSizeY;
                heightBox.Text = sizeY.ToString();
            }

            if (sizeY > maxSizeY || sizeY <= 0)
            {
                sizeY = maxSizeY;
                heightBox.Text = sizeY.ToString();
            }

            grid.SizeX = sizeX;
            grid.SizeY = sizeY;

            gameOfLife.Tab = new int[sizeY, sizeX];

            int y = sizeY < startSizeY ? sizeY : startSizeY;
            int x = sizeX < startSizeX ? sizeX : startSizeX;


            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    gameOfLife.Tab[i, j] = tabTmp[i, j];
                }
            }
            

            BackgroundWorker renderWroker = new BackgroundWorker();

            renderWroker.DoWork += new DoWorkEventHandler((state, args) =>
            {
                grid.RenderGridAndRefresh(g, pictureBox1);
                gameOfLife.Display(pictureBox1.CreateGraphics(), grid.CellSize);
            });

            renderWroker.RunWorkerAsync();
        }



        private void immutableButton_Click(object sender, EventArgs e)
        {
            if (!isPlayling)
            {
                BegginingStates.Immutable(grid, gameOfLife, pictureBox1);
            }
            else
            {
                this.tab = BegginingStates.Immutable(grid, this.tab);
                clickedButton = true;
            }

           
        }

        private void gliderButton_Click(object sender, EventArgs e)
        {
            if (!isPlayling)
            {
                BegginingStates.Glider(grid, gameOfLife, pictureBox1);
            }
            else
            {
                this.tab = BegginingStates.Glider(grid, this.tab);
                clickedButton = true;
            }
        }

        private void oscliatorButton_Click(object sender, EventArgs e)
        {
            if (!isPlayling)
            {
                BegginingStates.Oscilator(grid, gameOfLife, pictureBox1);
            }
            else
            {
                this.tab = BegginingStates.Oscilator(grid, this.tab);
                clickedButton = true;
            }
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            if (!isPlayling)
            {
                BegginingStates.Random(grid, gameOfLife, pictureBox1);
            }
            else
            {
                this.tab = BegginingStates.Random(grid, this.tab);
                clickedButton = true;
            }
        }

        private void queenBee_Click(object sender, EventArgs e)
        {
            if (!isPlayling)
            {
                BegginingStates.QueenBee(grid, gameOfLife, pictureBox1);
            }
            else
            {
                this.tab = BegginingStates.QueenBee(grid, this.tab);
                clickedButton = true;
            }
        }

        private void cellSizeTracBar_Scroll(object sender, EventArgs e)
        {
            grid.CellSize = 4 * cellSizeTracBar.Value;
            grid.SetNewCellSizeAndDraw(g, pictureBox1, gameOfLife);

        }

        private void speedTracBar_Scroll(object sender, EventArgs e)
        {
            SLEEP_TIME = speedTracBar.Value * 10 ;
        }

      

        private void cellSizeTrackBar_MouseUp(object sender, MouseEventArgs e)
        {

            if (gameOfLifeWorker != null && isPlayling)
            {
                Simulate();
            }
        }

        private void cellSizeTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (gameOfLifeWorker != null)
            {
                gameOfLifeWorker.CancelAsync();
            }
        }

        private void Simulate()
        {
            gameOfLifeWorker.DoWork += new DoWorkEventHandler((state, args) =>
            {
                while (true)
                {
                    if (gameOfLifeWorker.CancellationPending)
                    {
                        break;
                    }

                    gameOfLife.Simulate(pictureBox1, grid.CellSize);

                    int time = 0;

                    while (time * SLEEP_TIME_MIN <= SLEEP_TIME)
                    {
                        if (clickedButton)
                        {
                            for (int i = 0; i < grid.SizeY; i++)
                            {

                                for (int j = 0; j < grid.SizeX; j++)
                                {
                                    if (this.tab[i, j] == 1)
                                    {
                                        gameOfLife.Tab[i, j] = 1;
                                        gameOfLife.Display(pictureBox1.CreateGraphics(), j, i, 1, grid.CellSize);
                                    }
                                }
                            }


                            clickedButton = false;
                        }

                        time++;

                        System.Threading.Thread.Sleep(SLEEP_TIME_MIN);
                    }
                }
            });

            if (!gameOfLifeWorker.IsBusy)
                gameOfLifeWorker.RunWorkerAsync();
        }
    }
}
