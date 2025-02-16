﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace AspNetCore.VersionInfo.Providers
{
    public class EnvironmentVariablesProvider : IInfoProvider
    {
        public string Name => nameof(EnvironmentVariablesProvider);

        public IDictionary<string, string> GetData()
        {
            var dict = new Dictionary<string, string>();

            foreach (DictionaryEntry envVar in Environment.GetEnvironmentVariables())
            {
                dict.Add(envVar.Key.ToString(), envVar.Value.ToString());
            }

            return dict;
        }
    }
}
