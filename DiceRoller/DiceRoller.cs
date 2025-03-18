using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller;

public class DiceRoller
{
    public int MaxDieValue { get; set; }
    public int NumberOfRolls { get; set; }

    private readonly static Random RNG = new Random();
    
    public DiceRoller(int maxDieValue = 0, int numberOfRolls = 0) 
    {
        MaxDieValue = maxDieValue;
        NumberOfRolls = numberOfRolls;
    }

    public int RollDice()
    {
        int roll = 0;
        for (int i = 0; i < NumberOfRolls; i++)
        {
            roll += RNG.Next(1, MaxDieValue+1);
        }
        return roll;
    }



}

