namespace FinalProject.Forms
{
    partial class Archive
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archive));
            advancedSearchButton = new Button();
            dataGridView1 = new DataGridView();
            archivedCriminalBindingSource = new BindingSource(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            infoToolStripMenuItem = new ToolStripMenuItem();
            Criminal = new DataGridViewTextBoxColumn();
            archiveDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reasonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)archivedCriminalBindingSource).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // advancedSearchButton
            // 
            advancedSearchButton.Anchor = AnchorStyles.Top;
            advancedSearchButton.Location = new Point(327, 72);
            advancedSearchButton.Name = "advancedSearchButton";
            advancedSearchButton.Size = new Size(133, 38);
            advancedSearchButton.TabIndex = 8;
            advancedSearchButton.Text = "Search in Archive";
            advancedSearchButton.UseVisualStyleBackColor = true;
            advancedSearchButton.Click += advancedSearchButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Criminal, archiveDateDataGridViewTextBoxColumn, reasonDataGridViewTextBoxColumn });
            dataGridView1.DataSource = archivedCriminalBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(12, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 285);
            dataGridView1.TabIndex = 9;
            // 
            // archivedCriminalBindingSource
            // 
            archivedCriminalBindingSource.DataSource = typeof(Models.ArchivedCriminal);
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
            // Criminal
            // 
            Criminal.ContextMenuStrip = contextMenuStrip1;
            Criminal.DataPropertyName = "Criminal";
            Criminal.HeaderText = "Criminal";
            Criminal.MinimumWidth = 6;
            Criminal.Name = "Criminal";
            Criminal.ReadOnly = true;
            Criminal.Width = 400;
            // 
            // archiveDateDataGridViewTextBoxColumn
            // 
            archiveDateDataGridViewTextBoxColumn.DataPropertyName = "ArchiveDate";
            archiveDateDataGridViewTextBoxColumn.HeaderText = "ArchiveDate";
            archiveDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            archiveDateDataGridViewTextBoxColumn.Name = "archiveDateDataGridViewTextBoxColumn";
            archiveDateDataGridViewTextBoxColumn.ReadOnly = true;
            archiveDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            reasonDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            reasonDataGridViewTextBoxColumn.MinimumWidth = 6;
            reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            reasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Archive
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(advancedSearchButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Archive";
            Text = "Archive";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)archivedCriminalBindingSource).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button advancedSearchButton;
        private DataGridView dataGridView1;
        private BindingSource archivedCriminalBindingSource;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private DataGridViewTextBoxColumn Criminal;
        private DataGridViewTextBoxColumn archiveDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
    }
}