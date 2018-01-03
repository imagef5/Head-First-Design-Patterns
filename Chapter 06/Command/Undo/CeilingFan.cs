using System;

public class CeilingFan {
	string location = string.Empty;
	int level;
	public const int HIGH = 3;
	public const int MEDIUM = 2;
	public const int LOW = 1;
	public const int OFF = 0;
 
	public CeilingFan(string location) {
		this.location = location;
	}
  
	public void High() {
		// turns the ceiling fan on to high
		level = HIGH;
		Console.WriteLine($"{location} ceiling fan is on high");
 
	} 

	public void Medium() {
		// turns the ceiling fan on to medium
		level = MEDIUM;
		Console.WriteLine($"{location} ceiling fan is on medium");
	}

	public void Low() {
		// turns the ceiling fan on to low
		level = LOW;
		Console.WriteLine($"{location} ceiling fan is on low");
	}
 
	public void Off() {
		// turns the ceiling fan off
		level = OFF;
		Console.WriteLine($"{location} ceiling fan is off");
	}
 
	public int Speed 
    {
		get => level;
	}
}