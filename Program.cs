Console.WriteLine("Before calling BrewPotion\n");
async Task BrewPotion()
{

    Console.WriteLine("Starting potion brewing...\n");
       
    

    await Task.Delay(3000);

    

    Console.WriteLine("Finished Potion\n");
   

}
await BrewPotion();
Console.WriteLine("After calling BrewPotion");
