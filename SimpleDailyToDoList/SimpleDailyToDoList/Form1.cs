using System;
using System.Windows.Forms;

namespace SimpleDailyToDoList
{
	public partial class ToDoListDashBoard_FR : Form
	{
		#region PublicItems
		public string gitHubUrl = "https://github.com/KASRA10";
		public string K10WebsiteUrl = "https://kasra10design.com";
		#endregion
		public ToDoListDashBoard_FR()
		{
			InitializeComponent();
		}

		private void GitHub_PIC_Click(object sender, EventArgs e)
		{
			string url = gitHubUrl;
			try
			{
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
				{
					FileName = url,
					UseShellExecute = true
				});
			}
			catch (Exception ex)
			{
				DialogResult result = MessageBox.Show("Unable to open the link. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WebSite_PIC_Click(object sender, EventArgs e)
		{

			string url = K10WebsiteUrl;
			try
			{
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
				{
					FileName = url,
					UseShellExecute = true
				});
			}
			catch (Exception ex)
			{
				DialogResult result = MessageBox.Show("Unable to open the link. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Add_BTN_Click(object sender, EventArgs e)
		{
			NewTasks_LTV.Items.Add(Task_TB.Text);
			Task_TB.Clear();
		}

		private void Clear_BTN_Click(object sender, EventArgs e)
		{
			NewTasks_LTV.Clear();
			Task_TB.Clear();
		}

		private void DoneTask_BTN_Click(object sender, EventArgs e)
		{

			foreach (ListViewItem selectedItem in NewTasks_LTV.SelectedItems)
			{

				DoneTasks_LTV.Items.Add((ListViewItem)selectedItem.Clone());
			}

			// Remove selected items from NewTasks_LTV
			foreach (ListViewItem selectedItem in NewTasks_LTV.SelectedItems)
			{
				NewTasks_LTV.Items.Remove(selectedItem);
			}
		}
	}
}
