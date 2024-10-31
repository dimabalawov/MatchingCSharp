using System;

namespace MatchingCSharp
{
    public interface ITransport
    {
        string Name { get; set; }
        void Move();
    }

    public abstract class Ground : ITransport
    {
        public string Name { get; set; }
        public virtual void Move() => Console.WriteLine("I am moving on the ground.");
    }

    public abstract class Water : ITransport
    {
        public string Name { get; set; }
        public virtual void Move() => Console.WriteLine("I am moving by the water.");
    }

    public abstract class Air : ITransport
    {
        public string Name { get; set; }
        public virtual void Move() => Console.WriteLine("I am moving in the sky.");
    }

    public class Car : Ground
    {
        public Car() => Name = "Car";

        public override void Move()
        {
            base.Move();
            Console.WriteLine("I am moving by the road.");
        }

        public void Honk() => Console.WriteLine("Car is honking: Beep Beep!");
    }

    public class Train : Ground
    {
        public Train() => Name = "Train";

        public override void Move()
        {
            base.Move();
            Console.WriteLine("I am moving on the tracks.");
        }

        public void BlowWhistle() => Console.WriteLine("Train is blowing the whistle: Choo Choo!");
    }

    public class Cart : Ground
    {
        public Cart() => Name = "Cart";

        public override void Move()
        {
            base.Move();
            Console.WriteLine("I am moving on any ground-surface.");
        }

        public void AttachHorse() => Console.WriteLine("Cart is being pulled by a horse.");
    }

    public class Boat : Water
    {
        public Boat() => Name = "Boat";

        public override void Move()
        {
            base.Move();
            Console.WriteLine("I do not go really far from the coast.");
        }

        public void DropAnchor() => Console.WriteLine("Boat is dropping anchor.");
    }

    public class Tanker : Water
    {
        public Tanker() => Name = "Tanker";

        public override void Move()
        {
            base.Move();
            Console.WriteLine("I can transport containers across the world.");
        }

        public void LoadCargo() => Console.WriteLine("Tanker is loading cargo.");
    }

    public class Ship : Water
    {
        public Ship() => Name = "Ship";

        public override void Move()
        {
            base.Move();
            Console.WriteLine("I can transport a lot of passengers.");
        }

        public void StartCruise() => Console.WriteLine("Ship is starting a cruise.");
    }

    public class Plane : Air
    {
        public Plane() => Name = "Plane";

        public override void Move()
        {
            base.Move();
            Console.WriteLine("I can transport a lot of passengers.");
        }

        public void TakeOff() => Console.WriteLine("Plane is taking off.");
    }

    public class Heli : Air
    {
        public Heli() => Name = "Heli";

        public override void Move()
        {
            base.Move();
            Console.WriteLine("I can go up vertically.");
        }

        public void Hover() => Console.WriteLine("Heli is hovering in place.");
    }

    public class Dirigible : Air
    {
        public Dirigible() => Name = "Dirigible";

        public override void Move()
        {
            base.Move();
            Console.WriteLine("I am lighter than air.");
        }

        public void Inflate() => Console.WriteLine("Dirigible is inflating with gas.");
    }

    public static class TransportFactory
    {
        public static ITransport? CreateTransport(string choice)
        {
            return choice.ToLower() switch
            {
                "car" => new Car(),
                "train" => new Train(),
                "cart" => new Cart(),
                "boat" => new Boat(),
                "tanker" => new Tanker(),
                "ship" => new Ship(),
                "plane" => new Plane(),
                "heli" => new Heli(),
                "dirigible" => new Dirigible(),
                _ => null
            };
        }
    }

}
