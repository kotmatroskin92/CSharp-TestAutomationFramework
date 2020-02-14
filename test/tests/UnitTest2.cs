using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.assertions;
using Test.utils;
using TestAutomation.model;

namespace TestAutomation.tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod4()
        {
            List<string> parts = new List<string>();
            parts.Add(DateMapper.ConvertDate("13 января"));
            parts.Add(DateMapper.ConvertDate("10февраля"));
            parts.Add(DateMapper.ConvertDate("вчера"));
            parts.Add(DateMapper.ConvertDate("14.12.20"));
            parts.Add(DateMapper.ConvertDate("20.2.20"));
            parts.Add(DateMapper.ConvertDate("6.2.20"));
            parts.Add(DateMapper.ConvertDate("17.10.19"));
            parts.Add(DateMapper.ConvertDate("17.10.19"));
            parts.Add(DateMapper.ConvertDate("17.10.19"));
            parts.Add(DateMapper.ConvertDate("7.10.19"));
            parts.Add(DateMapper.ConvertDate("13 января"));
            var expectedSorting = parts.OrderByDescending(a => a).ToList();
            foreach (var car in expectedSorting)
            {
                Debug.WriteLine(car);
            }

            Debug.WriteLine("\nsdf");
            var orderedList2 = parts.OrderByDescending(x =>
            {
                DateTime dt;
                DateTime.TryParse(x, out dt);
                return dt;
            });
            foreach (var VARIABLE in orderedList2)
            {
                Debug.WriteLine(VARIABLE);
            }


            // // Write out the parts in the list. This will call the overridden 
            // // ToString method in the Part class.
            // Debug.WriteLine("\nBefore sort:");
            // foreach (Part aPart in parts)
            // {
            //     Debug.WriteLine(aPart);
            // }
            //
            // // Call Sort on the list. This will use the 
            // // default comparer, which is the Compare method 
            // // implemented on Part.
            // parts.Sort();
            //
            // Debug.WriteLine("\nAfter sort by part number:");
            // foreach (Part aPart in parts)
            // {
            //     Debug.WriteLine(aPart);
            // }
            //
            // // This shows calling the Sort(Comparison(T) overload using 
            // // an anonymous method for the Comparison delegate. 
            // // This method treats null as the lesser of two values.
            // parts.Sort(delegate(Part x, Part y)
            // {
            //     if (x.PartName == null && y.PartName == null) return 0;
            //     else if (x.PartName == null) return -1;
            //     else if (y.PartName == null) return 1;
            //     else return x.PartName.CompareTo(y.PartName);
            // });
            //
            // Debug.WriteLine("\nAfter sort by name:");
            // foreach (Part aPart in parts)
            // {
            //     Debug.WriteLine(aPart);
            // }


            //     var actual = new List<CarData>();
            //
            //     actual.Add(new CarData("Abv", 54345345, "123123"));
            //     actual.Add(new CarData("sdfs", 1231, "34534"));
            //     actual.Add(new CarData("Abv", 123, "123123"));
            //     actual.Add(new CarData("New", 1231, "34534"));
            //
            //
            //     var expected = new List<CarData>();
            //     expected.Add(new CarData("Abv", 123, "123123"));
            //     expected.Add(new CarData("sdfs", 1234534531, "34534"));
            //     expected.Add(new CarData("bbv", 123, "123123"));
            //     expected.Add(new CarData("New", 1231, "34534"));
            //     Debug.WriteLine(expected.Count);
            //
            //     // actual.Sort((x, y) => y.Name == null ? 1 : x.Name.CompareTo(y.Name));
            //     // Debug.WriteLine("\nAfter sort by name:");
            //     // foreach (var p in actual)
            //     // {
            //     //     Debug.WriteLine(p);
            //     // }
            //     //
            //     // actual.Sort();
            //     // Debug.WriteLine("\nAfter sort by part number:");
            //     // foreach (var a in actual)
            //     // {
            //     //     Debug.WriteLine(a);
            //     // }
            //
            //     bool isEqual = actual.SequenceEqual(expected, new CarDataComparer());
            //     Debug.WriteLine(isEqual);
            //
            //     string CutCharactersAfterComma(string valueToCut) =>
            //         Regex.Match(valueToCut, @"([^,]+$)")
            //             .Value
            //             .Replace(" ", string.Empty);
            //
            //     Debug.WriteLine(CutCharactersAfterComma(" Минск Минская область, cdfgsdfg область"));
            // }
        }
    }
}