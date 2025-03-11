namespace WinFormsApp1
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            DueDateBox = new TextBox();
            TaskBox = new TextBox();
            groupBox2 = new GroupBox();
            TaskListBox = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(DueDateBox);
            groupBox1.Controls.Add(TaskBox);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(578, 159);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "taskform";
            // 
            // button2
            // 
            button2.Location = new Point(376, 102);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClearTodo;
            // 
            // button1
            // 
            button1.Location = new Point(476, 102);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Add Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddTodo;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 68);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Due Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 29);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 2;
            label1.Text = "Task";
            // 
            // DueDateBox
            // 
            DueDateBox.Location = new Point(107, 68);
            DueDateBox.Margin = new Padding(3, 4, 3, 4);
            DueDateBox.Name = "DueDateBox";
            DueDateBox.PlaceholderText = "2025-01-16";
            DueDateBox.Size = new Size(463, 27);
            DueDateBox.TabIndex = 1;
            // 
            // TaskBox
            // 
            TaskBox.Location = new Point(107, 29);
            TaskBox.Margin = new Padding(3, 4, 3, 4);
            TaskBox.Name = "TaskBox";
            TaskBox.Size = new Size(463, 27);
            TaskBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TaskListBox);
            groupBox2.Location = new Point(14, 183);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(578, 424);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Task to do List";
            // 
            // TaskListBox
            // 
            TaskListBox.FormattingEnabled = true;
            TaskListBox.Location = new Point(17, 30);
            TaskListBox.Name = "TaskListBox";
            TaskListBox.Size = new Size(555, 384);
            TaskListBox.Sorted = true;
            TaskListBox.TabIndex = 1;
            TaskListBox.SelectedIndexChanged += IndexSelected;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 620);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox DueDateBox;
        private TextBox TaskBox;
        private GroupBox groupBox2;
        private ListBox TaskListBox;
        private Button button2;
        private Button button1;
    }
}
