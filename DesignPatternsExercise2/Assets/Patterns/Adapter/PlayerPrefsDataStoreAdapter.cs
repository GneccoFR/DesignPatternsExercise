﻿using UnityEngine;

namespace Patterns.Adapter
{
    public class PlayerPrefsDataStoreAdapter : DataStore
    {
        public T GetData<T>(string name)
        {
            var json = PlayerPrefs.GetString(name);
            return JsonUtility.FromJson<T>(json);
        }

        public void SetData<T>(T data, string name)
        {
            var json = JsonUtility.ToJson(data);
            PlayerPrefs.SetString(name, json);
            PlayerPrefs.Save();
        }
    }
}
