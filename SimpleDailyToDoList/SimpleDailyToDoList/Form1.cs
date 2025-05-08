using System;
using System.Linq;
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

			NewTasks_LTV.View = View.Details;
			NewTasks_LTV.Columns.Add("New Tasks", 600);
			DoneTasks_LTV.View = View.Details;
			DoneTasks_LTV.Columns.Add("Done Tasks", 600);
		}



		private void Add_BTN_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(Task_TB.Text))
			{
				NewTasks_LTV.Items.Add(Task_TB.Text);
				Task_TB.Clear();
			}
			else
			{
				DialogResult result = MessageBox.Show("Pleas Write A Task. Error: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void Clear_BTN_Click(object sender, EventArgs e)
		{
			NewTasks_LTV.Items.Clear();
			Task_TB.Clear();
		}

		private void DoneTask_BTN_Click(object sender, EventArgs e)
		{

			foreach (ListViewItem selectedItem in NewTasks_LTV.SelectedItems)
			{

				DoneTasks_LTV.Items.Add((ListViewItem)selectedItem.Clone());
			}

			foreach (ListViewItem selectedItem in NewTasks_LTV.SelectedItems)
			{
				NewTasks_LTV.Items.Remove(selectedItem);
			}
		}

		private void Remove_BTN_Click(object sender, EventArgs e)
		{
			var selectedNewTasks = NewTasks_LTV.SelectedItems.Cast<ListViewItem>().ToList();
			foreach (var item in selectedNewTasks)
			{
				NewTasks_LTV.Items.Remove(item);
			}

			var selectedDoneTasks = DoneTasks_LTV.SelectedItems.Cast<ListViewItem>().ToList();
			foreach (var item in selectedDoneTasks)
			{
				DoneTasks_LTV.Items.Remove(item);
			}
		}

		private void NotDone_BTN_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem selectedItem in DoneTasks_LTV.SelectedItems)
			{

				NewTasks_LTV.Items.Add((ListViewItem)selectedItem.Clone());
			}

			foreach (ListViewItem selectedItem in DoneTasks_LTV.SelectedItems)
			{
				DoneTasks_LTV.Items.Remove(selectedItem);
			}
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
	}
}
