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
            button1 = new Button();
            todoCheck = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(157, 206);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "担当者一覧";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // todoCheck
            // 
            todoCheck.Location = new Point(536, 206);
            todoCheck.Name = "todoCheck";
            todoCheck.Size = new Size(75, 23);
            todoCheck.TabIndex = 1;
            todoCheck.Text = "Todo確認";
            todoCheck.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(todoCheck);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button todoCheck;
    }
}