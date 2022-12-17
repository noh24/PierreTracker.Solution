# Pierre's Bakery

#### Tracks Pierre Bakery's vendors and their orders

#### Created by [Brian Noh](https://github.com/noh24)

## Technologies Used

- C#
- .NET 6.0
- MSTest
- ASP.NET Core 6 Mvc
- Tailwindcss
- HTML

## Description

This application tracks the vendors that purchase baked goods from Pierre and orders belonging to those vendors
## Setup/Installation Requirements

- Clone this repository to your Desktop:
  1. Your computer will need to have GIT installed. If you do not currently have GIT installed, follow [these](https://docs.github.com/en/get-started/quickstart/set-up-git) directions for installing and setting up GIT.
  2. Once GIT is installed, clone this repository by typing following commands in your command line:
     ```
     $ cd Desktop
     $ git clone https://github.com/noh24/PierreTracker.Solution.git
     $ cd PierreTracker.Solution
     ```
- Install the [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Install packages and tools:
  ```
  ~/Desktop/PierreTracker.Solution/ $ npm install
  ~/Desktop/PierreTracker.Solution/ $ dotnet restore PierreTracker.Tests/
  ```
- Build the project:
  ```
   ~/Desktop/PierreTracker.Solution/ $ dotnet build PierreTracker/
  ```
- Run the project
  ```
   ~/Desktop/PierreTracker.Solution/ $ dotnet run --project PierreTracker
  ```
- Optional: Run tests
  ```
   ~/Desktop/PierreTracker.Solution/ $ dotnet test PierreTracker.Tests/
  ```

## Known Bugs

- Order delete feature is not working. Code pertaining to order delete feature has been commented out.

## License

[MIT License](./license.txt)

Copyright (c) 2022 Brian Noh