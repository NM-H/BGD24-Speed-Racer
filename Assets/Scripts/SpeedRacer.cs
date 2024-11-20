using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public string carMaker;
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    public class Fuel
    {
        public int fuelLevel;

        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }

    public Fuel carFuel = new Fuel(100);

    void Start()
    {
        print("The racecar is " + carModel + " made by " + carMaker + " with a " + engineType + " engine.");

        CheckWeight();

        if (yearMade <= 2009)
        {
            print(carModel + " was introduced in " + yearMade + ".");

            int carAge = CalculateAge(yearMade);
            print(carModel + " is " + carAge + " years old.");
        }
        else
        {
            print(carModel + " was introduced in the 2010's.");
            print("Max Acceleration: " + maxAcceleration + "m/s2");
        }

        print(CheckCharacteristics());

    }

    void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ConsumeFuel();
                CheckFuelLevel();
            }
        }

        void ConsumeFuel()
        {
            carFuel.fuelLevel = carFuel.fuelLevel - 10;
        }

    void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 70:
                print("fuel level is nearing two-thirds.");
                break;
            case 50:
                print("fuel level is at half amount");
                break;
            case 10:
                print("WARNING! Fuel level is critically low.");
                break;
            default:
                print("Nothing to report.");
                break;
        }
    }

        void CheckWeight()
            {
                if (carWeight < 1500)
                {
                    print(carModel + " weighs less than 1500 kg.");
                }
                else
                {
                    print(carModel + " weighs more than 1500kg.");
                }
            }

            int CalculateAge(int madeYear)
            {
                return (2023 - madeYear);
            }

            string CheckCharacteristics()
            {
                if (isCarTypeSedan)
                {
                    return carModel + " is a Sedan";
                }
                else if (hasFrontEngine)
                {
                    return carModel + " is not a sedan, but it has a front engine.";
                }
                else
                {
                    return carModel + " is neither a sedan nor does it have a front engine.";
                }
            }
        }
  
