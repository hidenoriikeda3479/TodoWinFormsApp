namespace TodoWinFormsApp.Models
{
    partial class TodoList
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
            dataGridView1 = new DataGridView();
            buttonCreate = new Button();
            buttonSearch = new Button();
            SearchTextBox = new TextBox();
            label1 = new Label();
            ColumnDataEdit = new DataGridViewButtonColumn();
            ColumnTitle = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnDataEdit, ColumnTitle });
            dataGridView1.Location = new Point(12, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 278);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(700, 36);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 2;
            buttonCreate.Text = "新規作成";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(449, 69);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "検索";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(56, 70);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(356, 23);
            SearchTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(56, 30);
            label1.Name = "label1";
            label1.Size = new Size(171, 29);
            label1.TabIndex = 5;
            label1.Text = "TODO登録・編集";
            // 
            // ColumnDataEdit
            // 
            ColumnDataEdit.HeaderText = "編集";
            ColumnDataEdit.Name = "ColumnDataEdit";
            // 
            // ColumnTitle
            // 
            ColumnTitle.HeaderText = "タイトル";
            ColumnTitle.Name = "ColumnTitle";
            // 
            // TodoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(SearchTextBox);
            Controls.Add(buttonSearch);
            Controls.Add(buttonCreate);
            Controls.Add(dataGridView1);
            Name = "TodoList";
            Text = "Form1";
            Load += TodoList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonCreate;
        private Button buttonSearch;
        private TextBox SearchTextBox;
        private Label label1;
        private DataGridViewButtonColumn ColumnDataEdit;
        private DataGridViewTextBoxColumn ColumnTitle;
    }
}