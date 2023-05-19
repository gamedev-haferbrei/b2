using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gorb : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip ambientSound;
    [SerializeField] AudioClip castSound;
    [SerializeField] AudioClip[] attackCries;
    [SerializeField] GameObject projectilePrefab;

    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = ambientSound;
        audioSource.loop = true;
        audioSource.Play();

        StartCoroutine(AttackLoop());
    }

    IEnumerator AttackLoop()
    {
        while (true)
        {
            audioSource.PlayOneShot(attackCries[Random.Range(0, attackCries.Length)]);

            Shoot(false);
            yield return new WaitForSeconds(0.4f);
            Shoot(true);
            yield return new WaitForSeconds(0.4f);
            Shoot(false);

            yield return new WaitForSeconds(3f);
        }
    }

    void Shoot(bool offset)
    {
        const int count = 6;

        audioSource.PlayOneShot(castSound);
        for (int i = 0; i < count; i++)
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0f, 0f, (i + (offset ? 0.5f : 0f)) * 360f / count));
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + 8, 3 * Mathf.Sin(Time.time), 0);
    }
}
