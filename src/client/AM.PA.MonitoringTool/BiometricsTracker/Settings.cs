﻿// Created by Sebastian Mueller (smueller@ifi.uzh.ch) from the University of Zurich
// Created: 2016-12-16
// 
// Licensed under the MIT License.

using System.Drawing;

namespace BiometricsTracker
{
    internal class Settings
    {
        //Deamon
        internal const string TRACKER_NAME = "Biometrics Tracker";
        internal const string TRACKER_ENEABLED_SETTING = "BiometricsTrackerEnabled";
        internal const string HEARTRATE_TRACKER_ID_SETTING = "HeartrateTrackerID";
        internal const string HEARTRATE_TRACKER_LOCATION_SETTING = "HeartrateTrackerLocation";
        internal const string HEARTRATE_TRACKER_LOCATION_UNKNOWN = "unknown";

        //Database
        internal static readonly string TABLE_NAME = "biometrics";

        //Visualization for week
        internal static readonly int NUMBER_OF_BUCKETS = 5;
        internal static readonly Color START_COLOR = Color.Blue;
        internal static readonly Color END_COLOR = Color.Red;
    }
}