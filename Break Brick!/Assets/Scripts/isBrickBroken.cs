
using UnityEngine;
using UnityEngine.SceneManagement;

public class isBrickBroken : MonoBehaviour
{
    public AudioClip brickEffect;
    public AudioClip brokenEffect;
    public Sprite[] brickSprite;
    public static int totalBrick; //toplam tuğla sayımızı static bir değişkende tutuyoruz.
    private int _maxImpact;
    private int _impact;
    private ScoreCalculater scoreScript;
    public GameObject greenBrick;
    public GameObject yellowBrick;
    void Start()
    {
        _maxImpact = brickSprite.Length + 1;
        totalBrick++;
        scoreScript = GameObject.FindObjectOfType<ScoreCalculater> ().GetComponent<ScoreCalculater>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Ball"))
        {   
            
            _impact++;
            if (_impact >= _maxImpact) //oyuna yeni bir top eklenirse diye > kullandık.
            {
                totalBrick--;
                if (totalBrick <= 0) //sahnede tuğla kalmadığında
                {
                    // GameObject.FindObjectOfType<gameButtons>().GetComponent<gameButtons>().NextScene(); //diğer sahneye geç ????????????
                    SceneManager.LoadScene(2);
                }
                AudioSource.PlayClipAtPoint(brokenEffect,transform.position);
                Destroy(this.gameObject);
                scoreScript.scoreIncrease();
            } else
            {
                AudioSource.PlayClipAtPoint(brickEffect,transform.position);
                GetComponent<SpriteRenderer>().sprite = brickSprite[_impact - 1];
                greenBrick.GetComponent<SpriteRenderer>().color = Color.yellow;
                yellowBrick.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
    }
}
