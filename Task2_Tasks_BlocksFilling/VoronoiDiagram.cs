using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    internal class VoronoiDiagram
    {
        private static Random randomGen = new Random();

        List<Point> points = new List<Point>();
        List<Color> colors = new List<Color>();

        private PictureBox pictureBox;
        private int threadsAmount;
        private int xCoordMax;
        private int yCoordMax;

        public VoronoiDiagram
            (PictureBox pictureBox,
            int threadsAmount,
            int initialNumberOfPoints)
        {
            this.pictureBox = pictureBox;
            this.threadsAmount = threadsAmount;
            this.xCoordMax = pictureBox.Width;
            this.yCoordMax = pictureBox.Height;

            pictureBox.BackgroundImage = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);

            pictureBox.Refresh();

            if (initialNumberOfPoints > 0)
            {
                AddRandomPoints(initialNumberOfPoints);
            }
        }

        private void AddRandomPoints(int numberOfPoints)
        {
            for (int i = 0; i < numberOfPoints; i++)
            {
                AddPoint
                    (new Point
                        (randomGen.Next(0, xCoordMax),
                        randomGen.Next(0, yCoordMax)));
            }
        }

        public void AddPoint(Point point)
        {
            points.Add(point);
            colors.Add
                (Color.FromArgb
                ((byte)randomGen.Next(0, 256),
                (byte)randomGen.Next(0, 256),
                (byte)randomGen.Next(0, 256)));
        }

        public void EditViewer()
        {
            Task[] tasks = new Task[threadsAmount];
            Bitmap[] layers = new Bitmap[threadsAmount];

            int yStep = yCoordMax / threadsAmount;

            // run threads to fill diagram -----------------------------
            for (int i = 0; i < threadsAmount - 1; i++)
            {
                layers[i] = new Bitmap(pictureBox.Width, pictureBox.Height);

                Bitmap bitmapCurrent = layers[i];
                int yStart = i * yStep;
                int yFinish = (i + 1) * yStep - 1;

                tasks[i] = Task.Run(() => FillArea(yStart, yFinish, bitmapCurrent));
            }

            for (int i = threadsAmount - 1; i < threadsAmount; i++)
            {
                layers[i] = new Bitmap(pictureBox.Width, pictureBox.Height);

                Bitmap bitmapCurrent = layers[i];
                int yStart = i * yStep;
                int yFinish = yCoordMax - 1;

                tasks[i] = Task.Run(() => FillArea(yStart, yFinish, bitmapCurrent));
            }

            // ---------------------------------------------------------

            Task.WaitAll(tasks);

            CombineLayers(layers);

            for (int i = 0; i < points.Count; i++)
            {
                DrawKeyPoint(points[i]);
            }

            pictureBox.Refresh();
        }

        private void FillArea(int yStart, int yFinish, Bitmap bitmap)
        {
            for (int j = yStart; j <= yFinish; j++)
            {
                for (int i = 0; i < xCoordMax; i++)
                {
                    Point currentPixel = new Point(i, j);

                    DrawPixel(currentPixel, FindIndexOfClosestPoint(currentPixel), bitmap);
                }
            }
        }

        private void CombineLayers(Bitmap[] bitmaps)
        {
            Bitmap bitmapResult = new Bitmap(pictureBox.Width, pictureBox.Height);

            Graphics graphics = Graphics.FromImage(bitmapResult);

            for (int i = 0; i < bitmaps.Length; i++)
            {
                graphics.DrawImage(bitmaps[i], 0, 0);
            }

            pictureBox.BackgroundImage = bitmapResult;
        }

        private int FindIndexOfClosestPoint(Point pixel)
        {
            double minDistance = double.PositiveInfinity;
            int indexOfClosestPoint = 0;

            for (int i = 0; i < points.Count; i++)
            {
                double currentDistance =
                    Math.Sqrt
                        (Math.Pow(pixel.X - points[i].X, 2) +
                        Math.Pow(pixel.Y - points[i].Y, 2));

                if (currentDistance < minDistance)
                {
                    minDistance = currentDistance;
                    indexOfClosestPoint = i;
                }
            }

            return indexOfClosestPoint;
        }

        private void DrawKeyPoint(Point point)
        {
            for (int i = -2; i < 3; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    try
                    {
                        ((Bitmap)pictureBox.Image)
                        .SetPixel(point.X + i, point.Y + j, Color.Black);
                    }
                    catch (Exception) { }
                }
            }

            for (int i = -1; i < 2; i++)
            {
                for (int j = -2; j < 3; j += 2)
                {
                    try
                    {
                        ((Bitmap)pictureBox.Image)
                        .SetPixel(point.X + i, point.Y + j, Color.Black);
                    }
                    catch (Exception) { }
                }
            }
        }

        private void DrawPixel(Point pixel, int indexOfClosestPoint, Bitmap bitmap)
        {
            bitmap.SetPixel(pixel.X, pixel.Y, colors[indexOfClosestPoint]);
        }
    }
}
