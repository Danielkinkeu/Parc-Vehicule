using System;
using System.Diagnostics;

class VehicleManagementSystem
{
    private List<Vehicle> vehicles;
    private List<User> users;

    public VehicleManagementSystem()
    {
        vehicles = new List<Vehicle>();
        users = new List<User>();
    }

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void AssignVehicleToUser(Vehicle vehicle, User user)
    {
        vehicle.User = user;
        user.Vehicles.Add(vehicle);
    }

    public void AddExpenseToVehicle(Vehicle vehicle, Expense expense)
    {
        vehicle.Expenses.Add(expense);
    }

    public void PrintCostSheet(Vehicle vehicle, DateTime month)
    {
        // Logic to print cost sheet for the given vehicle and month
        // This will require iterating through the expenses of the vehicle in the given month
    }

    public List<Expense> GetExpensesByUserAndVehicle(User user, Vehicle vehicle)
    {
        var expenses = new List<Expense>();

        if (user.Vehicles.Contains(vehicle))
        {
            foreach (var expense in vehicle.Expenses)
            {
                if (expense.AgentMaintenance == user)
                {
                    expenses.Add(expense);
                }
            }
        }

        return expenses;
    }
}