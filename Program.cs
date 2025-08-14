
// // Q1
// FinanceApp financeApp = new FinanceApp();

// Console.WriteLine("----- Finance App -----");
// financeApp.Run();
// Console.WriteLine();
// Console.WriteLine();

// // Q2
// var healthApp = new HealthSystemApp();
// healthApp.SeedData();
// healthApp.BuildPrescriptionMap();
// healthApp.PrintAllPatients();

// healthApp.PrintPrescriptionsForPatient(1);

// Q3
// WareHouseManager manager = new WareHouseManager();
// manager.SeedData();

// Console.WriteLine("\n--- Grocery Items ---");
//         manager.PrintAllItems(manager.GetGroceriesRepo());

//         Console.WriteLine("\n--- Electronic Items ---");
//         manager.PrintAllItems(manager.GetElectronicsRepo());

//         // Trigger DuplicateItemException
//         try
//         {
//             manager.GetGroceriesRepo().AddItem(new GroceryItem(1, "Duplicate Sausage", 5, DateTime.Now));
//         }
//         catch (DuplicateItemException ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}");
//         }

//         // Trigger ItemNotFoundException
//         try
//         {
//             manager.RemoveItemById(manager.GetGroceriesRepo(), 999);
//         }
//         catch (ItemNotFoundException ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}");
//         }

//         // Trigger InvalidQuantityException
//         try
//         {
//             manager.IncreaseStock(manager.GetGroceriesRepo(), 1, -5);
//         }
//         catch (InvalidQuantityException ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}");
//         }
    
// Q4

try
{
    string inputFile = "Q4/records.txt";
    string outputFile = "Q4/report.txt";

    StudentResultProcessor processor = new StudentResultProcessor();

    List<Student> students = processor.ReadStudentsFromFile(inputFile);

    processor.WriteReportToFile(students, outputFile);

    Console.WriteLine("Report generated successfully!");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Error: File not found. {ex.Message}");
}
catch (InvalidScoreFormat ex)
{
    Console.WriteLine($"Error: Invalid score format. {ex.message}");
}
catch (MissingFieldException ex)
{
    Console.WriteLine($"Error: Missing field. {ex.message}");
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}
