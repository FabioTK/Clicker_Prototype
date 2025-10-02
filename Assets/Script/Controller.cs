using TMPro;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public Data data;


    [SerializeField] private TMP_Text postText;

    private void Start()
    {
        data = new Data();
    }

    private void Update()
    {
        postText.text = "Post: " + data.posts;
    }

    public void GeneratePosts()
    {
        data.posts += 1;
    }
}
