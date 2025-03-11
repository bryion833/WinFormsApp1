namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ToDo[] toDos = { };

        // could'nt complete had issues on the listbox refreshing...

        public Form1()
        {
            InitializeComponent();
        }

        private void AddTodo(object sender, EventArgs e)
        {
            ToDo toDo = new ToDo(); // Makes a new ToDo Object called toDo
            toDo.ID = TaskListBox.Items.Count + 1; // Makes the toDo id the item count plus 1
            toDo.TaskDescription = TaskBox.Text; // Sets the toDo text to the text of the first textbox

            if (TaskBox.Text == null || TaskBox.Text == "") // Checks if the text in the second text box is either null (Does not exist) or empty
            {
                MessageBox.Show("");
                return;
            }

            DateTime validDate;
                
            if (!DateTime.TryParse(DueDateBox.Text, out validDate)) // Checks if the text in the second text box is either null (Does not exist) or empty
            {
                // Alert the User that the date is invalid
                MessageBox.Show("The date you entered is invalid!");
                return;
                //toDo.DueDate = DateTime.Now.AddDays(7);
            }
            else
            {
                toDo.DueDate = validDate;
            }
            // Sort the Box
            TaskListBox.Items.Add(toDo);
            TaskListBox.Sorted = true;

            ClearTodo(sender, e);
        }

        private void ClearTodo(object sender, EventArgs e)
        {
            TaskBox.Text = string.Empty;
            DueDateBox.Text = "";
        }

        private void IndexSelected(object sender, EventArgs e)
        {
            MarkCompleted(TaskListBox.SelectedIndex);
            TaskListBox.Refresh();
        }

        private void MarkCompleted(int index) 
        {
            (TaskListBox.Items[index] as ToDo)!.IsDone = true;
        }
    }
}
