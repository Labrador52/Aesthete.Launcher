using UnityEngine;

namespace Aestehte.UniLauncher
{
    [AddComponentMenu("UniLauncher/Level Launcher")]
    public class GameLauncher : MonoBehaviour
    {
        [SerializeField]
        private LaunchConfig launchConfig;

        private void Awake()
        {
            if (launchConfig != null)
            {
                
                return;
            }
            Debug.LogWarning("UniLauncher: GameLauncher component is missing LaunchConfig reference. Please assign it in the inspector to enable game launching.", this);
        }
    }
}