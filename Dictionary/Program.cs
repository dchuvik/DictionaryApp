

Dictionary <int, string> employeeIds = new Dictionary<int, string>();
string employeeName;
int counter = 0;
bool isIntCheck;
int UserInputEmployeeId;

do
{

	Console.Write("type 'done' if you are finshed\n" +
		"or Enter an employee name: ");
	employeeName = Console.ReadLine();
	employeeIds.Add(counter, employeeName);
    Console.WriteLine();
    Console.WriteLine($"{employeeName}'s employee id is {counter}");
	counter ++;
    Console.WriteLine();

} while (employeeName != "done");


do
{
	Console.Write("Enter an employee id to get their name: ");
	string employeeIdString = Console.ReadLine();

	isIntCheck = int.TryParse(employeeIdString, out UserInputEmployeeId);

    if (isIntCheck && UserInputEmployeeId < employeeIds.Count && UserInputEmployeeId > 0)
    {
        Console.WriteLine($"{UserInputEmployeeId} number is associated with {employeeIds[UserInputEmployeeId]}");
    }
    else
    {
        Console.WriteLine("invalid input Try Again... ");
    }

} while (!isIntCheck || UserInputEmployeeId > employeeIds.Count || UserInputEmployeeId < 0);