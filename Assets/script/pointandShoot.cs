using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class pointandShoot : MonoBehaviour
{
    private Vector3 target;
    public GameObject crosshairs;
    public GameObject player;
    public GameObject bulletPrefab;
    public float bulletSpeed = 60.0f;
    public int maxBullets = 5;
    public static int remainingBullets;
    public GameObject parentBullets;

    public TextMeshProUGUI cointext;
    int totalBulletsInStart = 0;




    // Start is called before the first frame update
    void Start()
    {
        remainingBullets = maxBullets;
        nager.Instance.totalbullets = maxBullets;
        /* foreach (Transform child in parentBullets.transform)
         {
             totalBulletsInStart++;
         }

     }*/
    }
    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshairs.transform.position = new Vector2(target.x, target.y);
        Vector3 difference = target - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        player.transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);

        if (Input.GetMouseButtonDown(0) && remainingBullets > 0)
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            fireBullet(direction, rotationZ);
            Shoot();

        }



        void fireBullet(Vector2 direction, float rotationZ)
        {
            GameObject b = Instantiate(bulletPrefab) as GameObject;
            b.transform.position = player.transform.position;
            b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
            b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
        }


    }

    void Shoot()
    {



        remainingBullets--;

        cointext.text = remainingBullets.ToString();
        int curIndex = destoryBullet.instance.currentIndex;
        if (curIndex >= 0 && curIndex < destoryBullet.instance.bullets.Length)
        {
            Destroy(destoryBullet.instance.bullets[destoryBullet.instance.currentIndex]);
            destoryBullet.instance.currentIndex++;
        }


        if (remainingBullets == 0)
        {



            StartCoroutine(Load());

        }
    }

    IEnumerator Load()
    {

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }

    /*{
        int presentBullets = 0;
        foreach (Transform child in parentBullets.transform)
        {
            presentBullets++;
        }
           
        int leftBullets = totalBulletsInStart - presentBullets;
        float percent = (float)((leftBullets / totalBulletsInStart)*100);
        print("Percent is "+percent);
        if(leftBullets>=(totalBulletsInStart - 1))
        {
            PlayerPrefs.SetInt("numberOfStarsActive",3);

        }
        if (leftBullets <4 && leftBullets>2)
        {
            PlayerPrefs.SetInt("numberOfStarsActive", 2);

        }
        if (leftBullets <=2)
        {
            PlayerPrefs.SetInt("numberOfStarsActive", 1);

        }*/
    /*
    int bulletLeft = GameObject.FindGameObjectsWithTag("bullet").Length;
    int bulletSave = bulletLeft - bultCount;
    print("bulletSave " + bulletSave);
    float percentage = float.Parse(bulletSave.ToString()) / float.Parse(bulletLeft.ToString()) * 100f;
    Debug.Log(percentage + "%");
    if (percentage >= 33f && percentage < 66)
    {
        stars[0].SetActive(true);
        stars[1].SetActive(false);
        stars[2].SetActive(false);

    }
    else if (percentage >= 66f && percentage < 70)
    {
        stars[0].SetActive(true);
        stars[1].SetActive(true);
        stars[2].SetActive(false);


    }

    else
    {
        stars[0].SetActive(true);
        stars[1].SetActive(true);
        stars[2].SetActive(true);


    }
    */

}





