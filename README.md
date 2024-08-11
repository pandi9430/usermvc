# usermvcproject

## Overview

`usermvcproject` is a basic ASP.NET MVC project that demonstrates user management functionalities. It features a UserMaster page where users can be added, edited, and viewed in a table format. The project utilizes Bootstrap for responsive design and includes modals for adding and viewing user details.

## Features

- **User Management:** Add, edit, and view user details.
- **Responsive Design:** The application is designed to be responsive, making use of Bootstrap to ensure it works well on various screen sizes.
- **Modals:** Uses Bootstrap modals for adding new users and viewing user details.
- **Data Table:** Displays user data in a table format.

## Technologies Used

- **ASP.NET Core MVC:** The framework used for building the web application.
- **Bootstrap 4:** Used for styling and responsive design.
- **JavaScript:** For dynamic functionality such as modal interactions.
- **jQuery:** For handling DOM manipulations and events.

## Getting Started

### Prerequisites

- .NET SDK (version 6.0 or later)
- Visual Studio 2022 or later

### Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/usermvcproject.git
    ```

2. Navigate to the project directory:
    ```bash
    cd usermvcproject
    ```

3. Restore the dependencies:
    ```bash
    dotnet restore
    ```

4. Run the application:
    ```bash
    dotnet run
    ```

5. Open your web browser and navigate to `http://localhost:5000` to view the application.

## Usage

- **Add User:** Click the "Add" button to open the modal and enter user details. Click "Save" to add the user.
- **View Details:** Click the "Details" button next to a user to view their details in a modal.
- **Edit User:** Click the "Edit" button to navigate to the edit page for that user.
- **Delete User:** Click the "Delete" button to remove the user from the system.

## Modals

### Add User Modal

Allows the user to input and save new user information.

### Details Modal

Displays detailed information about a selected user.

## Contributing

If you wish to contribute to this project, please fork the repository and submit a pull request with your changes.



