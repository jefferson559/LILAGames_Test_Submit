using UnityEngine;

public class BoardData : MonoBehaviour
{
    public int Size = 16;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}