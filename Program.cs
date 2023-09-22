string[] list = File.ReadAllLines("../../../Husdjur.csv");              // Läser in filen till en array

Dictionary<string, int> animalSort = new Dictionary<string, int>();     //Skapar en Dictionary men en string[0] och int [1], som heter animalSort

int allAge = 0;


foreach (var row in list)                           //Läser varje rad i "Husdjur.csv"
{
    string[] split = row.Split(",");                   // Delar på varje rad vid "," och lägger de i "split"           
    if (int.TryParse(split[1], out int age))           // försöker göra om "index 1" från sträng till int och nämner den till "age"
    {
        animalSort.Add(split[0], age);      //Om TryParse lyckas läggs namn(split[0]) och ålder(age) till i Dictionary animalSort
        allAge = age;
    }
    else                                    // Lyckas inte TryParse, skrivs det ut ett felmeddelande.
    {
        Console.WriteLine("Something went wrong");
    }
}
Console.WriteLine(animalSort);


List<int> animalAge = new List<int>(allAge);



bool sort = true;                       // Skapar en bool

for (int i = 0; i < animalAge.ToArray().Length - 1 && sort; i++)     // Gör en loop för varje tal i allAge
{                                                       //Fortsätter sålänge allAge mindre än 0 och "sort" är true
    sort = false;   // Blir false när vi går in i yttersta loopen

    for (int j = 0; j < animalAge.ToArray().Length - 1 - i; j++)
    {
        if (animalAge[j] > animalAge[j + 1])
        {
            sort = true; // Blir true om den går in i "if" för att sortera.

            //Börjar sortera, byta plats på talen.
            int temp = animalAge[j + 1];
            animalAge[j + 1] = animalAge[j];
            animalAge[j] = temp;
        }
    }
    //Om if-satsen inte blir aktiverad, sort == false, och loopen fortsätter inte.
}



