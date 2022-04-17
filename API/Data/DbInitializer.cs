using System.Collections.Generic;
using System.Linq;
using API.Entities;
using System;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Cars.Any()) return;

            var cars = new List<Car>
            {
                new Car
                {
                    Brand = "Audi",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    PictureUrl="/images/lnd3.jpg",
                    TransmissionType="Mechanic",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                 new Car
                {
                    Brand = "Lada vesta",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    TransmissionType="Automatic",
                    PictureUrl="/images/pi3.jpg",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                new Car
                {
                    Brand = "Audi",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    PictureUrl="/images/lnd3.jpg",
                    TransmissionType="Mechanic",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                 new Car
                {
                    Brand = "Lada vesta",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    TransmissionType="Automatic",
                    PictureUrl="/images/Toyota.jpeg",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                 new Car
                {
                    Brand = "Lada vesta",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    TransmissionType="Automatic",
                    PictureUrl="/images/pi3.jpg",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                 new Car
                {
                    Brand = "Lada vesta",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    TransmissionType="Automatic",
                    PictureUrl="/images/pi3.jpg",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                new Car
                {
                    Brand = "Audi",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    PictureUrl="/images/lnd3.jpg",
                    TransmissionType="Mechanic",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                 new Car
                {
                    Brand = "Lada vesta",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    TransmissionType="Automatic",
                    PictureUrl="/images/pi3.jpg",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                new Car
                {
                    Brand = "Audi",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    PictureUrl="/images/lnd3.jpg",
                    TransmissionType="Mechanic",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                 new Car
                {
                    Brand = "Lada vesta",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    TransmissionType="Automatic",
                    PictureUrl="/images/Toyota.jpeg",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                 new Car
                {
                    Brand = "Lada vesta",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    TransmissionType="Automatic",
                    PictureUrl="/images/pi3.jpg",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                 new Car
                {
                    Brand = "Lada vesta",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    TransmissionType="Automatic",
                    PictureUrl="/images/pi3.jpg",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                new Car
                {
                    Brand = "Audi",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    PictureUrl="/images/lnd3.jpg",
                    TransmissionType="Mechanic",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                 new Car
                {
                    Brand = "Lada vesta",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    TransmissionType="Automatic",
                    PictureUrl="/images/pi3.jpg",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                new Car
                {
                    Brand = "Audi",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    PictureUrl="/images/lnd3.jpg",
                    TransmissionType="Mechanic",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                 new Car
                {
                    Brand = "Lada vesta",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    TransmissionType="Automatic",
                    PictureUrl="/images/Toyota.jpeg",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                 new Car
                {
                    Brand = "Lada vesta",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    TransmissionType="Automatic",
                    PictureUrl="/images/pi3.jpg",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                 new Car
                {
                    Brand = "Lada vesta",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    PricePerDay = 20000,
                    Name="dioe",
                    Model="Model",
                    FuelConsumptionPerHundred = 100,
                    TransmissionType="Automatic",
                    PictureUrl="/images/pi3.jpg",
                    NumberOfSeats = 5,
                    Color = "white",
                    RentalPointId="grod",
                    LastViewTime = DateTime.Now.AddMonths(-2)
                },
                          };

            foreach (var car in cars)
            {
                context.Cars.Add(car);
            }

            context.SaveChanges();
        }
    }
}