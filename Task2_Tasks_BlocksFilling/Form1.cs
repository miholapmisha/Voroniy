using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task2
{
    public partial class windowMain : Form
    {
        VoronoiDiagram voronoiDiagram;

        private void InputStatus(bool status)
        {
            resetDiagram.Enabled = status;
            singleTask.Enabled = status;
            multipleTasks.Enabled = status;
            tasksValue.Enabled = status;
            addPoints.Enabled = status;
            pointsValue.Enabled = status;
            diagramViewer.Enabled = status;
        }

        private void SetViewerSize()
        {
            // panel
            int width = int.Parse("600");
            int height = int.Parse("400");

            diagramViewer.Width =
                width < 10 ? 10 : (width > 1700 ? 1700 : width);
            diagramViewer.Height =
                height < 10 ? 10 : (height > 900 ? 900 : height);

            // window
            this.Width = 218 + diagramViewer.Width;
            this.Height = 58 + diagramViewer.Height;

            this.Refresh();
        }

        private void SetThreadsNumber()
        {
            int threadsInput = int.Parse(tasksValue.Text);

            int threadsActually =
                threadsInput < 2 ? 2 : (threadsInput > diagramViewer.Height ? diagramViewer.Height : threadsInput);

            tasksValue.Text = threadsActually.ToString();
        }

        public windowMain()
        {
            InitializeComponent();

            voronoiDiagram = new VoronoiDiagram
                (diagramViewer,
                singleTask.Checked ? 1 : int.Parse(tasksValue.Text),
                addPoints.Checked ? int.Parse(pointsValue.Text) : 0);
        }

        private void singleThread_CheckedChanged(object sender, EventArgs e)
        {
            tasks.Visible = multipleTasks.Checked;
            tasksValue.Visible = multipleTasks.Checked;
            tasksUsage.Height = 87;
        }

        private void multipleThreads_CheckedChanged(object sender, EventArgs e)
        {
            tasks.Visible = multipleTasks.Checked;
            tasksValue.Visible = multipleTasks.Checked;
            tasksUsage.Height = 115;
        }

        private void addPoints_CheckedChanged(object sender, EventArgs e)
        {
            points.Visible = addPoints.Checked;
            pointsValue.Visible = addPoints.Checked;
            randomGeneration.Height = addPoints.Checked ? 85 : 57;
        }

        private void resetDiagram_Click(object sender, EventArgs e)
        {
            InputStatus(false);

            SetViewerSize();

            SetThreadsNumber();

            voronoiDiagram = new VoronoiDiagram
                (diagramViewer,
                singleTask.Checked ? 1 : int.Parse(tasksValue.Text),
                addPoints.Checked ? int.Parse(pointsValue.Text) : 0);

            if (addPoints.Checked)
            {
                voronoiDiagram.EditViewer();
            }

            InputStatus(true);
            resetDiagram.Select();
        }

        private void diagramViewer_Click(object sender, EventArgs e)
        {
            InputStatus(false);

            int xCoordClick = MousePosition.X - this.Location.X - 200;
            int yCoordClick = MousePosition.Y - this.Location.Y - 41;

            voronoiDiagram.AddPoint(new Point(xCoordClick, yCoordClick));

            voronoiDiagram.EditViewer();

            InputStatus(true);
            resetDiagram.Select();
        }
    }
}
