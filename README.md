# GE-2019-20-Assignment
Games Engine Assignment 

# Proposal
For my assignment i plan to make an endless runner game, my runner will be 
acube and it will be able to dodge obstactles as well.
i've done some research on how to create an endless plane, and obstacles

#The assignment
As stated in the proposol, i was going to make an endless runner game and the character was going to be a cube
but i decided to use a sprite of a robot that i found online.
My game is called RoboRun, the robot can run infinatly if he is on the platforms, once the robot falls off the platform 
the game resets and the player has to start over. My game calculates the score and highscore, so if the player dies their high
score will be saved unitl it has been passed. The score is calculated using time, so the longer the player survives the higher the scre will be. In the game there is also coins that the player can pick up, each coin adds 10 to the score once its picked up.

#The player
Robot sprite
Has a rigidbody2D
Has a box collider2D
Has an animator 
Has a player script

#The player script
The script controls how the player behaves, it controls how high the player can jump, how fast he can move, how high he can jump and checks if the player is on the ground. This script creates the controls of the player, if the up arrow is pressed the player will jump and the user can hold the up arrow to jump higher, the user can also double jump by pressing the up arrow again while still in the air.
