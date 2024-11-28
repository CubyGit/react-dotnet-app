# Vegetable Market App

A full-stack web application for managing a vegetable market. Built with:

- **Backend**: ASP.NET Core Web API
- **Frontend**: React.js

## Features
- Add, update, and delete products.
- View product list in real-time.
- Backend connected to a SQL Server database.

---

## Installation

### Prerequisites
- **Node.js** (for frontend)
- **.NET SDK** (for backend)
- **SQL Server** (for the database)

---

### Backend Setup
1. Navigate to the `backend` folder:
   ```bash
   cd backend
   ```

2. **Install dependencies**:
   - Ensure you have .NET SDK installed. You can download it from [here](https://dotnet.microsoft.com/download).
   - Run the following command to restore the NuGet packages:
     ```bash
     dotnet restore
     ```

3. **Set up the database**:
   - Ensure SQL Server is installed and running, or use a local database.
   - Modify the connection string in `appsettings.json` to match your SQL Server setup. For example:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=your_server_name;Database=VegetableMarket;User Id=your_username;Password=your_password;"
     }
     ```


4. **Create the database**:
   - Use Entity Framework Core to set up the database schema by running:
     ```bash
     dotnet ef migrations add InitialCreate
     dotnet ef database update
     ```

5. **Run the backend API**:
   ```bash
   dotnet run
   ```

6. **Test the API**:
   - Once the backend is running, you can test the API endpoints (e.g., `GET /api/products`) using tools like Postman or simply by navigating to the URL in your browser.
   - You should be able to perform CRUD operations on the products via the API.

### Frontend Setup:

1. **Navigate to the `frontend` folder**:
   ```bash
   cd ../frontend
   ```

2. **Install Node.js and npm**:
   - Ensure Node.js is installed. You can download it from [here](https://nodejs.org/en/download/).
   - If Node.js is already installed, you can skip this step.

3. **Install frontend dependencies**:
   - Install all the required dependencies by running:
     ```bash
     npm install
     ```

4. **Configure the API URL**:
   - Open the `src/App.js` file and ensure the backend API URL matches the one you're using (for example, `http://localhost:5017`).

5. **Run the frontend app**:
   ```bash
   npm start
   ```
   The frontend should now be running at `http://localhost:3000`.

## Usage

Once both the frontend and backend are running, you can:

1. **Add new products** by filling out the form and clicking "Add Product".
2. **View the list of products** in the main interface.
3. **Edit or delete products** (this functionality can be added in the future).

## Future Improvements
- Implement product editing and deletion functionality on the frontend.
- Add validation for form inputs on the frontend and backend.
- Implement user authentication and authorization for product management.
- Improve styling for a better user experience.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
