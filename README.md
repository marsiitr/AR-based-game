<h1>AR-Based Game</h1>
<h2>Open Projects 2020</h2>

<p align="center">
<img src="https://github.com/the-brawler/AR-based-game-1/blob/main/Images%20and%20Videos/Main-Menu.jpeg" alt="Main Menu">
<i>Main Menu</i>
</p>

<h2>Abstract</h2>
<p>An AR Based 3D FPS game which uses our device camera to spawn enemies in our real world and we have to kill maximum of them using vintage weapons like bow and arrow, shotgun, axe and revolver. AR Foundation package of Unity 3D has been used to build this game.</p>

<p align="center">
<img src="https://github.com/the-brawler/AR-based-game-1/blob/main/Images%20and%20Videos/Unity-Pic.jpeg" alt="Unity picture">
<i>Unity interface</i>
</p>

<p align="center">
<img src="https://github.com/the-brawler/AR-based-game-1/blob/main/Images%20and%20Videos/Cannibal-Boar-Enemies.jpeg" alt="Enemies">
<i>Enemies (Cannibal and Boar)</i>
</p>

<h2>Motivation</h2>
<p>Augmented Reality is a medium which creates a link between virtual world and real world. Using AR we can interact with virtual objects in our real surroundings using our phone. The game deals with the same in which the enemies like cannibal, boar appear in our real world when viewed from our playing device and we have to kill them using the weapons available and also escape their attacks by moving away from the enemies, which can be done by physically moving back. The player movement in the real world searching for game objects and enemies makes it involving and interesting.</p>
<p>
The idea is to make people familiar with AR in a fun and involving method. The concept of AR are now being widely used for different stuff like, 3D clothes, glasses try on before buying, furniture and other decoratives for home, trying them how it would look in the house using AR before actually buying it. To make people comfortable of this technology, this game takes a small step.</p>

<h2>Software Aspect</h2>
<p>AR works by merging both the coordinates of virtual and real world hence we can spawn the virtual object in real world.</p>
<h3>Raycasting</h3>
<p>
Raycasting is a process of shooting a Ray which is an invisible line (it can be made to be visible too) from a point in space into a specific direction. This Ray when it hits something, for example, an object that is in its path, can then gather information about that object. Raycasting is used everywhere in games, for shooting a bullet in an FPS, TPS or even adventure game. There is also the Physics Ray caster that works against all 3D and 2D objects that have a rigid body or a collider component on them. The rigid body and collider components are used to achieve physics interactions inside Unity.
In our project we used the raycasting feature of AR Foundation to spawn the enemies perfectly on the ground. So we used a indicator instead of the default AR plane which is used to be placed on the detected plane and then based on the coordinates of the indicator we made some changes to x and z coordinates of the indicator so that the object is not exactly placed of the indicator (exactly at the place where camera is looking) but at some random point almost close to coordinates of the indicator. This procedure of spawning is being called for every 6 seconds in Level 1 and for every 5 seconds in Level 2. So, by this we were able to spawn the enemies exactly on the ground.
We used raycasting to detect the enemies while the enemy is being killed such that enemy can be killed only when the ray hits the enemy which is in the real world and that collision coordinate is noted and then it is checked if the name of the object which was collided with the ray is with name given by us to that object and if that is matched then according to the number of shoots the enemy gets dead. So inorder to help the virtual object to be get collided with the ray we use box colliders which we attached to the body of the enemies. The green colour cube around these prefabs is the box collider. 
</p>

<h2>Cost Structure</h2>
<table style="width:100%">
  <tr>
    <th>Software Components</th>
    <th>Cost</th>
  </tr>
  <tr>
    <td>C#</td>
    <td>None(Open-source)</td>
  </tr>
  <tr>
    <td>Unity</td>
    <td>Free for students</br>$1,800 for professional plan</td>
  </tr>
  <tr>
    <td>Asset store</td>
    <td>Depends on different assets</br>Free assets used</td>
  </tr>
</table>

<h2>Applications</h2>
<p>This AR Game makes people familiar and comfortable with the whole technology of Augmented Reality which is useful for following application:
<ol>
<li> 3D try on clothes and accessories </li>
<li> Trying of furnitures, paintings and other decoratives </li>
<li> Classroom education </li>
<li> Medical training </li>
<li> AR in association with VR and robotics can be used for application in various industry sectors like manufacturing product in different sectors </li>
</ol>
</p>

<h2>Limitations</h2>
<p>

1. Real world objects like vertical planes(walls), trees and other things have not been perfectly optimized.
2. Not compatibal for iOS yet.
3. Bugs

</p>

<h2>Future Improvements</h2>
<p>

1. Improve shooting effects 
2. Adding more weapons (like throwable axe) or attacking with fist.
3. Reduce bugs and make the game more stable.
4. Improve the graphics and animations.
5. Customizable graphic settings.
6. Introduce more game objects to make the game look more scary and attractive, creating portals in the game.
7. Improving and making the UI look more attractive.
8. Creating more levels with higher difficulty and more different types of enemies.
9. Creating different modes of game like time bound or limited enemies.
10. The blood effects on camera after getting hit gets removed by shaking the device.
11. Detecting vertical planes which should act like a hindrance for movement of enemies.
12. Other changes in damage value of weapons and enemies to be modified.
13. Make it compatible for iOS too.
14. Weapons to be spawned in the world around us which have to be found to kill the enemies.

</p>

<p align="center">
<img src="https://github.com/the-brawler/AR-based-game-1/blob/main/Images%20and%20Videos/Enemy-Death-Enemy-Chase-Blood.jpeg" alt="Enemies Chase and blood">
<i>Enemies (Chase, death, blood)</i>
</p>

<h2>Team Members</h2>
<p>

1. [Aman Prakash Gaurav](https://github.com/the-brawler)
2. [Harsh Pal](https://github.com/fanatic-hound)
3. [Parameshwar Kaveti](https://github.com/ParameshwarKS)
4. [Tejavath Bhavsingh](https://github.com/Bhav27)

</p>

<h2>Mentors</h2>
<p>

1. [Anfal Ansari](https://github.com/AnfalAnsari) 
2. [Rishika Chandra](https://github.com/chandrarishika14) 

</p>

<h2>References</h2>
<p>

1. [FPS Guide](https://www.youtube.com/watch?v=Sqb-Ue7wpsI&t=17652s)
2. [Animations](https://www.mixamo.com/)
3. [AR Game development courses](https://drive.google.com/drive/folders/1L2oJ8p5TppPiQD7Vw-KtCbtAPYDjI8l1?usp=sharing)
4. [Forum for resolving most of the errors(Unity)](https://www.answers.unity.com/index.html)
5. [AR plane detection](https://www.youtube.com/watch?v=Y2ewpLX6M_s)

</p>