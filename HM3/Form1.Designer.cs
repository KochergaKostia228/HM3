namespace HM3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TBName = new TextBox();
            TBSoname = new TextBox();
            TBEmail = new TextBox();
            TBPhone = new TextBox();
            BTAdd = new Button();
            BTEdit = new Button();
            BTDelete = new Button();
            BTImport = new Button();
            button2 = new Button();
            listUsers = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 36);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 85);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Soname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 133);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 176);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // TBName
            // 
            TBName.Location = new Point(154, 33);
            TBName.Name = "TBName";
            TBName.Size = new Size(125, 27);
            TBName.TabIndex = 4;
            // 
            // TBSoname
            // 
            TBSoname.Location = new Point(154, 82);
            TBSoname.Name = "TBSoname";
            TBSoname.Size = new Size(125, 27);
            TBSoname.TabIndex = 5;
            // 
            // TBEmail
            // 
            TBEmail.Location = new Point(154, 130);
            TBEmail.Name = "TBEmail";
            TBEmail.Size = new Size(125, 27);
            TBEmail.TabIndex = 6;
            // 
            // TBPhone
            // 
            TBPhone.Location = new Point(154, 173);
            TBPhone.Name = "TBPhone";
            TBPhone.Size = new Size(125, 27);
            TBPhone.TabIndex = 7;
            // 
            // BTAdd
            // 
            BTAdd.BackColor = Color.GreenYellow;
            BTAdd.Location = new Point(12, 235);
            BTAdd.Name = "BTAdd";
            BTAdd.Size = new Size(94, 29);
            BTAdd.TabIndex = 9;
            BTAdd.Text = "Add";
            BTAdd.UseVisualStyleBackColor = false;
            BTAdd.Click += BTAdd_Click;
            // 
            // BTEdit
            // 
            BTEdit.BackColor = Color.FromArgb(255, 255, 128);
            BTEdit.Location = new Point(143, 235);
            BTEdit.Name = "BTEdit";
            BTEdit.Size = new Size(94, 29);
            BTEdit.TabIndex = 10;
            BTEdit.Text = "Edit";
            BTEdit.UseVisualStyleBackColor = false;
            BTEdit.Click += BTEdit_Click;
            // 
            // BTDelete
            // 
            BTDelete.BackColor = Color.Red;
            BTDelete.Location = new Point(276, 235);
            BTDelete.Name = "BTDelete";
            BTDelete.Size = new Size(94, 29);
            BTDelete.TabIndex = 11;
            BTDelete.Text = "Delete";
            BTDelete.UseVisualStyleBackColor = false;
            BTDelete.Click += BTDelete_Click;
            // 
            // BTImport
            // 
            BTImport.Location = new Point(23, 319);
            BTImport.Name = "BTImport";
            BTImport.Size = new Size(94, 29);
            BTImport.TabIndex = 12;
            BTImport.Text = "Import file";
            BTImport.UseVisualStyleBackColor = true;
            BTImport.Click += BTImport_Click;
            // 
            // button2
            // 
            button2.Location = new Point(263, 319);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Export file";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listUsers
            // 
            listUsers.FormattingEnabled = true;
            listUsers.ItemHeight = 20;
            listUsers.Location = new Point(411, 33);
            listUsers.Name = "listUsers";
            listUsers.Size = new Size(361, 324);
            listUsers.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(listUsers);
            Controls.Add(button2);
            Controls.Add(BTImport);
            Controls.Add(BTDelete);
            Controls.Add(BTEdit);
            Controls.Add(BTAdd);
            Controls.Add(TBPhone);
            Controls.Add(TBEmail);
            Controls.Add(TBSoname);
            Controls.Add(TBName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TBName;
        private TextBox TBSoname;
        private TextBox TBEmail;
        private TextBox TBPhone;
        private Button BTAdd;
        private Button BTEdit;
        private Button BTDelete;
        private Button BTImport;
        private Button button2;
        private ListBox listUsers;
    }
}