# ST10279515_PART2_G3
#  Municipal Services Application

##  Project Overview
A comprehensive **Windows Forms application** developed in **C# (.NET Framework)** for South African municipal services.  
The application provides citizens with a platform to **report issues**, **view community events**, and **access municipal services** in an efficient and user-friendly manner.

---

##  Features

### Core Functionality
- **Homepage** – Professional welcome screen with an application overview  
- **Report Issues** – Complete issue reporting system with file attachment capability  
- **Events & Announcements** – Advanced event management system using data structures  
- **Service Request Status** – Reserved for future implementation  

### Technical Features
- Multi-form navigation system  
- Data persistence using **JSON file storage**  
- Professional **government-style UI** design  
- Comprehensive **data structure** implementation  

---

## Data Structures Implemented

### Events System
- **Stack** – Tracks recently viewed events *(LIFO principle)*  
- **Queue** – Manages events in chronological order *(FIFO principle)*  
- **Dictionary** – Organizes events by category for faster lookups  
- **HashSet** – Stores unique categories and event dates  

---

## Prerequisites
- Windows Operating System  
- .NET Framework **4.7.2 or later**  
- **Visual Studio 2019/2022** (recommended)  

---

## Installation & Setup

### 1. Clone the Repository
```bash
git clone [repository-url]
cd MunicipalServicesAppPOE
Open in Visual Studio

 Open MunicipalServicesAppPOE.sln in Visual Studio

Ensure the target framework is set to .NET Framework 4.7.2 or later
 3. Build the Solution
Build > Clean Solution  
Build > Build Solution 4. Run the Application

Press F5 or click Start Debugging

 Usage Instructions
 Starting the Application

Launches with a professional homepage

Navigate to main menu using the “Enter Main Menu” button

 Reporting Issues

Select “Report Issues” from the main menu

Fill in location, category, and description

Optionally attach supporting files

Submit to receive a confirmation and reference number

 Viewing Events

Select “Events & Announcements” from the main menu

Browse community events

Use search and filter functionality

Click events to view detailed information

Access personalized recommendations

Project Structure
MunicipalServicesAppPOE/
├── Program.cs                 # Application entry point
├── HomePageForm.cs            # Welcome screen
├── MainMenuForm.cs            # Main navigation hub
├── ReportIssueForm.cs         # Issue reporting functionality
├── EventsSystemForm.cs        # Events management system
├── DataStorage.cs             # JSON data persistence
└── Properties/
    └── Resources.resx         # Application resources

Technical Implementation
Key Classes

ReportedIssue – Data model for issue reports

Event – Data model for community events

DataStorage – Handles JSON file operations

 User Engagement Features

Dynamic feedback messages

Progress indicators

Success confirmation dialogs

Reference number generation

 Development Specifications

Built using Windows Forms (.NET Framework)

Implements professional UI/UX principles

Includes comprehensive error handling

Follows object-oriented programming principles

Adheres to municipal service requirements

 Future Enhancements

Database integration for persistent storage

User authentication system

Email notification system

Mobile application version

Real-time status updates

Service request tracking implementation

 Academic Context

This project was developed as part of a Programming (POE) assessment, demonstrating proficiency in:

C# programming and .NET Framework

Windows Forms development

Data structure implementation

User interface design

Software engineering principles

Municipal service application development

 Support

For technical issues or questions about this application, please refer to the project documentation or contact the development team.

