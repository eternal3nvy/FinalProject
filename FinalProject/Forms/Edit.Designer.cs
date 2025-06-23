namespace FinalProject.Forms
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            cancelButton = new Button();
            lastCrimeLabel = new Label();
            okButton = new Button();
            lastCrimeTextBox = new TextBox();
            criminalProfessionLabel = new Label();
            criminalProfessionTextBox = new TextBox();
            languagesLabel = new Label();
            languagesTextBox = new TextBox();
            birthDate = new DateTimePicker();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            birthDateLabel = new Label();
            citizenshipLabel = new Label();
            citizenshipTextBox = new TextBox();
            distinguishingMarksLabel = new Label();
            distinguishingMarksTextBox = new TextBox();
            label6 = new Label();
            eyeColorTextBox = new TextBox();
            hairColorLabel = new Label();
            hairColorTextBox = new TextBox();
            heightLabel = new Label();
            heightTextBox = new TextBox();
            nicknameLabel = new Label();
            nicknameTextBox = new TextBox();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            groupLabel = new Label();
            groupTextBox = new TextBox();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top;
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(418, 334);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 56;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // lastCrimeLabel
            // 
            lastCrimeLabel.Anchor = AnchorStyles.Top;
            lastCrimeLabel.AutoSize = true;
            lastCrimeLabel.Location = new Point(262, 207);
            lastCrimeLabel.Name = "lastCrimeLabel";
            lastCrimeLabel.Size = new Size(76, 20);
            lastCrimeLabel.TabIndex = 54;
            lastCrimeLabel.Text = "Last crime";
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Top;
            okButton.DialogResult = DialogResult.Yes;
            okButton.Location = new Point(273, 334);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 55;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // lastCrimeTextBox
            // 
            lastCrimeTextBox.Anchor = AnchorStyles.Top;
            lastCrimeTextBox.Location = new Point(347, 204);
            lastCrimeTextBox.Name = "lastCrimeTextBox";
            lastCrimeTextBox.Size = new Size(125, 27);
            lastCrimeTextBox.TabIndex = 53;
            // 
            // criminalProfessionLabel
            // 
            criminalProfessionLabel.Anchor = AnchorStyles.Top;
            criminalProfessionLabel.AutoSize = true;
            criminalProfessionLabel.Location = new Point(501, 208);
            criminalProfessionLabel.Name = "criminalProfessionLabel";
            criminalProfessionLabel.Size = new Size(132, 20);
            criminalProfessionLabel.TabIndex = 52;
            criminalProfessionLabel.Text = "CriminalProfession";
            // 
            // criminalProfessionTextBox
            // 
            criminalProfessionTextBox.Anchor = AnchorStyles.Top;
            criminalProfessionTextBox.Location = new Point(639, 205);
            criminalProfessionTextBox.Name = "criminalProfessionTextBox";
            criminalProfessionTextBox.Size = new Size(125, 27);
            criminalProfessionTextBox.TabIndex = 51;
            // 
            // languagesLabel
            // 
            languagesLabel.Anchor = AnchorStyles.Top;
            languagesLabel.AutoSize = true;
            languagesLabel.Location = new Point(25, 204);
            languagesLabel.Name = "languagesLabel";
            languagesLabel.Size = new Size(80, 20);
            languagesLabel.TabIndex = 50;
            languagesLabel.Text = "Languages";
            // 
            // languagesTextBox
            // 
            languagesTextBox.Anchor = AnchorStyles.Top;
            languagesTextBox.Location = new Point(107, 201);
            languagesTextBox.Name = "languagesTextBox";
            languagesTextBox.Size = new Size(125, 27);
            languagesTextBox.TabIndex = 49;
            // 
            // birthDate
            // 
            birthDate.Anchor = AnchorStyles.Top;
            birthDate.Format = DateTimePickerFormat.Short;
            birthDate.Location = new Point(347, 156);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(108, 27);
            birthDate.TabIndex = 48;
            birthDate.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Top;
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(561, 162);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(62, 20);
            addressLabel.TabIndex = 47;
            addressLabel.Text = "Address";
            // 
            // addressTextBox
            // 
            addressTextBox.Anchor = AnchorStyles.Top;
            addressTextBox.Location = new Point(639, 158);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(125, 27);
            addressTextBox.TabIndex = 46;
            // 
            // birthDateLabel
            // 
            birthDateLabel.Anchor = AnchorStyles.Top;
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new Point(262, 158);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(74, 20);
            birthDateLabel.TabIndex = 45;
            birthDateLabel.Text = "Birth date";
            // 
            // citizenshipLabel
            // 
            citizenshipLabel.Anchor = AnchorStyles.Top;
            citizenshipLabel.AutoSize = true;
            citizenshipLabel.Location = new Point(24, 154);
            citizenshipLabel.Name = "citizenshipLabel";
            citizenshipLabel.Size = new Size(81, 20);
            citizenshipLabel.TabIndex = 44;
            citizenshipLabel.Text = "Citizenship";
            // 
            // citizenshipTextBox
            // 
            citizenshipTextBox.Anchor = AnchorStyles.Top;
            citizenshipTextBox.Location = new Point(111, 154);
            citizenshipTextBox.Name = "citizenshipTextBox";
            citizenshipTextBox.Size = new Size(121, 27);
            citizenshipTextBox.TabIndex = 43;
            // 
            // distinguishingMarksLabel
            // 
            distinguishingMarksLabel.Anchor = AnchorStyles.Top;
            distinguishingMarksLabel.AutoSize = true;
            distinguishingMarksLabel.Location = new Point(22, 262);
            distinguishingMarksLabel.Name = "distinguishingMarksLabel";
            distinguishingMarksLabel.Size = new Size(142, 20);
            distinguishingMarksLabel.TabIndex = 42;
            distinguishingMarksLabel.Text = "DistinguishingMarks";
            // 
            // distinguishingMarksTextBox
            // 
            distinguishingMarksTextBox.Anchor = AnchorStyles.Top;
            distinguishingMarksTextBox.Location = new Point(170, 259);
            distinguishingMarksTextBox.Name = "distinguishingMarksTextBox";
            distinguishingMarksTextBox.Size = new Size(239, 27);
            distinguishingMarksTextBox.TabIndex = 41;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(561, 108);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 40;
            label6.Text = "Eye Color";
            // 
            // eyeColorTextBox
            // 
            eyeColorTextBox.Anchor = AnchorStyles.Top;
            eyeColorTextBox.Location = new Point(639, 103);
            eyeColorTextBox.Name = "eyeColorTextBox";
            eyeColorTextBox.Size = new Size(125, 27);
            eyeColorTextBox.TabIndex = 39;
            // 
            // hairColorLabel
            // 
            hairColorLabel.Anchor = AnchorStyles.Top;
            hairColorLabel.AutoSize = true;
            hairColorLabel.Location = new Point(262, 104);
            hairColorLabel.Name = "hairColorLabel";
            hairColorLabel.Size = new Size(75, 20);
            hairColorLabel.TabIndex = 38;
            hairColorLabel.Text = "Hair color";
            // 
            // hairColorTextBox
            // 
            hairColorTextBox.Anchor = AnchorStyles.Top;
            hairColorTextBox.Location = new Point(347, 100);
            hairColorTextBox.Name = "hairColorTextBox";
            hairColorTextBox.Size = new Size(125, 27);
            hairColorTextBox.TabIndex = 37;
            // 
            // heightLabel
            // 
            heightLabel.Anchor = AnchorStyles.Top;
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(22, 103);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(54, 20);
            heightLabel.TabIndex = 36;
            heightLabel.Text = "Height";
            // 
            // heightTextBox
            // 
            heightTextBox.Anchor = AnchorStyles.Top;
            heightTextBox.Location = new Point(107, 101);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(125, 27);
            heightTextBox.TabIndex = 35;
            // 
            // nicknameLabel
            // 
            nicknameLabel.Anchor = AnchorStyles.Top;
            nicknameLabel.AutoSize = true;
            nicknameLabel.Location = new Point(561, 50);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new Size(75, 20);
            nicknameLabel.TabIndex = 34;
            nicknameLabel.Text = "Nickname";
            // 
            // nicknameTextBox
            // 
            nicknameTextBox.Anchor = AnchorStyles.Top;
            nicknameTextBox.Location = new Point(639, 49);
            nicknameTextBox.Name = "nicknameTextBox";
            nicknameTextBox.Size = new Size(125, 27);
            nicknameTextBox.TabIndex = 33;
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = AnchorStyles.Top;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(262, 49);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 32;
            lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Anchor = AnchorStyles.Top;
            lastNameTextBox.Location = new Point(347, 42);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(125, 27);
            lastNameTextBox.TabIndex = 31;
            // 
            // firstNameLabel
            // 
            firstNameLabel.Anchor = AnchorStyles.Top;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(24, 45);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(77, 20);
            firstNameLabel.TabIndex = 30;
            firstNameLabel.Text = "First name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Anchor = AnchorStyles.Top;
            firstNameTextBox.Location = new Point(107, 42);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(125, 27);
            firstNameTextBox.TabIndex = 29;
            // 
            // groupLabel
            // 
            groupLabel.Anchor = AnchorStyles.Top;
            groupLabel.AutoSize = true;
            groupLabel.Location = new Point(480, 265);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new Size(116, 20);
            groupLabel.TabIndex = 58;
            groupLabel.Text = "Group(optional)";
            // 
            // groupTextBox
            // 
            groupTextBox.Anchor = AnchorStyles.Top;
            groupTextBox.Location = new Point(618, 262);
            groupTextBox.Name = "groupTextBox";
            groupTextBox.Size = new Size(125, 27);
            groupTextBox.TabIndex = 57;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupLabel);
            Controls.Add(groupTextBox);
            Controls.Add(cancelButton);
            Controls.Add(lastCrimeLabel);
            Controls.Add(okButton);
            Controls.Add(lastCrimeTextBox);
            Controls.Add(criminalProfessionLabel);
            Controls.Add(criminalProfessionTextBox);
            Controls.Add(languagesLabel);
            Controls.Add(languagesTextBox);
            Controls.Add(birthDate);
            Controls.Add(addressLabel);
            Controls.Add(addressTextBox);
            Controls.Add(birthDateLabel);
            Controls.Add(citizenshipLabel);
            Controls.Add(citizenshipTextBox);
            Controls.Add(distinguishingMarksLabel);
            Controls.Add(distinguishingMarksTextBox);
            Controls.Add(label6);
            Controls.Add(eyeColorTextBox);
            Controls.Add(hairColorLabel);
            Controls.Add(hairColorTextBox);
            Controls.Add(heightLabel);
            Controls.Add(heightTextBox);
            Controls.Add(nicknameLabel);
            Controls.Add(nicknameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(firstNameTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Edit";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Label lastCrimeLabel;
        private Button okButton;
        private TextBox lastCrimeTextBox;
        private Label criminalProfessionLabel;
        private TextBox criminalProfessionTextBox;
        private Label languagesLabel;
        private TextBox languagesTextBox;
        private DateTimePicker birthDate;
        private Label addressLabel;
        private TextBox addressTextBox;
        private Label birthDateLabel;
        private Label citizenshipLabel;
        private TextBox citizenshipTextBox;
        private Label distinguishingMarksLabel;
        private TextBox distinguishingMarksTextBox;
        private Label label6;
        private TextBox eyeColorTextBox;
        private Label hairColorLabel;
        private TextBox hairColorTextBox;
        private Label heightLabel;
        private TextBox heightTextBox;
        private Label nicknameLabel;
        private TextBox nicknameTextBox;
        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private Label groupLabel;
        private TextBox groupTextBox;
    }
}