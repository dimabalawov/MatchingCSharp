using MatchingCSharp;

Console.WriteLine("Choose a transport (car, train, cart, boat, tanker, ship, plane, heli, dirigible):");
string? choice = Console.ReadLine();

ITransport? transport = TransportFactory.CreateTransport(choice ?? string.Empty);

if (transport != null)
{
    Console.WriteLine($"Created transport: {transport.Name}");
    transport.Move();

    switch (transport) //pattern matching
    {
        case Car car:
            car.Honk();
            break;
        case Train train:
            train.BlowWhistle();
            break;
        case Cart cart:
            cart.AttachHorse();
            break;
        case Boat boat:
            boat.DropAnchor();
            break;
        case Tanker tanker:
            tanker.LoadCargo();
            break;
        case Ship ship:
            ship.StartCruise();
            break;
        case Plane plane:
            plane.TakeOff();
            break;
        case Heli heli:
            heli.Hover();
            break;
        case Dirigible dirigible:
            dirigible.Inflate();
            break;
        default:
            Console.WriteLine("No specific method for this transport.");
            break;
    }
}
else
{
    Console.WriteLine("Invalid transport choice.");
}