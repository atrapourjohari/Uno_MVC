using Service;
using UnityEngine;

namespace DefaultNamespace
{
    public class ModelTest : MonoBehaviour
    {
        void Start()
        {
            GameSetupService gameSetupService = new GameSetupService(4);
            Debug.Log(gameSetupService);
        }
    }
}