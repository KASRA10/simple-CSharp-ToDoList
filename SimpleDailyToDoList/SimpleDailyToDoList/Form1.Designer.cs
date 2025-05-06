namespace SimpleDailyToDoList
{
	partial class ToDoListDashBoard_FR
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoListDashBoard_FR));
			this.Header_PNL = new System.Windows.Forms.Panel();
			this.TitlePartTwo_LBL = new System.Windows.Forms.Label();
			this.TitlePartOne_LBL = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Footer_PNL = new System.Windows.Forms.Panel();
			this.WebSite_PIC = new System.Windows.Forms.PictureBox();
			this.GitHub_PIC = new System.Windows.Forms.PictureBox();
			this.ToDoList_PNL = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.DoneTasks_LTV = new System.Windows.Forms.ListView();
			this.NewTaskTitle_LBL = new System.Windows.Forms.Label();
			this.NewTasks_LTV = new System.Windows.Forms.ListView();
			this.Add_BTN = new System.Windows.Forms.Button();
			this.Remove_BTN = new System.Windows.Forms.Button();
			this.Clear_BTN = new System.Windows.Forms.Button();
			this.Task_TB = new System.Windows.Forms.TextBox();
			this.Task_LBL = new System.Windows.Forms.Label();
			this.DoneTask_BTN = new System.Windows.Forms.Button();
			this.Header_PNL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.Footer_PNL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WebSite_PIC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GitHub_PIC)).BeginInit();
			this.ToDoList_PNL.SuspendLayout();
			this.SuspendLayout();
			// 
			// Header_PNL
			// 
			this.Header_PNL.BackColor = System.Drawing.SystemColors.Control;
			this.Header_PNL.Controls.Add(this.TitlePartTwo_LBL);
			this.Header_PNL.Controls.Add(this.TitlePartOne_LBL);
			this.Header_PNL.Controls.Add(this.pictureBox1);
			this.Header_PNL.Location = new System.Drawing.Point(8, 9);
			this.Header_PNL.Name = "Header_PNL";
			this.Header_PNL.Size = new System.Drawing.Size(688, 118);
			this.Header_PNL.TabIndex = 0;
			// 
			// TitlePartTwo_LBL
			// 
			this.TitlePartTwo_LBL.AutoSize = true;
			this.TitlePartTwo_LBL.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.TitlePartTwo_LBL.Location = new System.Drawing.Point(373, 35);
			this.TitlePartTwo_LBL.Name = "TitlePartTwo_LBL";
			this.TitlePartTwo_LBL.Size = new System.Drawing.Size(239, 52);
			this.TitlePartTwo_LBL.TabIndex = 2;
			this.TitlePartTwo_LBL.Text = "List (Daily)";
			// 
			// TitlePartOne_LBL
			// 
			this.TitlePartOne_LBL.AutoSize = true;
			this.TitlePartOne_LBL.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.TitlePartOne_LBL.Location = new System.Drawing.Point(128, 35);
			this.TitlePartOne_LBL.Name = "TitlePartOne_LBL";
			this.TitlePartOne_LBL.Size = new System.Drawing.Size(143, 52);
			this.TitlePartOne_LBL.TabIndex = 1;
			this.TitlePartOne_LBL.Text = "To Do";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::SimpleDailyToDoList.Properties.Resources.icons8_todo_list_90px;
			this.pictureBox1.Location = new System.Drawing.Point(277, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(90, 90);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Footer_PNL
			// 
			this.Footer_PNL.BackColor = System.Drawing.SystemColors.Control;
			this.Footer_PNL.Controls.Add(this.WebSite_PIC);
			this.Footer_PNL.Controls.Add(this.GitHub_PIC);
			this.Footer_PNL.Location = new System.Drawing.Point(8, 517);
			this.Footer_PNL.Name = "Footer_PNL";
			this.Footer_PNL.Size = new System.Drawing.Size(684, 40);
			this.Footer_PNL.TabIndex = 1;
			// 
			// WebSite_PIC
			// 
			this.WebSite_PIC.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WebSite_PIC.Image = global::SimpleDailyToDoList.Properties.Resources.icons8_website_30px;
			this.WebSite_PIC.Location = new System.Drawing.Point(337, 5);
			this.WebSite_PIC.Name = "WebSite_PIC";
			this.WebSite_PIC.Size = new System.Drawing.Size(30, 30);
			this.WebSite_PIC.TabIndex = 4;
			this.WebSite_PIC.TabStop = false;
			this.WebSite_PIC.Click += new System.EventHandler(this.WebSite_PIC_Click);
			// 
			// GitHub_PIC
			// 
			this.GitHub_PIC.Cursor = System.Windows.Forms.Cursors.Hand;
			this.GitHub_PIC.Image = global::SimpleDailyToDoList.Properties.Resources.icons8_github_30px;
			this.GitHub_PIC.Location = new System.Drawing.Point(301, 5);
			this.GitHub_PIC.Name = "GitHub_PIC";
			this.GitHub_PIC.Size = new System.Drawing.Size(30, 30);
			this.GitHub_PIC.TabIndex = 3;
			this.GitHub_PIC.TabStop = false;
			this.GitHub_PIC.Click += new System.EventHandler(this.GitHub_PIC_Click);
			// 
			// ToDoList_PNL
			// 
			this.ToDoList_PNL.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ToDoList_PNL.Controls.Add(this.DoneTask_BTN);
			this.ToDoList_PNL.Controls.Add(this.label1);
			this.ToDoList_PNL.Controls.Add(this.DoneTasks_LTV);
			this.ToDoList_PNL.Controls.Add(this.NewTaskTitle_LBL);
			this.ToDoList_PNL.Controls.Add(this.NewTasks_LTV);
			this.ToDoList_PNL.Controls.Add(this.Add_BTN);
			this.ToDoList_PNL.Controls.Add(this.Remove_BTN);
			this.ToDoList_PNL.Controls.Add(this.Clear_BTN);
			this.ToDoList_PNL.Controls.Add(this.Task_TB);
			this.ToDoList_PNL.Controls.Add(this.Task_LBL);
			this.ToDoList_PNL.Location = new System.Drawing.Point(13, 134);
			this.ToDoList_PNL.Name = "ToDoList_PNL";
			this.ToDoList_PNL.Size = new System.Drawing.Size(679, 377);
			this.ToDoList_PNL.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(30, 222);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "Done Tasks:";
			// 
			// DoneTasks_LTV
			// 
			this.DoneTasks_LTV.BackColor = System.Drawing.Color.DimGray;
			this.DoneTasks_LTV.ForeColor = System.Drawing.SystemColors.Info;
			this.DoneTasks_LTV.HideSelection = false;
			this.DoneTasks_LTV.Location = new System.Drawing.Point(33, 240);
			this.DoneTasks_LTV.Name = "DoneTasks_LTV";
			this.DoneTasks_LTV.Size = new System.Drawing.Size(623, 127);
			this.DoneTasks_LTV.TabIndex = 7;
			this.DoneTasks_LTV.UseCompatibleStateImageBehavior = false;
			// 
			// NewTaskTitle_LBL
			// 
			this.NewTaskTitle_LBL.AutoSize = true;
			this.NewTaskTitle_LBL.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.NewTaskTitle_LBL.Location = new System.Drawing.Point(30, 83);
			this.NewTaskTitle_LBL.Name = "NewTaskTitle_LBL";
			this.NewTaskTitle_LBL.Size = new System.Drawing.Size(76, 17);
			this.NewTaskTitle_LBL.TabIndex = 6;
			this.NewTaskTitle_LBL.Text = "New Tasks:";
			// 
			// NewTasks_LTV
			// 
			this.NewTasks_LTV.BackColor = System.Drawing.Color.White;
			this.NewTasks_LTV.HideSelection = false;
			this.NewTasks_LTV.Location = new System.Drawing.Point(33, 103);
			this.NewTasks_LTV.Name = "NewTasks_LTV";
			this.NewTasks_LTV.Size = new System.Drawing.Size(627, 116);
			this.NewTasks_LTV.TabIndex = 5;
			this.NewTasks_LTV.UseCompatibleStateImageBehavior = false;
			// 
			// Add_BTN
			// 
			this.Add_BTN.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.Add_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Add_BTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.Add_BTN.Location = new System.Drawing.Point(450, 55);
			this.Add_BTN.Name = "Add_BTN";
			this.Add_BTN.Size = new System.Drawing.Size(125, 25);
			this.Add_BTN.TabIndex = 4;
			this.Add_BTN.Text = "Add Task";
			this.Add_BTN.UseVisualStyleBackColor = false;
			this.Add_BTN.Click += new System.EventHandler(this.Add_BTN_Click);
			// 
			// Remove_BTN
			// 
			this.Remove_BTN.BackColor = System.Drawing.Color.Crimson;
			this.Remove_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Remove_BTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.Remove_BTN.ForeColor = System.Drawing.Color.White;
			this.Remove_BTN.Location = new System.Drawing.Point(188, 55);
			this.Remove_BTN.Name = "Remove_BTN";
			this.Remove_BTN.Size = new System.Drawing.Size(125, 25);
			this.Remove_BTN.TabIndex = 3;
			this.Remove_BTN.Text = "Remove Task";
			this.Remove_BTN.UseVisualStyleBackColor = false;
			// 
			// Clear_BTN
			// 
			this.Clear_BTN.BackColor = System.Drawing.Color.Orange;
			this.Clear_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Clear_BTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.Clear_BTN.Location = new System.Drawing.Point(319, 55);
			this.Clear_BTN.Name = "Clear_BTN";
			this.Clear_BTN.Size = new System.Drawing.Size(125, 25);
			this.Clear_BTN.TabIndex = 2;
			this.Clear_BTN.Text = "Clear List";
			this.Clear_BTN.UseVisualStyleBackColor = false;
			this.Clear_BTN.Click += new System.EventHandler(this.Clear_BTN_Click);
			// 
			// Task_TB
			// 
			this.Task_TB.BackColor = System.Drawing.SystemColors.Info;
			this.Task_TB.Location = new System.Drawing.Point(188, 26);
			this.Task_TB.Name = "Task_TB";
			this.Task_TB.Size = new System.Drawing.Size(387, 23);
			this.Task_TB.TabIndex = 1;
			this.Task_TB.Text = "1-Write A Code....";
			// 
			// Task_LBL
			// 
			this.Task_LBL.AutoSize = true;
			this.Task_LBL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Task_LBL.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.Task_LBL.Location = new System.Drawing.Point(30, 29);
			this.Task_LBL.Name = "Task_LBL";
			this.Task_LBL.Size = new System.Drawing.Size(152, 17);
			this.Task_LBL.TabIndex = 0;
			this.Task_LBL.Text = "Write Your Task Today:";
			// 
			// DoneTask_BTN
			// 
			this.DoneTask_BTN.BackColor = System.Drawing.Color.LimeGreen;
			this.DoneTask_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DoneTask_BTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.DoneTask_BTN.ForeColor = System.Drawing.Color.Black;
			this.DoneTask_BTN.Location = new System.Drawing.Point(57, 55);
			this.DoneTask_BTN.Name = "DoneTask_BTN";
			this.DoneTask_BTN.Size = new System.Drawing.Size(125, 25);
			this.DoneTask_BTN.TabIndex = 9;
			this.DoneTask_BTN.Text = "Done";
			this.DoneTask_BTN.UseVisualStyleBackColor = false;
			this.DoneTask_BTN.Click += new System.EventHandler(this.DoneTask_BTN_Click);
			// 
			// ToDoListDashBoard_FR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(704, 561);
			this.Controls.Add(this.ToDoList_PNL);
			this.Controls.Add(this.Footer_PNL);
			this.Controls.Add(this.Header_PNL);
			this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "ToDoListDashBoard_FR";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DashBoard";
			this.Header_PNL.ResumeLayout(false);
			this.Header_PNL.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.Footer_PNL.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.WebSite_PIC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GitHub_PIC)).EndInit();
			this.ToDoList_PNL.ResumeLayout(false);
			this.ToDoList_PNL.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Header_PNL;
		private System.Windows.Forms.Label TitlePartTwo_LBL;
		private System.Windows.Forms.Label TitlePartOne_LBL;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel Footer_PNL;
		private System.Windows.Forms.PictureBox WebSite_PIC;
		private System.Windows.Forms.PictureBox GitHub_PIC;
		private System.Windows.Forms.Panel ToDoList_PNL;
		private System.Windows.Forms.TextBox Task_TB;
		private System.Windows.Forms.Label Task_LBL;
		private System.Windows.Forms.Button Add_BTN;
		private System.Windows.Forms.Button Remove_BTN;
		private System.Windows.Forms.Button Clear_BTN;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView DoneTasks_LTV;
		private System.Windows.Forms.Label NewTaskTitle_LBL;
		private System.Windows.Forms.ListView NewTasks_LTV;
		private System.Windows.Forms.Button DoneTask_BTN;
	}
}

