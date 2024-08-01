﻿using System.Security.Cryptography.X509Certificates;

public class Hero
{
    
    private static void Main(string[] args)
    {
        int health = 10; 
        Console.WriteLine("Welcome to Hero CS");
        ShowHealth(health, 10);
        Console.Write("damage: ");
        int damage = Convert.ToInt32(Console.ReadLine());
        health -= damage;
        ShowHealth(health, 10);
    }

    static void ShowHealth(int actual, int max) 
    {                   
        
        string healthDisplay = "";
        int healthDispAmount = 10 * actual / max;
        for(int i=0; i < 10; i++) 
        {
            if(i < healthDispAmount) {
                healthDisplay += "0";
            } else {
                healthDisplay += "_";
            }
            
        }
        Console.WriteLine($"\nHP: {actual} / {max}\n{healthDisplay}");
    }

}