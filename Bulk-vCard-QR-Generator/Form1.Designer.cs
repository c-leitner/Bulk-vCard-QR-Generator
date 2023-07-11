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
            SuspendLayout();
            // 
            // generateQR
            // 
            generateQR.Location = new Point(470, 110);
            generateQR.Name = "generateQR";
            generateQR.Size = new Size(171, 29);
            generateQR.TabIndex = 4;
            generateQR.Text = "Generate QR-Codes";
            generateQR.UseVisualStyleBackColor = true;
            generateQR.Click += generateQR_Click;
            // 
            // chooseFolder
            // 
            chooseFolder.Location = new Point(470, 47);
            chooseFolder.Name = "chooseFolder";
            chooseFolder.Size = new Size(171, 29);
            chooseFolder.TabIndex = 3;
            chooseFolder.Text = "Choose Output Folder";
            chooseFolder.UseVisualStyleBackColor = true;
            chooseFolder.Click += chooseFolder_Click;
            // 
            // chooseContactList
            // 
            chooseContactList.Location = new Point(470, 14);
            chooseContactList.Name = "chooseContactList";
            chooseContactList.Size = new Size(171, 29);
            chooseContactList.TabIndex = 1;
            chooseContactList.Text = "Choose Contact List";
            chooseContactList.UseVisualStyleBackColor = true;
            chooseContactList.Click += chooseContactList_Click;
            // 
            // contactPathBox
            // 
            contactPathBox.Location = new Point(12, 14);
            contactPathBox.Name = "contactPathBox";
            contactPathBox.Size = new Size(452, 27);
            contactPathBox.TabIndex = 0;
            contactPathBox.TextChanged += contactPathBox_TextChanged;
            // 
            // outPutFolderBox
            // 
            outPutFolderBox.Location = new Point(12, 47);
            outPutFolderBox.Name = "outPutFolderBox";
            outPutFolderBox.Size = new Size(452, 27);
            outPutFolderBox.TabIndex = 2;
            outPutFolderBox.TextChanged += outPutFolderBox_TextChanged;
            // 
            // isFinished
            // 
            isFinished.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            isFinished.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            isFinished.ForeColor = Color.FromArgb(0, 192, 0);
            isFinished.Location = new Point(164, 114);
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
            instructionButton.Location = new Point(12, 110);
            instructionButton.Name = "instructionButton";
            instructionButton.Size = new Size(118, 29);
            instructionButton.TabIndex = 6;
            instructionButton.Text = "Instructions";
            instructionButton.UseVisualStyleBackColor = true;
            instructionButton.Click += instructionButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 151);
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
    }
}