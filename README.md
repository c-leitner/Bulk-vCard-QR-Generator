# Bulk-vCard-QR-Generator
This repository contains a program for generating QR Codes which encapsulate vCard information. It utilizes an Excel file as input for contact data and requires a predefined output path for the QR Codes.
## Usage
1. Prepare an Excel file with the following columns in the exact order: Prefix, First Name, Last Name, Suffix, Company, Position, Phone Number, Email, LinkedIn Profile link. If any information is not available, leave the corresponding cell blank. A sample Excel file is provided in the repository for your reference.
2. Note that the program is designed to ignore the first row of the Excel file. This allows for the inclusion of a descriptive header.
3. Run the program with the Excel file and an output path as arguments.

The program will then generate QR Codes saved as PNG files. Each QR Code represents a contact's details, formatted as a vCard (version 3.0).

Please feel free to contribute to this repository or report any issues you encounter. Your feedback is much appreciated!
