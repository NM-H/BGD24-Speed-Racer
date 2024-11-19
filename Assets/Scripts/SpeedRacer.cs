using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";
    int carWeight = 1609;
    int yearMade = 2009;
    float maxAcceleration = 0.98f;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;

    void Start()
    {
        print(carModel + engineType);

        CheckWeight();

        if (yearMade <= 2009)
        {
            print(carModel + " was introduced in" + yearMade + ".");

            int carAge = CalculateAge(yearMade);
            print(carModel + "is" + carAge + "years old.");
        }
        else
        {
            print(carModel + " was introduced in the 2010's.");

            print("Max Acceleration: " + maxAcceleration + "m/s²");

            print(CheckCharacteristics());
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
}