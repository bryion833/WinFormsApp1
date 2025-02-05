namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             // where we handle the add event
             ToDo myTodo = new ToDo { TaskDescription = txttaskDescription.Text, new DateTime(),  };
        }
    }
}
