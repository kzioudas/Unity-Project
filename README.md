# Collisions Game
The Collisions game is a Unity-based game that displays a cube with a sphere inside it. The game allows the user to create smaller objects and clone them randomly using the space bar. These smaller objects can collide with each other, as well as with the cube and the sphere inside it.

## Development
1. We created the original cube (SC) as an object and placed it inside the game window titled "Collisions" with dimensions 1024x768.
2. We randomly assigned the color of the cube using a script called "cubecolor", and also created transparency of the cube and gave the background white color via project settings.
3. Using RigidBody of project settings, we added collider on the SC so that the objects hit the walls of the cube.
4. We created smaller objects (cubes, spheres, cylinders) as objects which we placed inside a prefabs folder inside Assets.
5. We created a spawner object in which we added a script (RandomObj) that clones one of the elementary objects randomly each time the space bar is pressed. When creating the clone, we give it a random color, size, and direction.
6. To manage the conflicts between the elementary objects and the cube walls, we used the Assets/Prefabs/dircoll script.
7. We created the SPH sphere as an object, giving it a red color through the SPHRed material. We moved the SPH using the keyboard arrow keys and "<<" and ">>" keys. We also added collider on the SPH using RigidBody of project settings so that the objects hit the sphere.
8. For the first-person camera, we created a camera object, in which we added the Assets/FirstPerson script.
9. We also added the ability to load the SPH texture using the Assets/LoadTexture script. This allows the user to activate the texture by pressing "t". The texture file (Texture) can be changed by adding a file in Assets/Resources.
10. Lastly, we implemented sound effects using the Assets/Sound script. When an object collides with another object, a sound effect is played based on the type of object that collided. For example, when the sphere collides with an elementary object, a sound effect with a higher pitch is played compared to when the cube collides with an elementary object.

## Conclusion
Overall, this exercise helped us gain experience in Unity and learn how to implement physics and collisions in a game. We were able to create and control different objects, implement first person camera, add sound effects, and load textures. This exercise was a great opportunity to expand our knowledge and practice our programming skills.
## How to Play
To play the game, simply launch the game and press the space bar to create smaller objects that will collide with the cube and sphere. You can move the sphere using the keyboard arrow keys and "<<" and ">>" keys. Press "t" to activate the SPH texture.
