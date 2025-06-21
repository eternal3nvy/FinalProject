namespace FinalProject.Forms
{
    partial class GroupInfo
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
            listBox1 = new ListBox();
            criminalBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)criminalBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.DataSource = criminalBindingSource;
            listBox1.DisplayMember = "ShortInfo";
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 78);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 344);
            listBox1.TabIndex = 0;
            listBox1.ValueMember = "Id";
            // 
            // criminalBindingSource
            // 
            criminalBindingSource.DataSource = typeof(Models.Criminal);
            // 
            // GroupInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Name = "GroupInfo";
            Text = "GroupInfo";
            ((System.ComponentModel.ISupportInitialize)criminalBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private BindingSource criminalBindingSource;
    }
}