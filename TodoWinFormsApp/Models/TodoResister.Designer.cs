namespace TodoWinFormsApp.Models
{
    partial class TodoResister
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
            label1 = new Label();
            textBoxTodoTitle = new TextBox();
            labelTodoId = new Label();
            AssigneeIdLabel = new Label();
            textBoxDetail = new TextBox();
            UpdateTimeTag = new Label();
            label5 = new Label();
            TodoTitleLabel = new Label();
            TodoIdLabel = new Label();
            buttonRestore = new Button();
            buttonDelete = new Button();
            buttonReturn = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            comboBox3 = new ComboBox();
            UpdateTimeLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 261);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 33;
            label1.Text = "状態";
            // 
            // textBoxTodoTitle
            // 
            textBoxTodoTitle.Location = new Point(204, 117);
            textBoxTodoTitle.Name = "textBoxTodoTitle";
            textBoxTodoTitle.Size = new Size(539, 23);
            textBoxTodoTitle.TabIndex = 32;
            // 
            // labelTodoId
            // 
            labelTodoId.AutoSize = true;
            labelTodoId.Location = new Point(204, 78);
            labelTodoId.Name = "labelTodoId";
            labelTodoId.Size = new Size(39, 15);
            labelTodoId.TabIndex = 31;
            labelTodoId.Text = "(新規)";
            // 
            // AssigneeIdLabel
            // 
            AssigneeIdLabel.AutoSize = true;
            AssigneeIdLabel.Location = new Point(204, 78);
            AssigneeIdLabel.Name = "AssigneeIdLabel";
            AssigneeIdLabel.Size = new Size(0, 15);
            AssigneeIdLabel.TabIndex = 30;
            // 
            // textBoxDetail
            // 
            textBoxDetail.Location = new Point(204, 162);
            textBoxDetail.Multiline = true;
            textBoxDetail.Name = "textBoxDetail";
            textBoxDetail.Size = new Size(539, 63);
            textBoxDetail.TabIndex = 29;
            // 
            // UpdateTimeTag
            // 
            UpdateTimeTag.AutoSize = true;
            UpdateTimeTag.Location = new Point(129, 356);
            UpdateTimeTag.Name = "UpdateTimeTag";
            UpdateTimeTag.Size = new Size(55, 15);
            UpdateTimeTag.TabIndex = 27;
            UpdateTimeTag.Text = "更新日時";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(136, 179);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 26;
            label5.Text = "詳細";
            // 
            // TodoTitleLabel
            // 
            TodoTitleLabel.AutoSize = true;
            TodoTitleLabel.Location = new Point(111, 120);
            TodoTitleLabel.Name = "TodoTitleLabel";
            TodoTitleLabel.Size = new Size(75, 15);
            TodoTitleLabel.TabIndex = 24;
            TodoTitleLabel.Text = "TODOタイトル";
            // 
            // TodoIdLabel
            // 
            TodoIdLabel.AutoSize = true;
            TodoIdLabel.Location = new Point(111, 78);
            TodoIdLabel.Name = "TodoIdLabel";
            TodoIdLabel.Size = new Size(56, 15);
            TodoIdLabel.TabIndex = 23;
            TodoIdLabel.Text = "TODO  ID";
            // 
            // buttonRestore
            // 
            buttonRestore.Location = new Point(573, 415);
            buttonRestore.Name = "buttonRestore";
            buttonRestore.Size = new Size(195, 23);
            buttonRestore.TabIndex = 22;
            buttonRestore.Text = "保存";
            buttonRestore.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(372, 415);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(195, 23);
            buttonDelete.TabIndex = 21;
            buttonDelete.Text = "削除";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(12, 415);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(177, 23);
            buttonReturn.TabIndex = 20;
            buttonReturn.Text = "戻る";
            buttonReturn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "未着手", "対応中", "完了" });
            comboBox1.Location = new Point(260, 253);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 34;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "高", "中", "低" });
            comboBox2.Location = new Point(579, 253);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(164, 23);
            comboBox2.TabIndex = 35;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(579, 301);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 36;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(260, 301);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(164, 23);
            comboBox3.TabIndex = 37;
            // 
            // UpdateTimeLabel
            // 
            UpdateTimeLabel.AutoSize = true;
            UpdateTimeLabel.Location = new Point(313, 356);
            UpdateTimeLabel.Name = "UpdateTimeLabel";
            UpdateTimeLabel.Size = new Size(38, 15);
            UpdateTimeLabel.TabIndex = 38;
            UpdateTimeLabel.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 304);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 39;
            label3.Text = "担当者";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(503, 261);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 40;
            label4.Text = "優先度";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(503, 309);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 41;
            label7.Text = "期限";
            // 
            // TodoResister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(UpdateTimeLabel);
            Controls.Add(comboBox3);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBoxTodoTitle);
            Controls.Add(labelTodoId);
            Controls.Add(AssigneeIdLabel);
            Controls.Add(textBoxDetail);
            Controls.Add(UpdateTimeTag);
            Controls.Add(label5);
            Controls.Add(TodoTitleLabel);
            Controls.Add(TodoIdLabel);
            Controls.Add(buttonRestore);
            Controls.Add(buttonDelete);
            Controls.Add(buttonReturn);
            Name = "TodoResister";
            Text = "TodoResister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTodoTitle;
        private Label labelTodoId;
        private Label AssigneeIdLabel;
        private TextBox textBoxDetail;
        private Label UpdateTimeTag;
        private Label label5;
        private Label TodoTitleLabel;
        private Label TodoIdLabel;
        private Button buttonRestore;
        private Button buttonDelete;
        private Button buttonReturn;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private ComboBox comboBox3;
        private Label UpdateTimeLabel;
        private Label label3;
        private Label label4;
        private Label label7;
    }
}