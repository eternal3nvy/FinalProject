namespace FinalProject
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label2 = new Label();
            lastNameBox = new TextBox();
            label1 = new Label();
            firstNameBox = new TextBox();
            menuStrip1 = new MenuStrip();
            archiveToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            groupsToolStripMenuItem = new ToolStripMenuItem();
            listBox = new ListBox();
            addCriminalContextMenuStrip = new ContextMenuStrip(components);
            addToolStripMenuItem1 = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem1 = new ToolStripMenuItem();
            moveToArchiveToolStripMenuItem = new ToolStripMenuItem();
            criminalBindingSource = new BindingSource(components);
            findButton = new Button();
            advancedSearchButton = new Button();
            notFoundLabel = new Label();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            addCriminalContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)criminalBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lastNameBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(firstNameBox);
            panel1.Location = new Point(155, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 158);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 91);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Last name";
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(187, 88);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(236, 27);
            lastNameBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 44);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "First name";
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(187, 41);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(236, 27);
            firstNameBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archiveToolStripMenuItem, editToolStripMenuItem, groupsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // archiveToolStripMenuItem
            // 
            archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            archiveToolStripMenuItem.Size = new Size(72, 24);
            archiveToolStripMenuItem.Text = "Archive";
            archiveToolStripMenuItem.Click += archiveToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(84, 24);
            editToolStripMenuItem.Text = "&Criminals";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(120, 26);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // groupsToolStripMenuItem
            // 
            groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            groupsToolStripMenuItem.Size = new Size(70, 24);
            groupsToolStripMenuItem.Text = "Groups";
            groupsToolStripMenuItem.Click += groupsToolStripMenuItem_Click;
            // 
            // listBox
            // 
            listBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox.ContextMenuStrip = addCriminalContextMenuStrip;
            listBox.DataSource = criminalBindingSource;
            listBox.DisplayMember = "ShortInfo";
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(12, 279);
            listBox.Name = "listBox";
            listBox.Size = new Size(776, 144);
            listBox.TabIndex = 3;
            listBox.ValueMember = "Id";
            // 
            // addCriminalContextMenuStrip
            // 
            addCriminalContextMenuStrip.ImageScalingSize = new Size(20, 20);
            addCriminalContextMenuStrip.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem1, removeToolStripMenuItem, editToolStripMenuItem1, moveToArchiveToolStripMenuItem });
            addCriminalContextMenuStrip.Name = "contextMenuStrip1";
            addCriminalContextMenuStrip.Size = new Size(187, 100);
            addCriminalContextMenuStrip.Opening += addCriminalContextMenuStrip_Opening;
            // 
            // addToolStripMenuItem1
            // 
            addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            addToolStripMenuItem1.Size = new Size(186, 24);
            addToolStripMenuItem1.Text = "Add";
            addToolStripMenuItem1.Click += addToolStripMenuItem1_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(186, 24);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(186, 24);
            editToolStripMenuItem1.Text = "Edit";
            editToolStripMenuItem1.Click += editToolStripMenuItem1_Click;
            // 
            // moveToArchiveToolStripMenuItem
            // 
            moveToArchiveToolStripMenuItem.Name = "moveToArchiveToolStripMenuItem";
            moveToArchiveToolStripMenuItem.Size = new Size(186, 24);
            moveToArchiveToolStripMenuItem.Text = "Move to Archive";
            moveToArchiveToolStripMenuItem.Click += moveToArchiveToolStripMenuItem_Click;
            // 
            // criminalBindingSource
            // 
            criminalBindingSource.DataSource = typeof(Models.Criminal);
            // 
            // findButton
            // 
            findButton.Anchor = AnchorStyles.Top;
            findButton.Location = new Point(206, 214);
            findButton.Name = "findButton";
            findButton.Size = new Size(133, 38);
            findButton.TabIndex = 0;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // advancedSearchButton
            // 
            advancedSearchButton.Anchor = AnchorStyles.Top;
            advancedSearchButton.Location = new Point(420, 214);
            advancedSearchButton.Name = "advancedSearchButton";
            advancedSearchButton.Size = new Size(133, 38);
            advancedSearchButton.TabIndex = 4;
            advancedSearchButton.Text = "Advanced Search";
            advancedSearchButton.UseVisualStyleBackColor = true;
            advancedSearchButton.Click += advancedSearchButton_Click;
            // 
            // notFoundLabel
            // 
            notFoundLabel.AutoSize = true;
            notFoundLabel.Location = new Point(325, 306);
            notFoundLabel.Name = "notFoundLabel";
            notFoundLabel.Size = new Size(131, 20);
            notFoundLabel.TabIndex = 5;
            notFoundLabel.Text = "No crimnals found";
            notFoundLabel.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(notFoundLabel);
            Controls.Add(advancedSearchButton);
            Controls.Add(listBox);
            Controls.Add(panel1);
            Controls.Add(findButton);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(650, 394);
            Name = "MainForm";
            Text = "INTERPOL";
            FormClosing += MainForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            addCriminalContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)criminalBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private TextBox firstNameBox;
        private Label label2;
        private TextBox lastNameBox;
        private Label label1;
        private ListBox listBox;
        private Button findButton;
        private Button advancedSearchButton;
        private ToolStripMenuItem addToolStripMenuItem;
        private BindingSource criminalBindingSource;
        private ContextMenuStrip addCriminalContextMenuStrip;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem moveToArchiveToolStripMenuItem;
        private ToolStripMenuItem groupsToolStripMenuItem;
        private ToolStripMenuItem archiveToolStripMenuItem;
        private Label notFoundLabel;
    }
}
