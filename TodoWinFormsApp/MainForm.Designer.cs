namespace TodoWinFormsApp
{
    partial class MainForm
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
            ButtonAssigneeList = new Button();
            ButtonTodoCheck = new Button();
            SuspendLayout();
            // 
            // ButtonAssigneeList
            // 
            ButtonAssigneeList.Location = new Point(157, 206);
            ButtonAssigneeList.Name = "ButtonAssigneeList";
            ButtonAssigneeList.Size = new Size(75, 23);
            ButtonAssigneeList.TabIndex = 0;
            ButtonAssigneeList.Text = "担当者一覧";
            ButtonAssigneeList.UseVisualStyleBackColor = true;
            ButtonAssigneeList.Click += ButtonAssigneeList_Click;
            // 
            // ButtonTodoCheck
            // 
            ButtonTodoCheck.Location = new Point(536, 206);
            ButtonTodoCheck.Name = "ButtonTodoCheck";
            ButtonTodoCheck.Size = new Size(75, 23);
            ButtonTodoCheck.TabIndex = 1;
            ButtonTodoCheck.Text = "Todo確認";
            ButtonTodoCheck.UseVisualStyleBackColor = true;
            ButtonTodoCheck.Click += ButtonTodoCheck_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonTodoCheck);
            Controls.Add(ButtonAssigneeList);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonAssigneeList;
        private Button ButtonTodoCheck;
    }
}