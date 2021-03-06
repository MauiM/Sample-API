﻿using System.Collections.Generic;

namespace Sample.API.Utilities
{
    // Excel function
    // =CONCATENATE("AddModel(", CHAR(34), A1, CHAR(34), ", ", CHAR(34), B1, CHAR(34), ");")
    // Output: AddModel("Acura", "ILX");

    // https://github.com/abhionlyone/us-car-models-data/blob/master/2020.csv

    public static class MakeModelHelper
    {
        /// <summary>
        /// Key: Make, Values: Model List
        /// </summary>
        public static Dictionary<string, List<string>> MakeAndModels = null;

        static MakeModelHelper()
        {
            // Initialize
            if (MakeAndModels == null)
            {
                MakeAndModels = new Dictionary<string, List<string>>();

                AddMakeAndModel("Acura", "ILX");
                AddMakeAndModel("Acura", "MDX");
                AddMakeAndModel("Acura", "MDX Sport Hybrid");
                AddMakeAndModel("Acura", "NSX");
                AddMakeAndModel("Acura", "RDX");
                AddMakeAndModel("Acura", "RLX");
                AddMakeAndModel("Acura", "RLX Sport Hybrid");
                AddMakeAndModel("Acura", "TLX");
                AddMakeAndModel("Alfa Romeo", "4C Spider");
                AddMakeAndModel("Alfa Romeo", "Giulia");
                AddMakeAndModel("Alfa Romeo", "Stelvio");
                AddMakeAndModel("Audi", "A3");
                AddMakeAndModel("Audi", "A4");
                AddMakeAndModel("Audi", "A5");
                AddMakeAndModel("Audi", "A6");
                AddMakeAndModel("Audi", "A6 allroad");
                AddMakeAndModel("Audi", "A7");
                AddMakeAndModel("Audi", "Q3");
                AddMakeAndModel("Audi", "Q5");
                AddMakeAndModel("Audi", "Q7");
                AddMakeAndModel("Audi", "Q8");
                AddMakeAndModel("Audi", "R8");
                AddMakeAndModel("Audi", "S4");
                AddMakeAndModel("Audi", "S8");
                AddMakeAndModel("Audi", "SQ5");
                AddMakeAndModel("Audi", "TT");
                AddMakeAndModel("BMW", "2 Series");
                AddMakeAndModel("BMW", "3 Series");
                AddMakeAndModel("BMW", "4 Series");
                AddMakeAndModel("BMW", "5 Series");
                AddMakeAndModel("BMW", "7 Series");
                AddMakeAndModel("BMW", "8 Series");
                AddMakeAndModel("BMW", "M2");
                AddMakeAndModel("BMW", "X1");
                AddMakeAndModel("BMW", "X2");
                AddMakeAndModel("BMW", "X3");
                AddMakeAndModel("BMW", "X3 M");
                AddMakeAndModel("BMW", "X4");
                AddMakeAndModel("BMW", "X5");
                AddMakeAndModel("BMW", "X6");
                AddMakeAndModel("BMW", "X7");
                AddMakeAndModel("BMW", "Z4");
                AddMakeAndModel("Buick", "Enclave");
                AddMakeAndModel("Buick", "Encore");
                AddMakeAndModel("Buick", "Encore GX");
                AddMakeAndModel("Buick", "Envision");
                AddMakeAndModel("Buick", "Regal Sportback");
                AddMakeAndModel("Buick", "Regal TourX");
                AddMakeAndModel("Cadillac", "CT4");
                AddMakeAndModel("Cadillac", "CT5");
                AddMakeAndModel("Cadillac", "CT6");
                AddMakeAndModel("Cadillac", "CT6-V");
                AddMakeAndModel("Cadillac", "Escalade");
                AddMakeAndModel("Cadillac", "Escalade ESV");
                AddMakeAndModel("Cadillac", "XT4");
                AddMakeAndModel("Cadillac", "XT5");
                AddMakeAndModel("Cadillac", "XT6");
                AddMakeAndModel("Chevrolet", "Blazer");
                AddMakeAndModel("Chevrolet", "Bolt EV");
                AddMakeAndModel("Chevrolet", "Camaro");
                AddMakeAndModel("Chevrolet", "Colorado Crew Cab");
                AddMakeAndModel("Chevrolet", "Colorado Extended Cab");
                AddMakeAndModel("Chevrolet", "Corvette");
                AddMakeAndModel("Chevrolet", "Equinox");
                AddMakeAndModel("Chevrolet", "Express 2500 Cargo");
                AddMakeAndModel("Chevrolet", "Express 3500 Cargo");
                AddMakeAndModel("Chevrolet", "Impala");
                AddMakeAndModel("Chevrolet", "Malibu");
                AddMakeAndModel("Chevrolet", "Silverado 1500 Crew Cab");
                AddMakeAndModel("Chevrolet", "Silverado 1500 Double Cab");
                AddMakeAndModel("Chevrolet", "Silverado 1500 Regular Cab");
                AddMakeAndModel("Chevrolet", "Silverado 2500 HD Crew Cab");
                AddMakeAndModel("Chevrolet", "Silverado 2500 HD Double Cab");
                AddMakeAndModel("Chevrolet", "Silverado 3500 HD Crew Cab");
                AddMakeAndModel("Chevrolet", "Sonic");
                AddMakeAndModel("Chevrolet", "Spark");
                AddMakeAndModel("Chevrolet", "Suburban");
                AddMakeAndModel("Chevrolet", "Tahoe");
                AddMakeAndModel("Chevrolet", "Traverse");
                AddMakeAndModel("Chevrolet", "Trax");
                AddMakeAndModel("Chrysler", "300");
                AddMakeAndModel("Chrysler", "Pacifica");
                AddMakeAndModel("Chrysler", "Pacifica Hybrid");
                AddMakeAndModel("Chrysler", "Voyager");
                AddMakeAndModel("Dodge", "Challenger");
                AddMakeAndModel("Dodge", "Charger");
                AddMakeAndModel("Dodge", "Durango");
                AddMakeAndModel("Dodge", "Grand Caravan Passenger");
                AddMakeAndModel("Dodge", "Journey");
                AddMakeAndModel("FIAT", "124 Spider");
                AddMakeAndModel("FIAT", "500L");
                AddMakeAndModel("FIAT", "500X");
                AddMakeAndModel("Ford", "EcoSport");
                AddMakeAndModel("Ford", "Edge");
                AddMakeAndModel("Ford", "Escape");
                AddMakeAndModel("Ford", "Expedition");
                AddMakeAndModel("Ford", "Expedition MAX");
                AddMakeAndModel("Ford", "Explorer");
                AddMakeAndModel("Ford", "F150 Regular Cab");
                AddMakeAndModel("Ford", "F150 Super Cab");
                AddMakeAndModel("Ford", "F150 SuperCrew Cab");
                AddMakeAndModel("Ford", "F250 Super Duty Crew Cab");
                AddMakeAndModel("Ford", "F250 Super Duty Regular Cab");
                AddMakeAndModel("Ford", "F250 Super Duty Super Cab");
                AddMakeAndModel("Ford", "F350 Super Duty Crew Cab");
                AddMakeAndModel("Ford", "F350 Super Duty Super Cab");
                AddMakeAndModel("Ford", "F450 Super Duty Crew Cab");
                AddMakeAndModel("Ford", "Fusion");
                AddMakeAndModel("Ford", "Fusion Plug-in Hybrid");
                AddMakeAndModel("Ford", "Mustang");
                AddMakeAndModel("Ford", "Ranger SuperCab");
                AddMakeAndModel("Ford", "Ranger SuperCrew");
                AddMakeAndModel("Ford", "Transit 250 Cargo Van");
                AddMakeAndModel("Ford", "Transit 350 Passenger Van");
                AddMakeAndModel("Ford", "Transit Connect Cargo Van");
                AddMakeAndModel("Ford", "Transit Connect Passenger Wagon");
                AddMakeAndModel("Freightliner", "Sprinter 1500 Cargo");
                AddMakeAndModel("Freightliner", "Sprinter 1500 Passenger");
                AddMakeAndModel("Freightliner", "Sprinter 2500 Cargo");
                AddMakeAndModel("Freightliner", "Sprinter 2500 Crew");
                AddMakeAndModel("Freightliner", "Sprinter 2500 Passenger");
                AddMakeAndModel("Freightliner", "Sprinter 3500 Cargo");
                AddMakeAndModel("Freightliner", "Sprinter 3500 Crew");
                AddMakeAndModel("Freightliner", "Sprinter 3500 XD Crew");
                AddMakeAndModel("Freightliner", "Sprinter 3500XD Cargo");
                AddMakeAndModel("Freightliner", "Sprinter 4500 Cargo");
                AddMakeAndModel("Freightliner", "Sprinter 4500 Crew");
                AddMakeAndModel("Genesis", "G70");
                AddMakeAndModel("Genesis", "G80");
                AddMakeAndModel("Genesis", "G90");
                AddMakeAndModel("GMC", "Acadia");
                AddMakeAndModel("GMC", "Canyon Crew Cab");
                AddMakeAndModel("GMC", "Sierra 1500 Crew Cab");
                AddMakeAndModel("GMC", "Sierra 1500 Double Cab");
                AddMakeAndModel("GMC", "Sierra 1500 Regular Cab");
                AddMakeAndModel("GMC", "Sierra 2500 HD Crew Cab");
                AddMakeAndModel("GMC", "Sierra 3500 HD Crew Cab");
                AddMakeAndModel("GMC", "Terrain");
                AddMakeAndModel("GMC", "Yukon");
                AddMakeAndModel("GMC", "Yukon XL");
                AddMakeAndModel("Honda", "Accord");
                AddMakeAndModel("Honda", "Accord Hybrid");
                AddMakeAndModel("Honda", "Civic");
                AddMakeAndModel("Honda", "Civic Type R");
                AddMakeAndModel("Honda", "Clarity Fuel Cell");
                AddMakeAndModel("Honda", "Clarity Plug-in Hybrid");
                AddMakeAndModel("Honda", "CR-V");
                AddMakeAndModel("Honda", "CR-V Hybrid");
                AddMakeAndModel("Honda", "Fit");
                AddMakeAndModel("Honda", "HR-V");
                AddMakeAndModel("Honda", "Insight");
                AddMakeAndModel("Honda", "Odyssey");
                AddMakeAndModel("Honda", "Passport");
                AddMakeAndModel("Honda", "Pilot");
                AddMakeAndModel("Honda", "Ridgeline");
                AddMakeAndModel("Hyundai", "Accent");
                AddMakeAndModel("Hyundai", "Elantra");
                AddMakeAndModel("Hyundai", "Elantra GT");
                AddMakeAndModel("Hyundai", "Ioniq Electric");
                AddMakeAndModel("Hyundai", "Ioniq Hybrid");
                AddMakeAndModel("Hyundai", "Ioniq Plug-in Hybrid");
                AddMakeAndModel("Hyundai", "Kona");
                AddMakeAndModel("Hyundai", "Kona Electric");
                AddMakeAndModel("Hyundai", "NEXO");
                AddMakeAndModel("Hyundai", "Palisade");
                AddMakeAndModel("Hyundai", "Santa Fe");
                AddMakeAndModel("Hyundai", "Sonata");
                AddMakeAndModel("Hyundai", "Sonata Hybrid");
                AddMakeAndModel("Hyundai", "Tucson");
                AddMakeAndModel("Hyundai", "Veloster");
                AddMakeAndModel("Hyundai", "Venue");
                AddMakeAndModel("INFINITI", "Q50");
                AddMakeAndModel("INFINITI", "Q60");
                AddMakeAndModel("INFINITI", "QX50");
                AddMakeAndModel("INFINITI", "QX60");
                AddMakeAndModel("INFINITI", "QX80");
                AddMakeAndModel("Jaguar", "E-PACE");
                AddMakeAndModel("Jaguar", "F-PACE");
                AddMakeAndModel("Jaguar", "F-TYPE");
                AddMakeAndModel("Jaguar", "I-PACE");
                AddMakeAndModel("Jaguar", "XE");
                AddMakeAndModel("Jaguar", "XF");
                AddMakeAndModel("Jeep", "Cherokee");
                AddMakeAndModel("Jeep", "Compass");
                AddMakeAndModel("Jeep", "Gladiator");
                AddMakeAndModel("Jeep", "Grand Cherokee");
                AddMakeAndModel("Jeep", "Renegade");
                AddMakeAndModel("Jeep", "Wrangler");
                AddMakeAndModel("Jeep", "Wrangler Unlimited");
                AddMakeAndModel("Kia", "Cadenza");
                AddMakeAndModel("Kia", "Forte");
                AddMakeAndModel("Kia", "K900");
                AddMakeAndModel("Kia", "Niro");
                AddMakeAndModel("Kia", "Niro EV");
                AddMakeAndModel("Kia", "Niro Plug-in Hybrid");
                AddMakeAndModel("Kia", "Optima");
                AddMakeAndModel("Kia", "Optima Hybrid");
                AddMakeAndModel("Kia", "Optima Plug-in Hybrid");
                AddMakeAndModel("Kia", "Rio");
                AddMakeAndModel("Kia", "Sedona");
                AddMakeAndModel("Kia", "Sorento");
                AddMakeAndModel("Kia", "Soul");
                AddMakeAndModel("Kia", "Sportage");
                AddMakeAndModel("Kia", "Stinger");
                AddMakeAndModel("Kia", "Telluride");
                AddMakeAndModel("Land Rover", "Defender 110");
                AddMakeAndModel("Land Rover", "Defender 90");
                AddMakeAndModel("Land Rover", "Discovery");
                AddMakeAndModel("Land Rover", "Discovery Sport");
                AddMakeAndModel("Land Rover", "Range Rover");
                AddMakeAndModel("Land Rover", "Range Rover Evoque");
                AddMakeAndModel("Land Rover", "Range Rover Sport");
                AddMakeAndModel("Land Rover", "Range Rover Velar");
                AddMakeAndModel("Lexus", "ES");
                AddMakeAndModel("Lexus", "GS");
                AddMakeAndModel("Lexus", "GX");
                AddMakeAndModel("Lexus", "IS");
                AddMakeAndModel("Lexus", "LC");
                AddMakeAndModel("Lexus", "LS");
                AddMakeAndModel("Lexus", "LX");
                AddMakeAndModel("Lexus", "NX");
                AddMakeAndModel("Lexus", "RC");
                AddMakeAndModel("Lexus", "RX");
                AddMakeAndModel("Lexus", "UX");
                AddMakeAndModel("Lincoln", "Aviator");
                AddMakeAndModel("Lincoln", "Continental");
                AddMakeAndModel("Lincoln", "Corsair");
                AddMakeAndModel("Lincoln", "MKZ");
                AddMakeAndModel("Lincoln", "Nautilus");
                AddMakeAndModel("Lincoln", "Navigator");
                AddMakeAndModel("Lincoln", "Navigator L");
                AddMakeAndModel("MAZDA", "CX-3");
                AddMakeAndModel("MAZDA", "CX-30");
                AddMakeAndModel("MAZDA", "CX-5");
                AddMakeAndModel("MAZDA", "CX-9");
                AddMakeAndModel("MAZDA", "MAZDA3");
                AddMakeAndModel("MAZDA", "MAZDA6");
                AddMakeAndModel("MAZDA", "MX-5 Miata");
                AddMakeAndModel("MAZDA", "MX-5 Miata RF");
                AddMakeAndModel("Mercedes-Benz", "A-Class");
                AddMakeAndModel("Mercedes-Benz", "C-Class");
                AddMakeAndModel("Mercedes-Benz", "CLA");
                AddMakeAndModel("Mercedes-Benz", "CLS");
                AddMakeAndModel("Mercedes-Benz", "E-Class");
                AddMakeAndModel("Mercedes-Benz", "G-Class");
                AddMakeAndModel("Mercedes-Benz", "GLA");
                AddMakeAndModel("Mercedes-Benz", "GLB");
                AddMakeAndModel("Mercedes-Benz", "GLC");
                AddMakeAndModel("Mercedes-Benz", "GLE");
                AddMakeAndModel("Mercedes-Benz", "GLS");
                AddMakeAndModel("Mercedes-Benz", "Mercedes-AMG A-Class");
                AddMakeAndModel("Mercedes-Benz", "Mercedes-AMG C-Class");
                AddMakeAndModel("Mercedes-Benz", "Mercedes-AMG CLS");
                AddMakeAndModel("Mercedes-Benz", "Mercedes-AMG GLC");
                AddMakeAndModel("Mercedes-Benz", "Mercedes-AMG GLC Coupe");
                AddMakeAndModel("Mercedes-Benz", "Metris WORKER Cargo");
                AddMakeAndModel("Mercedes-Benz", "Metris WORKER Passenger");
                AddMakeAndModel("Mercedes-Benz", "S-Class");
                AddMakeAndModel("Mercedes-Benz", "SLC");
                AddMakeAndModel("Mercedes-Benz", "Sprinter 1500 Cargo");
                AddMakeAndModel("Mercedes-Benz", "Sprinter 1500 Passenger");
                AddMakeAndModel("Mercedes-Benz", "Sprinter 2500 Cargo");
                AddMakeAndModel("Mercedes-Benz", "Sprinter 2500 Crew");
                AddMakeAndModel("Mercedes-Benz", "Sprinter 2500 Passenger");
                AddMakeAndModel("Mercedes-Benz", "Sprinter 3500 Cargo");
                AddMakeAndModel("Mercedes-Benz", "Sprinter 3500 Crew");
                AddMakeAndModel("Mercedes-Benz", "Sprinter 3500 XD Cargo");
                AddMakeAndModel("Mercedes-Benz", "Sprinter 3500 XD Crew");
                AddMakeAndModel("Mercedes-Benz", "Sprinter 4500 Cargo");
                AddMakeAndModel("Mercedes-Benz", "Sprinter 4500 Crew");
                AddMakeAndModel("MINI", "Clubman");
                AddMakeAndModel("MINI", "Countryman");
                AddMakeAndModel("MINI", "Hardtop 2 Door");
                AddMakeAndModel("MINI", "Hardtop 4 Door");
                AddMakeAndModel("Mitsubishi", "Eclipse Cross");
                AddMakeAndModel("Mitsubishi", "Mirage");
                AddMakeAndModel("Mitsubishi", "Mirage G4");
                AddMakeAndModel("Mitsubishi", "Outlander");
                AddMakeAndModel("Mitsubishi", "Outlander PHEV");
                AddMakeAndModel("Mitsubishi", "Outlander Sport");
                AddMakeAndModel("Nissan", "370Z");
                AddMakeAndModel("Nissan", "Altima");
                AddMakeAndModel("Nissan", "Armada");
                AddMakeAndModel("Nissan", "Frontier Crew Cab");
                AddMakeAndModel("Nissan", "Frontier King Cab");
                AddMakeAndModel("Nissan", "GT-R");
                AddMakeAndModel("Nissan", "Kicks");
                AddMakeAndModel("Nissan", "LEAF");
                AddMakeAndModel("Nissan", "Maxima");
                AddMakeAndModel("Nissan", "Murano");
                AddMakeAndModel("Nissan", "NV1500 Cargo");
                AddMakeAndModel("Nissan", "NV200");
                AddMakeAndModel("Nissan", "NV2500 HD Cargo");
                AddMakeAndModel("Nissan", "NV3500 HD Cargo");
                AddMakeAndModel("Nissan", "NV3500 HD Passenger");
                AddMakeAndModel("Nissan", "Pathfinder");
                AddMakeAndModel("Nissan", "Rogue");
                AddMakeAndModel("Nissan", "Rogue Sport");
                AddMakeAndModel("Nissan", "Sentra");
                AddMakeAndModel("Nissan", "Titan Crew Cab");
                AddMakeAndModel("Nissan", "Titan King Cab");
                AddMakeAndModel("Nissan", "TITAN XD Crew Cab");
                AddMakeAndModel("Nissan", "Versa");
                AddMakeAndModel("Porsche", "718 Boxster");
                AddMakeAndModel("Porsche", "718 Cayman");
                AddMakeAndModel("Porsche", "718 Spyder");
                AddMakeAndModel("Porsche", "911");
                AddMakeAndModel("Porsche", "Cayenne");
                AddMakeAndModel("Porsche", "Cayenne Coupe");
                AddMakeAndModel("Porsche", "Macan");
                AddMakeAndModel("Porsche", "Panamera");
                AddMakeAndModel("Porsche", "Taycan");
                AddMakeAndModel("Ram", "1500 Classic Crew Cab");
                AddMakeAndModel("Ram", "1500 Classic Quad Cab");
                AddMakeAndModel("Ram", "1500 Crew Cab");
                AddMakeAndModel("Ram", "1500 Quad Cab");
                AddMakeAndModel("Ram", "2500 Crew Cab");
                AddMakeAndModel("Ram", "3500 Crew Cab");
                AddMakeAndModel("Ram", "ProMaster Cargo Van");
                AddMakeAndModel("Ram", "ProMaster City");
                AddMakeAndModel("Subaru", "Ascent");
                AddMakeAndModel("Subaru", "BRZ");
                AddMakeAndModel("Subaru", "Crosstrek");
                AddMakeAndModel("Subaru", "Forester");
                AddMakeAndModel("Subaru", "Impreza");
                AddMakeAndModel("Subaru", "Legacy");
                AddMakeAndModel("Subaru", "Outback");
                AddMakeAndModel("Subaru", "WRX");
                AddMakeAndModel("Tesla", "Model 3");
                AddMakeAndModel("Tesla", "Model S");
                AddMakeAndModel("Tesla", "Model X");
                AddMakeAndModel("Tesla", "Model Y");
                AddMakeAndModel("Toyota", "4Runner");
                AddMakeAndModel("Toyota", "86");
                AddMakeAndModel("Toyota", "Avalon");
                AddMakeAndModel("Toyota", "Avalon Hybrid");
                AddMakeAndModel("Toyota", "Camry");
                AddMakeAndModel("Toyota", "Camry Hybrid");
                AddMakeAndModel("Toyota", "C-HR");
                AddMakeAndModel("Toyota", "Corolla");
                AddMakeAndModel("Toyota", "Corolla Hatchback");
                AddMakeAndModel("Toyota", "Corolla Hybrid");
                AddMakeAndModel("Toyota", "GR Supra");
                AddMakeAndModel("Toyota", "Highlander");
                AddMakeAndModel("Toyota", "Highlander Hybrid");
                AddMakeAndModel("Toyota", "Land Cruiser");
                AddMakeAndModel("Toyota", "Mirai");
                AddMakeAndModel("Toyota", "Prius");
                AddMakeAndModel("Toyota", "Prius Prime");
                AddMakeAndModel("Toyota", "RAV4");
                AddMakeAndModel("Toyota", "RAV4 Hybrid");
                AddMakeAndModel("Toyota", "Sequoia");
                AddMakeAndModel("Toyota", "Sienna");
                AddMakeAndModel("Toyota", "Tacoma Access Cab");
                AddMakeAndModel("Toyota", "Tacoma Double Cab");
                AddMakeAndModel("Toyota", "Tundra CrewMax");
                AddMakeAndModel("Toyota", "Tundra Double Cab");
                AddMakeAndModel("Toyota", "Yaris");
                AddMakeAndModel("Toyota", "Yaris Hatchback");
                AddMakeAndModel("Volkswagen", "Arteon");
                AddMakeAndModel("Volkswagen", "Atlas");
                AddMakeAndModel("Volkswagen", "Atlas Cross Sport");
                AddMakeAndModel("Volkswagen", "Golf");
                AddMakeAndModel("Volkswagen", "Golf GTI");
                AddMakeAndModel("Volkswagen", "Jetta");
                AddMakeAndModel("Volkswagen", "Jetta GLI");
                AddMakeAndModel("Volkswagen", "Passat");
                AddMakeAndModel("Volkswagen", "Tiguan");
                AddMakeAndModel("Volvo", "S60");
                AddMakeAndModel("Volvo", "S90");
                AddMakeAndModel("Volvo", "V60");
                AddMakeAndModel("Volvo", "V90");
                AddMakeAndModel("Volvo", "XC40");
                AddMakeAndModel("Volvo", "XC60");
                AddMakeAndModel("Volvo", "XC90");
            }
        }

        private static void AddMakeAndModel(string make, string model)
        {
            if (MakeAndModels.ContainsKey(make))
            {
                MakeAndModels[make].Add(model);
            }
            else
            {
                MakeAndModels.Add(make, new List<string>() { model });
            }
        }
    }
}