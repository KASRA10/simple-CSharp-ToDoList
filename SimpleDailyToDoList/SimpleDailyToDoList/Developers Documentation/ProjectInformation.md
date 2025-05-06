# Project Information

## Open An Image Link
- UseShellExecute = true // Ensures it uses the default browser 
- // Use Process.Start to open the URL in the default browser 
	 ```System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo```
- ***it same for WebSite URL***

## Add To A New List From Other List
```
// Copy selected items to DoneTasks_LTV
    foreach (ListViewItem selectedItem in NewTasks_LTV.SelectedItems)
    {
        // Clone the item and add it to DoneTasks_LTV
        DoneTasks_LTV.Items.Add((ListViewItem)selectedItem.Clone());
    }

    // Remove selected items from NewTasks_LTV
    foreach (ListViewItem selectedItem in NewTasks_LTV.SelectedItems)
    {
        NewTasks_LTV.Items.Remove(selectedItem);
    }
 ```
- Explanation:
SelectedItems is a collection of all selected items.
You must clone each item to add it to another ListView; otherwise, you cannot add the same item instance to two different ListViews.
Removing items while iterating the same collection can cause issues, so here we iterate twice: first to add clones, second to remove originals.

## List Cast
```var selectedDoneTasks = DoneTasks_LTV.SelectedItems.Cast<ListViewItem>```
+ Cast<ListViewItem>() returns an IEnumerable<ListViewItem>, where each element is cast to ListViewItem.
+ You can then use LINQ methods like .ToList() or foreach to work with the collection as a strongly-typed +list.