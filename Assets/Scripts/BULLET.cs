/* Team members: Thomas, Yebeen, Andrew
 * Script file that handles bullet collisions and damaging monsters
 */

using Unity.Netcode;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bullet : NetworkBehaviour {
    [SerializeField] private float lifetime = 1.0f;
    [SerializeField] private int maxBounces = 2;
    
    public ulong shooter_ID;
    private int damage = 25;
    private int bounceCount = 0;

    public override void OnNetworkSpawn() {
        if (IsServer) {
            Destroy(gameObject, lifetime);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (!IsServer) {
            return;
        }

        Monster monster = collision.gameObject.GetComponent<Monster>();
        if (monster != null) {
            monster.TakeDamage(damage);
            if (monster.GetHealth() <= 0) {
            }
            GetComponent<NetworkObject>().Despawn();
            return;
        }

        bounceCount++;
        if (bounceCount > maxBounces) {
            GetComponent<NetworkObject>().Despawn();
        }
    }
}
