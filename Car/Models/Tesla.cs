using System;
using System.Text;

public class Tesla : IElectricCar, ICar
{
    public Tesla(string models, string color, int v3)
    {
        this.Model = models;
        this.Color = color;
        this.Battery = v3;
    }

    public int Battery { get; }

    public string Model { get; }

    public string Color { get; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} Batteries")
          .AppendLine(this.Start())
          .Append(this.Stop());
        return sb.ToString();
    }
}