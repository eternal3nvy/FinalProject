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
            advancedSearchButton = new Button();
            dataGridView1 = new DataGridView();
            Criminal = new DataGridViewTextBoxColumn();
            archiveDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reasonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            archivedCriminalBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)archivedCriminalBindingSource).BeginInit();
            SuspendLayout();
            // 
            // advancedSearchButton
            // 
            advancedSearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            advancedSearchButton.Location = new Point(355, 69);
            advancedSearchButton.Name = "advancedSearchButton";
            advancedSearchButton.Size = new Size(133, 38);
            advancedSearchButton.TabIndex = 8;
            advancedSearchButton.Text = "Search in Archive";
            advancedSearchButton.UseVisualStyleBackColor = true;
            advancedSearchButton.Click += advancedSearchButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Criminal, archiveDateDataGridViewTextBoxColumn, reasonDataGridViewTextBoxColumn });
            dataGridView1.DataSource = archivedCriminalBindingSource;
            dataGridView1.Location = new Point(12, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 285);
            dataGridView1.TabIndex = 9;
            // 
            // Criminal
            // 
            Criminal.DataPropertyName = "Criminal";
            Criminal.HeaderText = "Criminal";
            Criminal.MinimumWidth = 6;
            Criminal.Name = "Criminal";
            Criminal.Width = 125;
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
            reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            reasonDataGridViewTextBoxColumn.MinimumWidth = 6;
            reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            reasonDataGridViewTextBoxColumn.Width = 125;
            // 
            // archivedCriminalBindingSource
            // 
            archivedCriminalBindingSource.DataSource = typeof(Models.ArchivedCriminal);
            // 
            // Archive
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(advancedSearchButton);
            Name = "Archive";
            Text = "Archive";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)archivedCriminalBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button advancedSearchButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Criminal;
        private DataGridViewTextBoxColumn archiveDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private BindingSource archivedCriminalBindingSource;
    }
}