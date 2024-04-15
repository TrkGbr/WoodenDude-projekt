using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    // Referencia a c�lpontra, akit az ellens�g k�vet
    [SerializeField] Transform target;

    // Referencia a NavMeshAgent komponensre a navig�ci�hoz
    NavMeshAgent agent;

    // Az ellens�g sebess�ge patrolling �s chasing k�zben
    public float patrolSpeed = 6f;
    public float chaseSpeed = 7f;

    // Id�intervallum a j�rk�l�shoz
    public float patrolTime = 0f;

    // Referencia a j�t�kos transformj�ra
    private Transform player;

    // V�ltoz�, ami jelzi, hogy az ellens�g �ppen �ld�zi-e a j�t�kost
    private bool isChasing = false;

    // Detekt�l�si radius a j�t�kos azonos�t�s�hoz
    public float detectionRadius = 20f;

    void Start()
    {
        // Inicializ�l�s �s patrolling elind�t�sa
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        // J�t�kos megtal�l�sa a tag alapj�n
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // Patrolling coroutine ind�t�sa
        StartCoroutine(Patrol());
    }

    void Update()
    {

        // Sz�moljuk ki a t�vols�got a j�t�kost�l
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Ellen�rizz�k, hogy a j�t�kos a detekt�l�si radiuson bel�l van-e
        if (distanceToPlayer < detectionRadius)
        {
            // Ha a j�t�kos a detekt�l�si radiusban van, kezdje el a chasinget
            isChasing = true;
            agent.speed = chaseSpeed;
            StopCoroutine(Patrol()); // Meg�ll�tjuk a patrollingot
            agent.SetDestination(player.position); // Be�ll�tjuk a c�lpontot a j�t�kos poz�ci�j�ra
        }
        else if (isChasing)
        {
            // Ha a j�t�kos m�r nincs a detekt�l�si radiusban, t�rjen vissza a patrollinghoz
            isChasing = false;
            StartCoroutine(Patrol()); // �jraind�tjuk a patrollingot

        }
    }

    // Coroutine a patrollingos viselked�shez
    IEnumerator Patrol()
    {
        agent.speed = patrolSpeed;
        while (true)
        {
            // Be�ll�tunk egy v�letlenszer� c�lpontot a jelenlegi poz�ci�nk k�r�l
            Vector3 randomDirection = Random.insideUnitSphere * 50f;
            randomDirection += transform.position;

            // Haszn�ljuk a NavMesh-et, hogy megtal�ljunk egy �rv�nyes poz�ci�t a megadott ter�leten bel�l
            NavMeshHit hit;
            NavMesh.SamplePosition(randomDirection, out hit, 50f, 1 << NavMesh.GetAreaFromName("Walkable"));
            agent.SetDestination(hit.position);

            // V�runk a meghat�rozott patrolling id�re
            yield return new WaitForSeconds(patrolTime);
        }
    }
}