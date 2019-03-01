# comp140-gam160-game
Repository for Assignment 1 of COMP140-GAM160
Alex Morgan.

# Project Proposal for a Glove that does everything
## Part A:

### Key Concept: 
The proposed game is a first/third person ‘collect and construct’ game based in a spaceship. The game begins by the spaceship exploding and the goal is to retrieve the debris to rebuild the ship and go home. Successfully completing the game occurs when you have rebuilt the ship and have enough fuel to go back home again. Most of the debris would land on planet J83649, which has a hostile environment with inhabitants trying to capitalise off the parts that landed on the planet below. Most of the fuel would be gathered on this planet. To collect the fuel, the player would need to win a challenge to gather the fuel (and to some extent, fuel tanks), to put on the spaceship and expand the spaceship’s capability in order to survive the journey home.

### Mechanics:
In the game, the player has 360 degree vision. This is needed in order to identify the space debris and subsequently retrieve it successfully. Retrieval helps rebuild a part of the spaceship and this will ultimately help send the player closer to home. Although there is no time limit (i.e. running out of health/oxygen), there are many obstacles that the player must either overcome or avoid. For example; if the player does get hit by an asteroid, then the ship would sustain further damage and the player would need to fix it.

### Controller:
The controller would contain a claw that would detect the items being collected in the game and it would freeze in place. The claw would be similar to one found in a funfair claw machine, with ability to pull out, move the claw and grab items, and would therefore have gyro controls. This feature is mostly included to add realism to the game. Although it is more complex and difficult to achieve than a standard console, it would be more interactive and more dynamic. This controller would also be used to move the player when needed, and a switch would be added to toggle between movement mode and claw mode.
 
## Part B:
### Research:
#### Body Hack:
![Demonstration of the body hack](https://github.com/am215618/comp140-gam160-game/blob/master/bodyhack.jpg)

Figure 1: Demonstration of the body hack. (Shake That Button, 2019)

The body hack is a cinematic karaoke game and with this device, you can copy the poses that are shown on the screen. There is a camera, which records your actions, a projector, which shows the actions needed to copy, and some custom camera vision software, which would be useful on games that require a lot of action from the player. The projector also copies your movement, and it could be used for a scoring system that says how well you moved or how excited you (probably) were. I personally don’t think this would be too useful in my game as the game is fairly open world, and being in a limited space would not help with movement.
 
#### Pirates vs Tentacles:
![A game of Pirates and Tentacles. The colour of the Ship’s mast is respective to the team they are in.](https://github.com/am215618/comp140-gam160-game/blob/master/piratesandtenticles.png)

Figure 2: A game of Pirates and Tentacles. The colour of the Ship’s mast is respective to the team they are in. (Shake That Button, 2019)

I personally like this one, as the ships are compact, and it uses a tablet as its board. It is an interactive board game where the pirates attack each other’s fleet and try to survive by gathering resources. It just uses an iPad and some special pawns as controllers, although they lack any sort of function outside of the game. There seems to be some form of detection that detects a chip that is embedded inside the ship, and it can move around to any hexagonal shape in the board in a certain direction, as long as it is not on an island. While this idea is simplistic, as it has a chip underneath, I would need some more functions to make my game more playable.

#### Laser Cabinet:
![A demonstration of Laser cabinet playing Snake.](https://github.com/am215618/comp140-gam160-game/blob/master/lasercabinet.png)

Figure 3: A demonstration of Laser cabinet playing Snake. (Shake That Button, 2019)

While it is a little bit hard to see, what is essentially there is a laser that can be used to play snake - as well as some mirrors, motors, and an Arduino. It has buttons on the sides to control the snake, which is the green, question mark shaped laser shown on Figure 3, which is on the screen. It even includes sound features, resembling the original snake counterpart. It is simple, but effective and interesting. The board does lack the ability to convey any information outside of the snake itself and about the food that the snake eats to get longer. This limitation is likely due to how complicated the circuitry is inside. While it is impressive, it can be hard to see the laser, particularly on brighter surfaces, and my controller would need to have more functions than that to make it viable for my game.
 
### Design:
![My design for the controller](https://github.com/am215618/comp140-gam160-game/blob/master/controllerdesign.png)

Figure 4: My design for the controller (Author’s own)

My proposed controller would contain a gyro sensor on the back of the glove of the hand to move the claw around in space, and flex sensors on the thumb and fingers to detect the hands moving closer together, hence, making the hand like a claw. The gyro controllers also sense rotation so the player would be able to rotate the pieces to make it fit correctly. The Arduino and Gyro sensor would be on the back of the hand to prevent accidental damage and the fact that the back of the hand has the most room. Alternatively, I would put the microcontrollers on the sleeve of the glove, to make the glove have better aesthetics, and it would be easier to wire up, as the wires would not need to wrap around the fingers and thumb.

### Description of the Controller:
My controller will have a claw like glove to help mostly for picking up space objects in the game, it would detect the players’ movement and if it collides with that object, then the player would either pick it up or it would move away from the player. The controller would need: a glove that the player would wear, a gyro sensor, and some flex sensors attached on the glove to detect the movement.



## References:

Shake That Button. 2019. ‘Body Hack – Shake That Button’. Shake That Button January 2019. Available At: http://shakethatbutton.com/body-hack/ [Accessed 28/01/2019].

Shake That Button. 2019. ‘Body Hack – Pirates vs Tentacles’. Shake That Button January 2019. Available At: http://shakethatbutton.com/pirates-vs-tentacles/ [Accessed 28/01/2019].

Shake That Button. 2019. ‘Body Hack – Laser Cabinet’. Shake That Button January 2019. Available At: https://shakethatbutton.com/laser-cabinet/ [Accessed 28/01/2019]. 

## List of Figures:

Figure 1: Demonstration of the body hack. (Shake That Button, 2019) Available at: http://shakethatbutton.com/body-hack/ [Accessed 28/01/2019].

Figure 2: A game of Pirates and Tentacles. The colour of the Ship’s mast is respective to the team they are in. (Shake That Button, 2019) Available at: http://shakethatbutton.com/pirates-vs-tentacles/ [Accessed 28/01/2019].

Figure 3: A demonstration of Laser cabinet playing Snake. (Shake That Button, 2019) Available at: https://shakethatbutton.com/laser-cabinet/ [Accessed 28/01/2019].

Figure 4: My design for the controller (Author’s own).
