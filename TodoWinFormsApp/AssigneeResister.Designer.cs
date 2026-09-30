namespace TodoWinFormsApp
{
    partial class AssigneeResister
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
            buttonReturn = new Button();
            buttonDelete = new Button();
            buttonRestore = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxEmail = new TextBox();
            textBoxDetail = new TextBox();
            AssigneeIdLabel = new Label();
            labelAssigneId = new Label();
            textBoxAssigneeName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(81, 385);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(177, 23);
            buttonReturn.TabIndex = 0;
            buttonReturn.Text = "戻る";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(330, 385);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(195, 23);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "削除";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRestore
            // 
            buttonRestore.Location = new Point(531, 385);
            buttonRestore.Name = "buttonRestore";
            buttonRestore.Size = new Size(195, 23);
            buttonRestore.TabIndex = 2;
            buttonRestore.Text = "保存";
            buttonRestore.UseVisualStyleBackColor = true;
            buttonRestore.Click += buttonRestore_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 114);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "担当者ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 156);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "担当者名";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 196);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 8;
            label4.Text = "メールアドレス";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(136, 261);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 9;
            label5.Text = "備考";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(136, 323);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 10;
            label6.Text = "更新日時";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(228, 193);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(539, 23);
            textBoxEmail.TabIndex = 13;
            // 
            // textBoxDetail
            // 
            textBoxDetail.Location = new Point(228, 242);
            textBoxDetail.Multiline = true;
            textBoxDetail.Name = "textBoxDetail";
            textBoxDetail.Size = new Size(539, 63);
            textBoxDetail.TabIndex = 14;
            // 
            // AssigneeIdLabel
            // 
            AssigneeIdLabel.AutoSize = true;
            AssigneeIdLabel.Location = new Point(228, 114);
            AssigneeIdLabel.Name = "AssigneeIdLabel";
            AssigneeIdLabel.Size = new Size(0, 15);
            AssigneeIdLabel.TabIndex = 16;
            // 
            // labelAssigneId
            // 
            labelAssigneId.AutoSize = true;
            labelAssigneId.Location = new Point(228, 114);
            labelAssigneId.Name = "labelAssigneId";
            labelAssigneId.Size = new Size(38, 15);
            labelAssigneId.TabIndex = 17;
            labelAssigneId.Text = "label7";
            // 
            // textBoxAssigneeName
            // 
            textBoxAssigneeName.Location = new Point(228, 153);
            textBoxAssigneeName.Name = "textBoxAssigneeName";
            textBoxAssigneeName.Size = new Size(539, 23);
            textBoxAssigneeName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 323);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 19;
            label1.Text = "label1";
            // 
            // AssigneeResister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBoxAssigneeName);
            Controls.Add(labelAssigneId);
            Controls.Add(AssigneeIdLabel);
            Controls.Add(textBoxDetail);
            Controls.Add(textBoxEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonRestore);
            Controls.Add(buttonDelete);
            Controls.Add(buttonReturn);
            Name = "AssigneeResister";
            Text = "AssigneeResister";
            Shown += AssigneeResister_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReturn;
        private Button buttonDelete;
        private Button buttonRestore;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBoxEmail;
        private TextBox textBoxDetail;
        private Label AssigneeIdLabel;
        private Label labelAssigneId;
        private TextBox textBoxAssigneeName;
        private Label label1;
    }
}