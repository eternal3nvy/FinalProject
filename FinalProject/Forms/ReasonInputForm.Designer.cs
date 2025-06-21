namespace FinalProject.Forms
{
    partial class ReasonInputForm
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
            reasonBox = new TextBox();
            OkButton = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // reasonBox
            // 
            reasonBox.Location = new Point(186, 74);
            reasonBox.Name = "reasonBox";
            reasonBox.Size = new Size(125, 27);
            reasonBox.TabIndex = 0;
            // 
            // OkButton
            // 
            OkButton.DialogResult = DialogResult.OK;
            OkButton.Location = new Point(56, 131);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 29);
            OkButton.TabIndex = 1;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(186, 131);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // ReasonInputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 198);
            Controls.Add(button2);
            Controls.Add(OkButton);
            Controls.Add(reasonBox);
            Name = "ReasonInputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReasonInputForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox reasonBox;
        private Button OkButton;
        private Button button2;
    }
}