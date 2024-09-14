using sdc1_knowledge_check2;

Console.WriteLine("How many cat records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine()!);

var recordList = new List<Cat>();
for (int i = 0; i < numberOfRecords; i++)
{
	// In this loop, populate the object's properties using Console.ReadLine()
	var cat = new Cat();
	do
	{
		Console.WriteLine($"Enter the name for cat #{i+1}.");
		cat.Name = Console.ReadLine()!;
	} while (cat.Name == "");
	
	bool validEntry = false;
	do
	{
		
		Console.WriteLine($"Enter the weight for cat #{i+1} in pounds.");
		validEntry = double.TryParse(Console.ReadLine(), out var inputAsDouble);
		cat.Weight = inputAsDouble;
	} while (!validEntry);
    
    do
	{
		Console.WriteLine($"Enter the breed for cat #{i+1}.");
		cat.Breed = Console.ReadLine()!;
	} while (cat.Breed == "");
	

	recordList.Add(cat);
}

// Print out the list of records using Console.WriteLine()
Console.WriteLine("Here are the cats you added:");
recordList.ForEach(x => Console.WriteLine(x.ToString()));
