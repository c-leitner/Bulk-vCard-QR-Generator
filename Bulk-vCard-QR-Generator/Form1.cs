using System.Windows.Forms;
using System.Text;
using System.Security.Policy;
using System.Runtime.InteropServices;
using System;
using System.IO;
using Net.Codecrete.QrCodeGenerator;
using System.Drawing;
using ClosedXML;
using ClosedXML.Excel;
using System.Reflection.Emit;
using DocumentFormat.OpenXml.ExtendedProperties;

namespace Bulk_vCard_QR_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // AllocConsole();
        }
        //  [DllImport("kernel32.dll", SetLastError = true)]
        //  [return: MarshalAs(UnmanagedType.Bool)]
        //  static extern bool AllocConsole();

        private void chooseContactList_Click(object sender, EventArgs e)
        {
            isFinished.Visible = false;
            fileChooser();
            contactPathBox.Text = programState.contacFile;
        }

        private void chooseFolder_Click(object sender, EventArgs e)
        {
            isFinished.Visible = false;
            folderChooser();
            outPutFolderBox.Text = programState.outputPath;
        }

        private void contactPathBox_TextChanged(object sender, EventArgs e)
        {
            isFinished.Visible = false;
            if (!File.Exists(contactPathBox.Text))
            {
                contactPathBox.BackColor = Color.LightCoral;
            }
            else
            {
                contactPathBox.BackColor = SystemColors.Window;
                programState.contacFile = contactPathBox.Text;
            }
        }

        private void outPutFolderBox_TextChanged(object sender, EventArgs e)
        {
            isFinished.Visible = false;
            if (!Directory.Exists(outPutFolderBox.Text))
            {
                outPutFolderBox.BackColor = Color.LightCoral;
            }
            else
            {
                outPutFolderBox.BackColor = SystemColors.Window;
                programState.outputPath = outPutFolderBox.Text;
            }

        }


        private void isFinished_Click(object sender, EventArgs e)
        {

        }

        private void instructionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program generates QR Codes encapsulating vCard information. It utilizes an Excel file filled with contact information and a predetermined output path. Each row in the Excel file should be arranged in the following specific sequence: Prefix, First Name, Last Name, Suffix, Company, Position, Phone Number, Email, and LinkedIn Profile link. If any piece of information is not available, simply leave the corresponding cell blank. The program ignores the first row of the Excel file, which can be used for a descriptive header. The resulting QR Codes are saved as PNG files, encompassing the contact information formatted as vCards, version 3.0.", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void generateQR_Click(object sender, EventArgs e)
        {
            if (programState.outputPath.Equals("") || programState.contacFile.Equals(""))
            {
                MessageBox.Show("A contact list and output folder must be choosen.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!File.Exists(programState.contacFile))
                {
                    MessageBox.Show("The path to the contact file is not formated correctly or does not exist.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!Directory.Exists(programState.outputPath))
                {
                    MessageBox.Show("The path of the output directory is not formated correctly or does not exist.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Console.WriteLine(programState.outputPath);
                }
                else
                {

                    int numberofQRCreated = readExcelFile(programState.contacFile);
                    Color sucessColor = Color.FromArgb(0, 192, 0);
                    isFinished.ForeColor = sucessColor;
                    isFinished.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
                    isFinished.Text = numberofQRCreated + " QR-Codes successfully created!";
                    isFinished.Visible = true;
                }
            }
        }


        private int readExcelFile(string filePath)
        {
            var workbook = new XLWorkbook(new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
            var worksheet = workbook.Worksheet(1);

            int lastRowUsed = worksheet.LastRowUsed().RowNumber();
            int totalNumberQR = lastRowUsed - 1;
            var rows = worksheet.Rows(2, lastRowUsed);
            int rowcounter = 0;

            foreach (var row in rows)
            {
                Person record = new Person
                {
                    prefix = row.Cell(1).GetValue<string>(),
                    firstName = row.Cell(2).GetValue<string>(),
                    lastName = row.Cell(3).GetValue<string>(),
                    suffix = row.Cell(4).GetValue<string>(),
                    company = row.Cell(5).GetValue<string>(),
                    position = row.Cell(6).GetValue<string>(),
                    tel = row.Cell(7).GetValue<string>(),
                    email = row.Cell(8).GetValue<string>(),
                    linkedin = row.Cell(9).GetValue<string>()
                };
                Console.WriteLine(record.firstName);
                var qr = QrCode.EncodeText("BEGIN:VCARD\nVERSION:3.0\nN:" + record.lastName + ";" + record.firstName + ";;" + record.prefix + ";" + record.suffix + "\nFN:" + record.prefix + " " + record.firstName + " " + record.lastName + ", " + record.suffix + "\nORG:"+ record.company + "\nTITLE:" + record.position + "\nTEL;TYPE=WORK,VOICE:" + record.tel + "\nEMAIL;TYPE=PREF,INTERNET:" + record.email + "\nURL:" + record.linkedin + "\nREV:2014-03-01T22:11:10Z\nEND:VCARD", QrCode.Ecc.Medium);
                string filenameWithPath = programState.outputPath + @"\" + record.lastName + "_" + record.firstName + ".png";
                Console.WriteLine(filenameWithPath);
                qr.SaveAsPng(filenameWithPath, 10, programState.borderSize, programState.foreGroundColor, programState.backGroundColor);

                isFinished.Text = rowcounter + " of " + totalNumberQR + " QR-Codes created.";
                isFinished.ForeColor = SystemColors.ControlText;
                isFinished.Font = new Font("Segoe UI Semibold", 9F,FontStyle.Regular, GraphicsUnit.Point);
                isFinished.Visible = true;
                isFinished.Refresh();
                rowcounter++;
            }
            return rowcounter;
        }



        private void fileChooser()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a Excel File";
            ofd.Filter = "Excel Files |*.xls;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                programState.contacFile = ofd.FileName;
            }
        }
        private void folderChooser()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                programState.outputPath = fbd.SelectedPath;
            }
        }

        private void foregroundColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.Color = foregroundColorButton.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                foregroundColorButton.BackColor = MyDialog.Color;
                programState.foreGroundColor = MyDialog.Color;
                foreGroundColorHEX.Text = ColorToHex(MyDialog.Color);
            }
        }
        private void foreGroundColorHEX_TextChanged(object sender, EventArgs e)
        {
            Color calculatedColor = HexToColor(foreGroundColorHEX.Text);
            programState.foreGroundColor = calculatedColor;
            foregroundColorButton.BackColor = calculatedColor;
        }


        private void backGroundColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.Color = backGroundColorButton.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                backGroundColorButton.BackColor = MyDialog.Color;
                programState.backGroundColor = MyDialog.Color;
                backGroundColorHEX.Text = ColorToHex(MyDialog.Color);
            }
        }

        private void backGroundColorHEX_TextChanged(object sender, EventArgs e)
        {
            Color calculatedColor = HexToColor(backGroundColorHEX.Text);
            programState.backGroundColor = calculatedColor;
            backGroundColorButton.BackColor = calculatedColor;
        }



        private Color HexToColor(String hexString)
        {
            Color actColor;
            int r, g, b;
            r = 0;
            g = 0;
            b = 0;
            if ((hexString.StartsWith("#")) && (hexString.Length == 7))
            {
                r = HexToInt(hexString.Substring(1, 2));
                g = HexToInt(hexString.Substring(3, 2));
                b = HexToInt(hexString.Substring(5, 2));
                actColor = Color.FromArgb(r, g, b);
            }
            else
            {
                actColor = Color.White;
            }
            return actColor;
        }
        private String ColorToHex(Color actColor)
        {
            return "#" + actColor.R.ToString("X2") + actColor.G.ToString("X2") + actColor.B.ToString("X2");
        }

        private int HexToInt(String hexString)
        {
            return int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
        }

        private void borderSize_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(borderSize.Text, out int output))
            {
                programState.borderSize = output;
                borderSize.BackColor = SystemColors.Window;
            }
            else
            {
                borderSize.BackColor = Color.LightCoral;
            }
        }

        private void foreGroundLabel_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundLabel_Click(object sender, EventArgs e)
        {

        }


    }

    static class programState
    {
        public static string outputPath = "";
        public static string contacFile = "";
        public static Color foreGroundColor = Color.Black;
        public static Color backGroundColor = Color.White;
        public static int borderSize = 10;
    }

    public class Person
    {
        public string? prefix { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? suffix { get; set; }
        public string? company { get; set; }
        public string? position { get; set; }
        public string? tel { get; set; }
        public string? email { get; set; }
        public string? linkedin { get; set; }
    }
}