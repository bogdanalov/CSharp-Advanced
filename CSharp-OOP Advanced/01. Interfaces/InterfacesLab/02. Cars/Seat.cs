﻿
public class Seat : ICar
{
	public Seat(string model, string color)
	{
		this.Model = model;
		this.Color = color;
	}
	public string Model { get; set; }
	public string Color { get; set; }
	public string Start()
	{
		return "";
	}

	public string Stop()
	{
		return "";
	}
	public override string ToString()
	{
		return $" ";
	}
}

