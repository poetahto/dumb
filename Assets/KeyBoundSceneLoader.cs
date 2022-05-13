using NaughtyAttributes;
using UnityEngine;

public class KeyBoundSceneLoader : MonoBehaviour
{
    [SerializeField] private KeyCode key;
    [SerializeField, Scene] private string sceneToLoad;
    
    private void Update()
    {
        if (Input.GetKeyDown(key))
            SceneTransitionSystem.Instance.TransitionToScene(sceneToLoad);
    }
}
