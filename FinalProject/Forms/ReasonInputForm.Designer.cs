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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReasonInputForm));
            reasonBox = new TextBox();
            OkButton = new Button();
            button2 = new Button();
            lebel1 = new Label();
            SuspendLayout();
            // 
            // reasonBox
            // 
            reasonBox.Anchor = AnchorStyles.Top;
            reasonBox.Location = new Point(155, 71);
            reasonBox.Name = "reasonBox";
            reasonBox.Size = new Size(125, 27);
            reasonBox.TabIndex = 0;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Top;
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
            button2.Anchor = AnchorStyles.Top;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(186, 131);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // lebel1
            // 
            lebel1.Anchor = AnchorStyles.Top;
            lebel1.AutoSize = true;
            lebel1.Location = new Point(56, 74);
            lebel1.Name = "lebel1";
            lebel1.Size = new Size(64, 20);
            lebel1.TabIndex = 3;
            lebel1.Text = "Reason: ";
            // 
            // ReasonInputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 198);
            Controls.Add(lebel1);
            Controls.Add(button2);
            Controls.Add(OkButton);
            Controls.Add(reasonBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReasonInputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reason";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox reasonBox;
        private Button OkButton;
        private Button button2;
        private Label lebel1;
    }
}