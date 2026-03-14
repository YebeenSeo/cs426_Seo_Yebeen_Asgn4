CS426 Assignment 4

Yebeen Seo  
CS426 Spring 2026

------------------------------------------------------------------------------------------------------------------------------------

[Physics]

1) Player Jump Physics (Rigidbody force + gravity)
- Jump input uses Left Shift key.
- Jump motion is physics-based using Rigidbody force (not a teleport).
- Jump strength was tuned lower so the character performs a short, controlled jump.

2) Bullet Ricochet Collision Physics
- Bullet behavior was updated so bullets can bounce off map obstacles instead of always disappearing immediately.
- A Physics Material was applied to bullet collision to control bounce response.
- Bullet ricochet was tuned to a moderate level for readable gameplay.

This construct explicitly uses collisions and rigidbody physics interactions with world geometry.

------------------------------------------------------------------------------------------------------------------------------------

[Billboard with Texture]

I added a new in-world billboard near the spawn area with a custom texture(png image containg custom letters) message

"Find 7 Cubes in the Correct Order
Each Cube Represents PC Component"
Hint: Rainbow"

This supports the game objective without revealing the full exact sequence.

------------------------------------------------------------------------------------------------------------------------------------

[Lights]

I added two additional stationary lights to support atmosphere and mood

1. Red lights at each cave entrance to express dangerous mood
2. Yellow light at the base area to make a rainbow cube looks more dramatic when it pops up after collecting 7 cubes

------------------------------------------------------------------------------------------------------------------------------------

The game still follows the Computer Architecture theme
- Colored cubes represent PC components.
- The billboard and end-game flow reinforce component-order learning.
- Lighting and physics additions are integrated into gameplay spaces instead of being separate demos.