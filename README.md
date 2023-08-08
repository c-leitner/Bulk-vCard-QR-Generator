# Bulk-vCard-QR-Generator

This repository contains a program for generating QR Codes that encapsulate vCard information. It utilizes an Excel file as input for contact data and outputs the QR Codes to a chosen directory.

## Usage
1. Prepare an Excel file with the following columns in the exact order: Prefix, First Name, Last Name, Suffix, Company, Position, Phone Number, Email, LinkedIn Profile link. If any information is not available, leave the corresponding cell blank. A sample Excel file is provided in the repository for your reference.
2. Note that the program is designed to ignore the first row of the Excel file. This allows for the inclusion of a descriptive header.
3. Run the program and choose an Excel file and an output path.
4. Click on "Generate QR-Codes" to generate the QR Codes.

The program will then generate QR Codes saved as PNG files. Each QR Code represents a contact's details, formatted as a vCard (version 3.0). They will be placed in the chosen output directory.

Please feel free to contribute to this repository or report any issues you encounter. Your feedback is much appreciated!

## Screenshots
![Screenshot of program](/screenshots/screenshot.png?raw=true "Main interface")
