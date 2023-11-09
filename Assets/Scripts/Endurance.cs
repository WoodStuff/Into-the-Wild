using System;
using UnityEngine;

[Serializable]
public class Endurance
{
	[NonSerialized]	public double HP;
	public double MaxHP;
	[NonSerialized]	public double SP;
	public double MaxSP;

	public Endurance(double H, double S)
	{
		HP = MaxHP = H;
		SP = MaxSP = S;
	}
}