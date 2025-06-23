namespace FinalProject.Forms
{
    partial class GroupForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupForm));
            listBox1 = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            infoToolStripMenuItem = new ToolStripMenuItem();
            groupBindingSource = new BindingSource(components);
            findButton = new Button();
            panel2 = new Panel();
            groupNametextBox = new TextBox();
            label1 = new Label();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.ContextMenuStrip = contextMenuStrip1;
            listBox1.DataSource = groupBindingSource;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 284);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 144);
            listBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(105, 28);
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(104, 24);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // groupBindingSource
            // 
            groupBindingSource.DataSource = typeof(Models.Group);
            // 
            // findButton
            // 
            findButton.Location = new Point(208, 154);
            findButton.Name = "findButton";
            findButton.Size = new Size(94, 29);
            findButton.TabIndex = 2;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(groupNametextBox);
            panel2.Controls.Add(findButton);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(108, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 224);
            panel2.TabIndex = 3;
            // 
            // groupNametextBox
            // 
            groupNametextBox.Location = new Point(245, 83);
            groupNametextBox.Name = "groupNametextBox";
            groupNametextBox.Size = new Size(141, 27);
            groupNametextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 83);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Group name";
            // 
            // GroupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GroupForm";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button findButton;
        private BindingSource groupBindingSource;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private Panel panel2;
        private TextBox groupNametextBox;
        private Label label1;
    }
}