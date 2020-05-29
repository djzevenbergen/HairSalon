# _Hair Salon_

#### _MVC application for keeping track of hair stylists and their clients. 5/29/2020_

### Made by DJ Zevenbergen


## Description
_This C#/.NET Core MVC application uses a MySQL databse to allow the user to create and store hair stylists and the clients for those stylists. It allows the user to see specific details about any stylist on click, and then allows the user to click on a client for details._


## Setup/Installation Requirements
* Clone repository from GitHub in terminal or console
* ensure that C#/.netcore2.2 is installed on your computer
* in the terminal navigate to the project's root directory
* the david_zevenbergen.sql database should be functional as is
* use "dotnet restore HairSalon"
* to start the application use "dotnet build HairSalon" and "dotnet run HairSalon"



## Specs
1. User is presented with a homepage, and given the option to see go to the Stylists page
  * Input: "Go to vendors page"
  * Output: "/Stylists"
2. User can create a new Stylist
  * Input: "create new Stylist"
  * Output: "/stylists/create
3. User fills out stylist form and is redirected to now populated stylists page
  * Input: "Jan" "Janison" "5555555555" "add stylist"
  * Output: "/stylists/index" "Jan Janison"
4. User can click on a Stylist to see details incl. all orders clients that that stylist has
  * Input: "Click 'Jan Janison'"
  * Output: "Jan Janison Details"
            "First Name: Jan"
            "Last Name: Janison"
            "Phone Number: 5555555555"
            "Client List"
            "No clients yet!"
            "Add client"
            "Edit Stylist"
            "Delete Stylist"
            "Back to List"
5. User can click Add Client on that stylist's page
  * Input: "Add Client"
  * Output: "/clients/create"
6. User fills out a Client form and is then redirecte to the Stylist's page to whom that client was added" 
  * Input: "Jim" "Johnson" "2222222222" "Jan" "add client"
  * Output: "/vendors/details/{jan's id}"

7. User can search for clients or stylists by first or last name
  * Input: "jim" "clients" "search by first name" "search"
  * Output: "Jim Johnson"

8. User can click on clients for more details on either the Stylist's details page or from the search
  * Input: "click jim johnson"
  * Output: "Client Details"
            "First Name: Jim"
            "Last Name: Johnson"
            "Phone Number: 2222222222"
            "Stylist: Jan"
            "edit client"
            "delete this client"
            "back to stylist"


## Support
_Open an issue_


## Built With
C#/ASP.NET Core 

### License
This project is licensed under the MIT License

Copyright (c) 2020 **_DJ Zevenbergen_**