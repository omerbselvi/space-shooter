using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour {

    GameObject[] characters;
    int index;

    void Start() {
        index = PlayerPrefs.GetInt("SelectedCharacter");
        characters = new GameObject[transform.childCount];
        Debug.Log(transform.childCount);
        for (int i = 0; i < transform.childCount; i++) {
            characters[i] = transform.GetChild(i).gameObject;
            characters[i].SetActive(false);
        }
        if (characters[index]) {
            characters[index].SetActive(true);
        }
    }

    public void toggleLeft() {
        characters[index].SetActive(false);
        if (index == 0) {
            index = transform.childCount - 1;
        } else {
            index--;
        }
        characters[index].SetActive(true);
    }

    public void toggleRight() {
        characters[index].SetActive(false);
        if(index == transform.childCount-1){
            index = 0;
        }
        else{
            index++;
        }
        characters[index].SetActive(true);
    }

    public void selectCharacterAndStart(){
        PlayerPrefs.SetInt("SelectedCharacter", index);
        SceneManager.LoadScene("Main");
    }
    public int getIndex(){
        return index;
    }

}
