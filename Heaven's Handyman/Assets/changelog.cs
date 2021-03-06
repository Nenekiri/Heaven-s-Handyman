using UnityEngine;
using System.Collections;

public class changelog : MonoBehaviour {

	/*This is a script to keep track of all the changes that are made to 
	the project over the course of the semester. 

	9/3/15: 

	started the process of working on my Capstone Project for the Fall 2015 semester. 
	Super excited for this, hopefully that excitement will last. 

	changes made: 
	created a new repository on GitHub that will serve as my way of backing things up 
	and keeping changes made to the project current

	made it so that I can commit changes to the repository from my local computer

	imported 2d Toolkit asset package

	started working on the movement script for the basic representation of the character


	9/13/15: 

	changes made: 

	finished the basic player controls
	added a really nice follow camera
	tested it out myself and am happy with how the test character controls
	had other people test it out, they also seemed happy with the control scheme
	started working on enemy concept art and importing them into the project
	created prefab for the test character so I won't lose the values I set for the movement
	basic enemy art completed for: Bimby the Bomb, Generic Flying Eye Bat, Floating Ram Skull, 
	and Earth Snake. 


	9/14/15: 

	changes made: 

	added another basic enemy concept: Scary Mask
	messed around with putting a circle collider on Bimby the Bomb to see how
	it would look in game. 
	started working on the wall of fire that is supposed to be chasing the player.'
	basic chasing framework for the wall completed. 
	added some logic onto Bimby the Bomb that allows him to kill the player on Collision.


	learned about the headache that is working with unity's 2d collison system
	
	9/15/15: 
	changes made:

	started working on implementing the code for the other enemies

	Floating Ram Skull will eventually shoot fireballs :done
	Earth Snake will eventually burst out of the Earth when player gets near
	Generic Flying Bat will fly from right to left across the screen. 
	Scary Mask will fly from left to right across the screen. 

	added a trail renderer to the player to see how it looked
	added a code snippet that checks for the player's y-position 
	and reloads the level if the player goes below the y-position of the moving wall. 
	added beeping sound to Bimby the Bomb and a distance counter that tracks how
	far he is away from the player and begins playing a beeping sound when the player is 
	close enough and Bimby collides with an object. 

	9/17/15: 

	Bad news and good news

	Bad news: computer's hard drive is probably fried, might have to get a new hard drive or even a new computer. 
	Good News: I backed the project up into a git repository so I can still work on it from the lab computers at school

	Well now that I have that off my chest I can get back to working on this in some capacity

	changes made:
	made a vow to back more things up more frequently
	downloaded the Angels and Demons Free Sound Pack from the Unity Asset Store, going to play around with these tracks for music during the levels. 
	
	added a really cool music randomization script that randomly chooses music based on whether they want Heaven or Hell type musical tracks

	added a basic pause menu that pauses with the press of an escape key and also the start button on a controller. 

	9/18/15: 

	got a bunch of new ideas and a full head of steam so let's get some shit done!

	added a changescene function into the UIManager class so that I can change between scenes in my game easily using the UI

	added a main menu from which you can start the game

	added some toggle controls for toggling the music to be played on the main level

	added some tracks for the main menu

	made the first .exe file for the game. 


    9/21/15: 

    got a new computer and am trying to get everything set back up and working on it. managed to port over my capstone project pretty easily. Should be smooth sailing from here on out. 
    
    changes made: 

    
    9/22/15:
    yeah, jack shit got done yesterday.
    
    changes made: 
    
    added the two breaker switches into the game. need to add the code and scripts that control how they function. 
    
    decided to work on enemy ai instead. 
    
    generic flying bat will now randomly spawn in one direction and then begin traveling in that direction (either left or right)
    
    scary mask now floats around and closes the gap between player and itself
    
    9/23/15:
    
    changes made: 
    
    added a box collider to the floating ram skull enemy which kills the player upon contact. 
    
    added the logic to the breaker class that defines how many times you have to press a button near it to get it to switch on and give you points
    
    successfully switch the off sprite to the on sprite when the conditions have been met. 

    found a glitch that allows you to farm points from one switch. 
    
    fixed the glitch the allows you to farm points from one switch. 

    added a reload function into the UIManager class

    created a ScoreManager class to dynamically display the score for the player on the screen

    tried to desperately get the score to appear on the death screen to no avail, will have to ask about it tommorow. 

    changed logic on enemies to have it take you to the kill screen when they touch you. 

    fixed the problems with the kill screens and now it functions like it is supposed to. 

    9/24/15: 

    changes made: 

    fixed it so that the player's gameobject turns itself off when they collide with something, then the game pauses.
    
    worked on getting the database component of my project working
    
    kept getting a bunch of errors for no apparent reason, will have to ask Coty about it when I see him next. 
    
    added a test sprite for the chasing lava and also for the player character finally!
    
    changed the collider on the player object to a box collider, need to test extensively to see if this will change game feel. 
    
    Had to delete the v2.0 folder I imported in order for unity to not crash on me, will definetely have to look into this further. 
    
    9/28/15: 
    
    changes made: 
    
    made a text box that will pop up when the player collides with the breaker switch. Goes away when the player pushes the interact button enough times
    
    9/29/15:
    
    changes made: 
    
    started working on planning out the procedural generation component, asked Justin Barnyak for help in clearing up a lot of my conceptual issues with the topic .
    
    ported his psuedocode into the project will have to look at translating to actual code at a later time. 
    
    10/4/15:
    
    no visible changes made, however the updates I have are:

    Assembly is a horrible programming language and caused a bit of a delay in working on this project. I hope to remedy this by tommorow and work more closely
    on this project for this upcoming week. 
    
    found a tutorial that goes over different approaches to slowly scrolling a background image in the background. Hopefully will have enough time to watch it tommorow and 
    figure out how to set up background scrolling finally. 
    
    found a couple tutorials on displaying a loading screen. For some reason it takes a long time to load up one of my test levels and I believe the loading screen will at least
    make it known to the player that something is happening in the background. Will also look at that tommorow. 
    
    need to start messing around with procedural generation. I want to have at least a basic system in place for the midterm status report that is coming up very soon. 
    
    10/5/15:
    
    changes made: 
    
    imported a test background for the parallax scrolling effect I am going after for the game. The idea is that the scrolling is dependent on player movement, 
    which is why I attached a script that will move based on the player's relation to the camera. 
    
    made the BaseParallax script to scroll the test background and tested out its functionality. 
    
    fixed the moving wall of lava so that the box collider was the appropriate shape and size. 
    
    tried to work on procedural generation, hit a wall and couldn't figure something out. Will come back to it tommorow. 
    
    worked on research portion of project and began to document the articles and blog posts I have been reading on the subjects of
    procedural generation with prefabs in unity and animating 2d sprites  
    
    10/6/15:
    
    changes made: 
    
    found a script that should provide a solid jumping off point in determining the rest of the procedural generation program. 
    
    modified script to only generate platforms on the y-axis as the player ascends
    
    fixed problem of player character being able to cling to walls, added a 2d physic material that sets his friction to 0. 
    
    made it so that the new Platform Manager script will spawn platforms in a specific range for both x and y values.
    
    added the prefab array so that the script will randomly generate a selected prefab when making the platforms. 

    10/7/15:

    changes made: 

    I honestly can't remember, I did make some progress though. 

    10/9/15: 

    changes made: 

    retooled the platform and enemy generation so that is is a little more fair and varied. 

    fixed the game so that the barriers on the left and right of the play area will refresh as the player moves upward 

    enlarged the background for now until I find a way to make sure that it can not only follow the player but also look as though the background is affected by parallax scrolling

    Added a sign post that tells the player to continously move upwards. 

    made a new build for the game. build number: 1.06

    Yay progress! Going to show it off to people at the showcase tonight and get some more opinions on it. 

    10/13/15:

    changes made:

    tweaked the follow camera's values and the enemy spawner's values to try and get a more balanced feel to it. 

    made a skeleton sprite and figured out how to animate it!

    have a basic understanding of how to animate the sprites in unity using tk2d toolkit tools

    animated the scary mask enemy

    10/19/15: 

    changes made: 

    animated the bomb enemy

    finished animating the two states of the flying bat enemy. 

    added a really cool dramatic camera that pans into the player to first show the lava that is chasing them and than closes in to allow for better visibility.

    10/28/15: 

    other projects keep getting in the way of getting stuff done on this project

    changes made: 

    fixed it so that the player cannot make it past the walls that are on both the left and right sides
    
    added updated visual for the handyman

    started to try and get the database commands to work 

    fixed the problem I had with getting the music to properly randomize itself after selecting a new type after hitting the back button

    Fixed up the main menu screen to look a little better than before: added some sprite buttons and resized the text

    11/2/15: 

    changes made:

    fixed the interation with breaker in that the message only pops up when the player is colliding with the breaker now. 

    added the wing-flapping animation for both the left and right facing sides. 
    
    added the walking animation for both the left and right facing sides when colliding with a platform. 
    
    made some new blocks and imported them into the game. Will work on getting them to function as the new platforms next. 
    
    fixed the bug where the player could pause the game after the death screen was shown to them causing that weird overlay effect.
    
    started to add in the different block types, but ran into a spot of trouble with how the breakers were behaving. 
    
    added the wing flap sound effect to the player so that the wings sound like they are moving now. 
    
    11/3/15: 

    changes made: 

    fixed the bug that I had with not getting the breakers to work on the new platforms

    added a multitude of new platforms that are derived from the newly imported sprites of: stone, tile, vine stone, metal, brick, and cloud. 

    each set of platforms is slightly different and has something that makes it unique

    Charles gave me a set of images which I have used to make the lava move around and animate
    
    fixed the database and the script in unity! Now it will only add the highscore when the player has surpassed the old highscore. 
    
    11/4/15:
    
    changes made: 
    
    added in an explosion sound effect for when bimby collides with the player. 
    
    added in a lava soundtrack that plays louder when the player gets closer to it and plays softer when the player gets farther away
    
    learned about the shadow component in unity today. Started applying that to a bunch of my buttons. 
    
    Also learned about the outline component that can also be used with the unity UI components, but I probably won't be using that one. 
    
    spruced up the Main Menu screen with a bunch of shadow effects. 

    added a basic skybox to the main menu scene to make it look more interesting. 

    Changed the title text to the font Atlantic Mail to make it look fancier. 

    updated the credits with more information for the sound effect and the background

    changed the barrier for each side to be a construction sign and made it work on either side again. 

    adjusted the volume on some music tracks and sound effect tracks so that they were not as loud. 

    11/5/15:

    changes made: 

    fixed the box collider on the animated bat enemy so that it is closer to the enemy sprite than it was before. 

    added proper credit to the youtube video that I ripped the lava soundtrack from. 

    added new sprites for the powerup system that I will be trying to implement. 

    added the swift boots powerup that allows the player to move quicker whilst on platforms for about ten seconds

    also added a visual indicator to the hud to make the player aware of the current powerup that the player has.
    (now added the visual indicator for each of the three power-ups) 

    added the halo powerup that makes it so the player cannot take any damage from the enemies

    added the feather powerup that makes it so the player slows their descent but increases their jump speed 

    added the sound effects for picking up each of the powerups 

    The three power-ups are halo, swift, and feather

    11/6/15:

    changes made: 

    fixed it so that the sound effect for the explosion will not play when the player collides with bimby whilst they have the halo powerup

    added in logic to the enemy spawner to allow it to make more enemies appear on screen the longer that time goes on. 

    11/8/15:

    final stretch man, make it count!: 

    added a button that allows the player to view the high scores on the webpage I have set up for the database

    added a preliminary splash screen image for the new build

    added a new cursor that is the player's hammer and made it of type cursor

    11/9/15:

    fixed the splash screen image to contain the Title of the game

    made a credits menu

    made an options menu

    added two different options in the options menu: one for enabling the dramatic camera and another for enabling the sounds that the lava 
    makes. 

    added more menu's that explain the story, give credits, and go over the controls for the game. 

    




    
     


     


    
     







    
     





	

	



	*/
}
