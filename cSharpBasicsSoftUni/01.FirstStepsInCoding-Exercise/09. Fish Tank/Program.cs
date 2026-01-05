double Lenght = double.Parse(Console.ReadLine());
double Wight = double.Parse(Console.ReadLine());
double Hight = double.Parse(Console.ReadLine());
double Filler = double.Parse(Console.ReadLine());

double VolumeEmpty = Lenght * Wight * Hight;
double VolumeLitters = VolumeEmpty / 1000;
double VolumeFiller = Filler / 100.0;
double LittersNeeded = VolumeLitters * (1 - VolumeFiller);
Console.WriteLine(LittersNeeded);

// Ctrl + K + C = прави всичко в коментар ( // )