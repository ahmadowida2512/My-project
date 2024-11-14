using UnityEngine;
using Assignment18;
public class CharacterTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Character[] arr = { new Soldier(), new Officer("sayah", 80, new Position(0, 0, 0)) };

        foreach (Character character in arr)
        {
            Debug.Log("_@@@@@@-------@@@@@--");
            character.DisplayInfo();
        }
    }
}