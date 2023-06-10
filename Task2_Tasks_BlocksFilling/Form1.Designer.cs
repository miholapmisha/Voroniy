namespace Task2
{
    partial class windowMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resetDiagram = new Button();
            tasksUsage = new GroupBox();
            tasksValue = new TextBox();
            tasks = new Label();
            multipleTasks = new RadioButton();
            singleTask = new RadioButton();
            diagramViewer = new PictureBox();
            randomGeneration = new GroupBox();
            addPoints = new CheckBox();
            pointsValue = new TextBox();
            points = new Label();
            lineHorizontal1 = new Label();
            lineVertical1 = new Label();
            tasksUsage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)diagramViewer).BeginInit();
            randomGeneration.SuspendLayout();
            SuspendLayout();
            // 
            // resetDiagram
            // 
            resetDiagram.Location = new Point(16, 338);
            resetDiagram.Name = "resetDiagram";
            resetDiagram.Size = new Size(160, 30);
            resetDiagram.TabIndex = 0;
            resetDiagram.Text = "Reset diagram";
            resetDiagram.UseVisualStyleBackColor = true;
            resetDiagram.Click += resetDiagram_Click;
            // 
            // tasksUsage
            // 
            tasksUsage.Controls.Add(tasksValue);
            tasksUsage.Controls.Add(tasks);
            tasksUsage.Controls.Add(multipleTasks);
            tasksUsage.Controls.Add(singleTask);
            tasksUsage.Location = new Point(14, 78);
            tasksUsage.Name = "tasksUsage";
            tasksUsage.Size = new Size(160, 115);
            tasksUsage.TabIndex = 2;
            tasksUsage.TabStop = false;
            tasksUsage.Text = "Tasks usage:";
            // 
            // tasksValue
            // 
            tasksValue.Location = new Point(81, 82);
            tasksValue.Name = "tasksValue";
            tasksValue.Size = new Size(70, 23);
            tasksValue.TabIndex = 3;
            tasksValue.Text = "10";
            // 
            // tasks
            // 
            tasks.AutoSize = true;
            tasks.Location = new Point(39, 85);
            tasks.Name = "tasks";
            tasks.Size = new Size(36, 15);
            tasks.TabIndex = 2;
            tasks.Text = "tasks:";
            // 
            // multipleTasks
            // 
            multipleTasks.AutoSize = true;
            multipleTasks.Checked = true;
            multipleTasks.Location = new Point(10, 60);
            multipleTasks.Name = "multipleTasks";
            multipleTasks.Size = new Size(98, 19);
            multipleTasks.TabIndex = 1;
            multipleTasks.TabStop = true;
            multipleTasks.Text = "Multiple tasks";
            multipleTasks.UseVisualStyleBackColor = true;
            multipleTasks.CheckedChanged += multipleThreads_CheckedChanged;
            // 
            // singleTask
            // 
            singleTask.AutoSize = true;
            singleTask.Location = new Point(10, 30);
            singleTask.Name = "singleTask";
            singleTask.Size = new Size(81, 19);
            singleTask.TabIndex = 0;
            singleTask.Text = "Single task";
            singleTask.UseVisualStyleBackColor = true;
            singleTask.CheckedChanged += singleThread_CheckedChanged;
            // 
            // diagramViewer
            // 
            diagramViewer.BackColor = Color.Black;
            diagramViewer.Location = new Point(190, 7);
            diagramViewer.Name = "diagramViewer";
            diagramViewer.Size = new Size(600, 500);
            diagramViewer.TabIndex = 3;
            diagramViewer.TabStop = false;
            diagramViewer.Click += diagramViewer_Click;
            // 
            // randomGeneration
            // 
            randomGeneration.Controls.Add(addPoints);
            randomGeneration.Controls.Add(pointsValue);
            randomGeneration.Controls.Add(points);
            randomGeneration.Location = new Point(14, 205);
            randomGeneration.Name = "randomGeneration";
            randomGeneration.Size = new Size(160, 85);
            randomGeneration.TabIndex = 6;
            randomGeneration.TabStop = false;
            randomGeneration.Text = "Random generation";
            // 
            // addPoints
            // 
            addPoints.AutoSize = true;
            addPoints.Checked = true;
            addPoints.CheckState = CheckState.Checked;
            addPoints.Location = new Point(10, 30);
            addPoints.Name = "addPoints";
            addPoints.Size = new Size(84, 19);
            addPoints.TabIndex = 2;
            addPoints.Text = "Add points";
            addPoints.UseVisualStyleBackColor = true;
            addPoints.CheckedChanged += addPoints_CheckedChanged;
            // 
            // pointsValue
            // 
            pointsValue.Location = new Point(81, 52);
            pointsValue.Name = "pointsValue";
            pointsValue.Size = new Size(70, 23);
            pointsValue.TabIndex = 1;
            pointsValue.Text = "20";
            // 
            // points
            // 
            points.AutoSize = true;
            points.Location = new Point(32, 55);
            points.Name = "points";
            points.Size = new Size(43, 15);
            points.TabIndex = 0;
            points.Text = "points:";
            // 
            // lineHorizontal1
            // 
            lineHorizontal1.AutoSize = true;
            lineHorizontal1.BorderStyle = BorderStyle.Fixed3D;
            lineHorizontal1.Location = new Point(4, 73);
            lineHorizontal1.MaximumSize = new Size(1000, 2);
            lineHorizontal1.MinimumSize = new Size(180, 2);
            lineHorizontal1.Name = "lineHorizontal1";
            lineHorizontal1.Size = new Size(180, 2);
            lineHorizontal1.TabIndex = 8;
            lineHorizontal1.Text = "label3";
            // 
            // lineVertical1
            // 
            lineVertical1.AutoSize = true;
            lineVertical1.BorderStyle = BorderStyle.Fixed3D;
            lineVertical1.Location = new Point(180, 0);
            lineVertical1.MaximumSize = new Size(2, 1500);
            lineVertical1.MinimumSize = new Size(2, 1500);
            lineVertical1.Name = "lineVertical1";
            lineVertical1.Size = new Size(2, 1500);
            lineVertical1.TabIndex = 4;
            lineVertical1.Text = "label3";
            // 
            // windowMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 519);
            Controls.Add(lineHorizontal1);
            Controls.Add(randomGeneration);
            Controls.Add(lineVertical1);
            Controls.Add(diagramViewer);
            Controls.Add(tasksUsage);
            Controls.Add(resetDiagram);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(620, 425);
            Name = "windowMain";
            Text = "Voronoi diagram";
            tasksUsage.ResumeLayout(false);
            tasksUsage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)diagramViewer).EndInit();
            randomGeneration.ResumeLayout(false);
            randomGeneration.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resetDiagram;
        private GroupBox tasksUsage;
        private RadioButton multipleTasks;
        private RadioButton singleTask;
        private TextBox tasksValue;
        private Label tasks;
        private PictureBox diagramViewer;
        private GroupBox randomGeneration;
        private TextBox pointsValue;
        private Label points;
        private Label lineHorizontal1;
        private CheckBox addPoints;
        private Label lineVertical1;
    }
}