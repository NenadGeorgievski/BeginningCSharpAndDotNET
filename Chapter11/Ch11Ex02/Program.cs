using Ch11Ex02;

AnimalCollection animalCollection = new();
animalCollection.Add(new Chicken("Donna"));
animalCollection.Add(new Cow("Milka"));

foreach (Animal animal in animalCollection)
{
    animal.Feed();
}

animalCollection[1].Name = "Noah";

foreach (Animal animal in animalCollection)
{
    animal.Feed();
}

((Chicken)animalCollection[0]).LayEgg();