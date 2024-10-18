using _02_hotel_challenge.Classes;

Person person1 = new("John", "Doe");
Person person2 = new("Jane", "Sing");
Person person3 = new("Bruno", "Boes");
Console.WriteLine("making a list");
List<Person> list1 = [person1, person2, person3];
Console.WriteLine("list made");
Suite suite1 = new("tetsando123", 4, 100.10M);


Reservation reservation1 = new(10);
reservation1.RegisterSuite(suite1);
reservation1.RegisterGuests(list1);

int guestTotal = reservation1.GuestsQuantity();

Console.WriteLine($"Total guests: {guestTotal}");

string guestsNames = reservation1.guestsNames();

Console.WriteLine($"Guests names: {guestsNames}");

decimal totalValue = reservation1.TotalValue();

Console.WriteLine($"Total value: {totalValue}");