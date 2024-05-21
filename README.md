# Car JSON Serialization Project

This project is designed to help you learn how to work with JSON objects using the .NET framework. It includes functionalities for adding, viewing, saving, and loading car details, with the data being serialized to and deserialized from JSON format.

## Table of Contents

- [Introduction](#introduction)
- [Installation](#installation)
- [Usage](#usage)
- [Features](#features)
- [Contact](#contact)

## Introduction

This project demonstrates how to create a simple application that manages car details using JSON for data storage. The project consists of three main classes:
- `Vehicle`: A base class for vehicles.
- `Car`: A derived class from `Vehicle` with additional properties specific to cars.
- `Program`: The main class that provides a menu for interacting with car data.

## Installation

1. **Clone the repository:**

    ```sh
    git clone https://github.com/yourusername/car-json-serialization.git
    cd car-json-serialization
    ```

2. **Open the project in your preferred .NET development environment (e.g., Visual Studio).**

3. **Build the project to restore dependencies and compile the code.**

## Usage

1. **Run the application:**

    After building the project, run the application. You will be presented with a menu:

    ```
    ***************************************
    Please choose an option: 
    1. Add Car
    2. View Car
    3. Save Car
    4. Load Car
    5. Exit
    ***************************************
    ```

2. **Menu Options:**

    - **Add Car:** Enter car details such as make, model, year, color, VIN, number of doors, number of seats, and fuel type.
    - **View Car:** Display the current car details.
    - **Save Car:** Save the current car details to a `car.json` file.
    - **Load Car:** Load car details from the `car.json` file.
    - **Exit:** Exit the application.

## Features

- **Add Car:** Input and validate car details.
- **View Car:** Display car details in a readable format.
- **Save Car:** Serialize car details to JSON and save to a file.
- **Load Car:** Deserialize car details from a JSON file and load into the application.

## Contact

For any questions or issues, please contact:

- **Name:** Nithish Jagadeesan
- **Email:** [nithish.jagadeesan@gmail.com](mailto:nithish.jagadeesan@gmail.com)
