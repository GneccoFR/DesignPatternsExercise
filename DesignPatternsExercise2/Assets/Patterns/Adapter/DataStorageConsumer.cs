using UnityEngine;

namespace Patterns.Adapter
{
    public class DataStorageConsumer :MonoBehaviour 
    {
        private DataStore _fileDataStorage;
        [SerializeField] private bool _usePlayerPrefs;


        private void Awake()
        {
            if (_usePlayerPrefs)
                _fileDataStorage = new PlayerPrefsDataStoreAdapter();
            else
                _fileDataStorage = new FileDataStoreAdapter();

            var data = new Data("Data1", 123);
            _fileDataStorage.SetData(data, "Data1");
        }

        private void Start()
        {
            var data =_fileDataStorage.GetData<Data>("Data1");
            Debug.Log(data.Data1);
            Debug.Log(data.Data2);
        }
    }
}
