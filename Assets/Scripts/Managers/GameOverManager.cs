using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;       

public class GameOverManager : MonoBehaviour
{
    public Text warningText;
    public PlayerHealth playerHealth;
    public float restartDelay = 5f;


    Animator anim;
    float restartTimer;
    bool isDead;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            if(!isDead)
            {
                anim.SetTrigger("GameOver");
                isDead=true;
            }


            restartTimer += Time.deltaTime;

            if (restartTimer >= restartDelay)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    public void ShowWarning(float enemyDistance)
    {
        warningText.text = string.Format("! {0} m",Mathf.RoundToInt(enemyDistance));
        anim.SetTrigger("Warning");
    }
}   