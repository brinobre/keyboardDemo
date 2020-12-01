using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class monitor : MonoBehaviour
{

    [SerializeField] private Text keyboardInput;
    List<char> charList = new List<char>();


    void Start()
    {
    }

    private void typeKeys()
    {
        var lenght = charList.Count;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            charList.Add(' ');
        }

        if(Input.GetKeyDown(KeyCode.Backspace) && lenght > 0)
        {
            charList.RemoveAt(lenght - 1);
        }

        for(var i = 0; i < 26; i++)
        {
            if (Input.GetKeyDown(KeyCode.A + i)) charList.Add((char)('a' + i));
            if (Input.GetKeyDown(KeyCode.Comma + i)) charList.Add((char)(',' + i));
        }

        if (lenght != charList.Count) keyboardInput.text = string.Concat(charList);

    }

    // Update is called once per frame
    void Update()
    {

        typeKeys();
    }
}
