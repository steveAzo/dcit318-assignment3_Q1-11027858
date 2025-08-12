FinanceApp financeApp = new FinanceApp();

Console.WriteLine("----- Finance App -----");
financeApp.Run();
Console.WriteLine();
Console.WriteLine();

var healthApp = new HealthSystemApp();
healthApp.SeedData();
healthApp.BuildPrescriptionMap();
healthApp.PrintAllPatients();

healthApp.PrintPrescriptionsForPatient(1);
