// See https://aka.ms/new-console-template for more information
using Task_additional;


//In case of calling AnimalMove method directly from AnimalBase class, everything works as expected:
//if call AnimalMove method under FourLegAnimalDerived reference, which is closed by new, then indeed virtual method
//AnimalMove from base class will be closed by method from FourLegAnimalDerived class:

FourLegAnimalDerived animal1 = new FourLegAnimalDerived();
Console.WriteLine("Invoke AnimalBase method directly:");
animal1.AnimalMove();

Console.WriteLine(new string("-------------------------"));

//BUT in case of calling method AnimalBase through some other method(ex. Move() in base class, NVI pattern), 
//then even if we create an object under FourLegAnimalDerived reference, realization of virtual method from base class will be called:

FourLegAnimalDerived animal2 = new FourLegAnimalDerived();
Console.WriteLine("Invoke AnimalBase method through Move method:");
animal1.Move();
