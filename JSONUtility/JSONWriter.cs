using System;
using System.IO;
using UnityEngine;

namespace RimuruDev.JSONUtility
{
    [Serializable]
    public sealed class JSONWriter
    {
        private string path;
        private object obj;

        public void Write(string path, object obj) =>
            File.WriteAllText($"{Application.streamingAssetsPath}/{path}", $"{JsonUtility.ToJson(obj: obj)}");

        public void Write() =>
           File.WriteAllText($"{Application.streamingAssetsPath}/{path}", $"{JsonUtility.ToJson(obj: obj)}");

        public JSONWriter() { }

        public JSONWriter(string pathToJson, object obj)
        {
            this.path = pathToJson;
            this.obj = obj;
        }
    }
}