# Hospital Management System 🏥

A desktop Hospital Management System built with C# Windows Forms and Microsoft SQL Server, developed as a Final Project for the L3 Diploma in Information Technology at ESOFT Metro Campus.

## 📖 About

A Hospital Management System (HMS) is software designed to manage and organize hospital activities digitally — replacing manual paperwork with a centralized, searchable system for patient records, doctor information, appointments, medical records, and pharmacy stock.


## 🕹️ Features / Modules
Login System — secure username/password authentication with error handling for invalid credentials
<img width="439" height="231" alt="image" src="https://github.com/user-attachments/assets/9edd0a0c-ac15-44f3-a738-03935e908f96" />

<img width="486" height="283" alt="image" src="https://github.com/user-attachments/assets/336f7451-1b06-4a9c-8be6-bf1e46e4deee" />

Doctor Management — insert, update, delete, and search doctor records (ID, name, specialization, phone number, gender)
Patient Management — manage patient records (ID, name, age, gender, address)
Appointment Details — track patient appointments with doctor name, date, appointment number, and fees
Medical Record Management — store patient symptoms, blood group, and other medical details
Pharmacy Management — track medicine stock, category, selling price, purchase price, and quantity sold
Dashboard — live overview showing total number of patients, doctors, and appointments
CRUD Operations — every module supports Insert, Update, Delete, Search, and Reset, each with confirmation message boxes (e.g. "Data successfully inserted")
## 🛠️ Built With
Language: C# (.NET, Windows Forms)
Database: Microsoft SQL Server
IDE: Microsoft Visual Studio

## 🗂️ Database Tables
patient — patientid, patientname, patientage, patientgender, patientaddress
doctor — doctorid, doctorname, doctorspecialisation, doctornumber, gender
appointmentdetails — patientid, patientage, doctorname, date, appointmentnumber, appointmentfee
medicalrecord — patientid, patientname, patientage, symptoms, bloodgroup, gender
pharmacy — medid, category, sellingprice, purchaseprice, stocklevel, quantitysold
## 🚀 Getting Started
Clone or download this repository
Open the .sln file in Visual Studio
Restore/attach the SQL Server database used by the project (see the connection string in the source code)
Build and run the solution (F5)
Log in with valid credentials to access the main menu (Doctor, Patient, Appointment, Medical Record, Pharmacy, Dashboard)
📐 Use Case Overview
Customer Service — manages patient info, doctor info, appointment details, and views the dashboard
Doctor — manages medical record details
Pharmacy — manages pharmacy/medicine details
<img width="622" height="603" alt="image" src="https://github.com/user-attachments/assets/01298e44-ef1e-422e-b853-c3b4a194f604" />

