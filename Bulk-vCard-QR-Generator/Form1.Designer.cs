namespace Bulk_vCard_QR_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            generateQR = new Button();
            chooseFolder = new Button();
            chooseContactList = new Button();
            contactPathBox = new TextBox();
            outPutFolderBox = new TextBox();
            isFinished = new Label();
            instructionButton = new Button();
            foregroundColorButton = new Button();
            backGroundColorButton = new Button();
            foreGroundColorHEX = new TextBox();
            backGroundColorHEX = new TextBox();
            foreGroundLabel = new Label();
            BackgroundLabel = new Label();
            BorderSizeLabel = new Label();
            borderSize = new TextBox();
            SuspendLayout();
            // 
            // generateQR
            // 
            generateQR.Location = new Point(470, 197);
            generateQR.Name = "generateQR";
            generateQR.Size = new Size(171, 29);
            generateQR.TabIndex = 5;
            generateQR.Text = "Generate QR-Codes";
            generateQR.UseVisualStyleBackColor = true;
            generateQR.Click += generateQR_Click;
            // 
            // chooseFolder
            // 
            chooseFolder.Location = new Point(444, 47);
            chooseFolder.Name = "chooseFolder";
            chooseFolder.Size = new Size(197, 29);
            chooseFolder.TabIndex = 3;
            chooseFolder.Text = "Choose Output Folder";
            chooseFolder.UseVisualStyleBackColor = true;
            chooseFolder.Click += chooseFolder_Click;
            // 
            // chooseContactList
            // 
            chooseContactList.Location = new Point(444, 14);
            chooseContactList.Name = "chooseContactList";
            chooseContactList.Size = new Size(197, 29);
            chooseContactList.TabIndex = 1;
            chooseContactList.Text = "Choose Contact List";
            chooseContactList.UseVisualStyleBackColor = true;
            chooseContactList.Click += chooseContactList_Click;
            // 
            // contactPathBox
            // 
            contactPathBox.Location = new Point(12, 14);
            contactPathBox.Name = "contactPathBox";
            contactPathBox.Size = new Size(426, 27);
            contactPathBox.TabIndex = 0;
            contactPathBox.TextChanged += contactPathBox_TextChanged;
            // 
            // outPutFolderBox
            // 
            outPutFolderBox.Location = new Point(12, 47);
            outPutFolderBox.Name = "outPutFolderBox";
            outPutFolderBox.Size = new Size(426, 27);
            outPutFolderBox.TabIndex = 2;
            outPutFolderBox.TextChanged += outPutFolderBox_TextChanged;
            // 
            // isFinished
            // 
            isFinished.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            isFinished.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            isFinished.ForeColor = Color.FromArgb(0, 192, 0);
            isFinished.Location = new Point(164, 201);
            isFinished.Name = "isFinished";
            isFinished.RightToLeft = RightToLeft.No;
            isFinished.Size = new Size(300, 20);
            isFinished.TabIndex = 5;
            isFinished.Text = "QR-Codes successfully created!";
            isFinished.TextAlign = ContentAlignment.TopRight;
            isFinished.Visible = false;
            isFinished.Click += isFinished_Click;
            // 
            // instructionButton
            // 
            instructionButton.Location = new Point(12, 197);
            instructionButton.Name = "instructionButton";
            instructionButton.Size = new Size(118, 29);
            instructionButton.TabIndex = 6;
            instructionButton.Text = "Instructions";
            instructionButton.UseVisualStyleBackColor = true;
            instructionButton.Click += instructionButton_Click;
            // 
            // foregroundColorButton
            // 
            foregroundColorButton.BackColor = Color.Black;
            foregroundColorButton.Location = new Point(232, 82);
            foregroundColorButton.Name = "foregroundColorButton";
            foregroundColorButton.Size = new Size(27, 27);
            foregroundColorButton.TabIndex = 4;
            foregroundColorButton.UseVisualStyleBackColor = false;
            foregroundColorButton.Click += foregroundColorButton_Click;
            // 
            // backGroundColorButton
            // 
            backGroundColorButton.BackColor = Color.White;
            backGroundColorButton.Location = new Point(232, 113);
            backGroundColorButton.Name = "backGroundColorButton";
            backGroundColorButton.Size = new Size(27, 27);
            backGroundColorButton.TabIndex = 8;
            backGroundColorButton.UseVisualStyleBackColor = false;
            backGroundColorButton.Click += backGroundColorButton_Click;
            // 
            // foreGroundColorHEX
            // 
            foreGroundColorHEX.Location = new Point(151, 80);
            foreGroundColorHEX.MaxLength = 7;
            foreGroundColorHEX.Name = "foreGroundColorHEX";
            foreGroundColorHEX.Size = new Size(75, 27);
            foreGroundColorHEX.TabIndex = 9;
            foreGroundColorHEX.Text = "#000000";
            foreGroundColorHEX.TextChanged += foreGroundColorHEX_TextChanged;
            // 
            // backGroundColorHEX
            // 
            backGroundColorHEX.Location = new Point(151, 113);
            backGroundColorHEX.MaxLength = 7;
            backGroundColorHEX.Name = "backGroundColorHEX";
            backGroundColorHEX.Size = new Size(75, 27);
            backGroundColorHEX.TabIndex = 10;
            backGroundColorHEX.Text = "#FFFFFF";
            backGroundColorHEX.TextChanged += backGroundColorHEX_TextChanged;
            // 
            // foreGroundLabel
            // 
            foreGroundLabel.AutoSize = true;
            foreGroundLabel.Location = new Point(12, 84);
            foreGroundLabel.Name = "foreGroundLabel";
            foreGroundLabel.Size = new Size(110, 20);
            foreGroundLabel.TabIndex = 11;
            foreGroundLabel.Text = "QR-Code Color";
            foreGroundLabel.Click += foreGroundLabel_Click;
            // 
            // BackgroundLabel
            // 
            BackgroundLabel.AutoSize = true;
            BackgroundLabel.ForeColor = SystemColors.ControlText;
            BackgroundLabel.Location = new Point(12, 117);
            BackgroundLabel.Name = "BackgroundLabel";
            BackgroundLabel.Size = new Size(128, 20);
            BackgroundLabel.TabIndex = 12;
            BackgroundLabel.Text = "Background Color";
            BackgroundLabel.Click += BackgroundLabel_Click;
            // 
            // BorderSizeLabel
            // 
            BorderSizeLabel.AutoSize = true;
            BorderSizeLabel.Location = new Point(12, 149);
            BorderSizeLabel.Name = "BorderSizeLabel";
            BorderSizeLabel.Size = new Size(85, 20);
            BorderSizeLabel.TabIndex = 13;
            BorderSizeLabel.Text = "Border Size";
            // 
            // borderSize
            // 
            borderSize.Location = new Point(151, 146);
            borderSize.MaxLength = 4;
            borderSize.Name = "borderSize";
            borderSize.Size = new Size(75, 27);
            borderSize.TabIndex = 14;
            borderSize.Text = "10";
            borderSize.TextAlign = HorizontalAlignment.Right;
            borderSize.TextChanged += borderSize_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 238);
            Controls.Add(borderSize);
            Controls.Add(BorderSizeLabel);
            Controls.Add(BackgroundLabel);
            Controls.Add(foreGroundLabel);
            Controls.Add(backGroundColorHEX);
            Controls.Add(foreGroundColorHEX);
            Controls.Add(backGroundColorButton);
            Controls.Add(foregroundColorButton);
            Controls.Add(instructionButton);
            Controls.Add(isFinished);
            Controls.Add(outPutFolderBox);
            Controls.Add(contactPathBox);
            Controls.Add(chooseContactList);
            Controls.Add(chooseFolder);
            Controls.Add(generateQR);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Bulk vCard QR Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generateQR;
        private Button chooseFolder;
        private Button chooseContactList;
        private TextBox contactPathBox;
        private TextBox outPutFolderBox;
        private Label isFinished;
        private Button instructionButton;
        private Button foregroundColorButton;
        private Button backGroundColorButton;
        private TextBox foreGroundColorHEX;
        private TextBox backGroundColorHEX;
        private Label foreGroundLabel;
        private Label BackgroundLabel;
        private Label BorderSizeLabel;
        private TextBox borderSize;
    }
}