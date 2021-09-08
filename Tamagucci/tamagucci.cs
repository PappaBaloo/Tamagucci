using System;
using System.Collections.Generic;

public class Tamagucci
{
    private int Hunger = 0;
    private int Boredom = 0;

    private List<string> Words = new List<string>() { "Hi caretaker!" };

    private bool IsAlive = true;

    public Tamagucci()
    {
        // return IsAlive;
    }

    private Random Generator = new Random();

    public string Name;

    public bool GetAlive()
    {
        return IsAlive;
    }

    public void Feed()
    {

    }
}