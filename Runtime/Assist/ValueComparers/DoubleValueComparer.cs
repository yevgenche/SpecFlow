﻿using System;

namespace TechTalk.SpecFlow.Assist.ValueComparers
{
    public class DoubleValueComparer : IValueComparer
    {
        public bool CanCompare(object actualValue)
        {
            return actualValue != null && actualValue.GetType() == typeof (double);
        }

        public bool Compare(string expectedValue, object actualValue)
        {
            Double expected;
            if (Double.TryParse(expectedValue, out expected) == false)
                return false;
            return expected == (double) actualValue;
        }
    }
}