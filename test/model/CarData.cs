﻿using System;
using static System.String;

namespace TestAutomation.model
{
    public class CarData : IEquatable<CarData>, IComparable<CarData>
    {
        public string Name { get; }
        public int Price { get; }
        public string Year { get; }
        public string Date { get; }

        public CarData(string name, int price, string year, string date)
        {
            Name = name;
            Price = price;
            Year = year;
            Date = date;
        }

        public override string ToString()
        {
            return "Name=" + Name + ", Price=" + Price + ", Year=" + Year + ", Date=" + Date;
        }

        public bool Equals(CarData other)
        {
            if (other == null) return false;
            return Name == other.Name && Price == other.Price && Year == other.Year && Date == other.Date;
        }

        public override bool Equals(object obj) => Equals(obj as CarData);


        public int CompareTo(CarData other)
        {
            return other == null ? 1 : Compare(Name, other.Name, StringComparison.Ordinal);
        }


        public override int GetHashCode() => (Name, Price, Year, Date).GetHashCode();
    }
}