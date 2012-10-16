﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Fitbit.Models
{
    public class ActivitySummary
    {
        public int ActiveScore{ get; set; }

        public int CaloriesOut
        {
            get;
            set;
        }

        public List<ActivityDistance> Distances
        {
            get;
            set;
        }

        public float FairlyActiveMinutes
        {
            get;
            set;
        }

        public float LightlyActiveMinutes
        {
            get;
            set;
        }

        public float SedentaryMinutes
        {
            get;
            set;
        }

        public float VeryActiveMinutes
        {
            get;
            set;
        }
        public int Steps
        {
            get;
            set;
        }

        public Dictionary<string, float> GetDistancesAsDictionary()
        {
            Dictionary<string, float> activity = new Dictionary<string, float>();
            foreach (ActivityDistance ad in this.Distances)
            {
                activity.Add(ad.Activity, ad.Distance);
            }
            return activity;
        }

    }

}