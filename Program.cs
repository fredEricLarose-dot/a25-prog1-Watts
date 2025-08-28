const double WATT_PAR_HEURES = 150.0;
const double COUT_PAR_HEURE = 0.15 / 100.0;

string entree;
double heuresDUtilisation;

double coutDUtilisation;

Console.WriteLine("Combien d'heure par jour utilisez-vous l'ordinateur ?");
entree = Console.ReadLine();
heuresDUtilisation = Convert.ToDouble(entree);
Console.Clear();

coutDUtilisation = heuresDUtilisation * WATT_PAR_HEURES * COUT_PAR_HEURE;
Convert.ToString(coutDUtilisation);

Console.WriteLine("L'ordinateur à coûté " + coutDUtilisation + "$ aujourd'hui.");