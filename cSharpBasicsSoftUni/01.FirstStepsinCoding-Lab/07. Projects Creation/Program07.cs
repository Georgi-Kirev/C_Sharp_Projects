string ArchitectName = Console.ReadLine();
int WorkHour = 3;
string ProjectNumbers = Console.ReadLine();

double TotalProjects = double.Parse(ProjectNumbers) * WorkHour;
Console.WriteLine($"The architect {ArchitectName} will need {TotalProjects} hours to complete {ProjectNumbers} project/s.");