# in-class-activities
## Devlogs
### W1
Hello World!
When removing the Camera from the Cat hierarchy, the camera stays in place and does not follow the cat anymore. This is because I took it out of the cat hierarchy so it is not grouped with it and does not move with it. 

https://cjshin4.itch.io/cat-game

### W2
The r, g, and b values are floats because it deals with decimals in the numbers. Strings are for text, integers are for whole numbers, and bools are for true or false. 

The bounce variable is an integer because counting is in whole numbers, and floats deal with decimals which aren't needed, strings deal with text which isn't needed, and bools are for true and false. 

The line of code was broken and not working because there was no semicolon at the end of the line. 


### W3
Table #1
Activity 1.
Question1. One parameter would be an integer for friendship level, and the other would be a bool for the flag if you know the character's secret. The return type would be a string.

Question2. The parameter would be an integer for the sanity level, it would be a void type since there is no return

Question3. The parameter would be float for the time, the return type would be a boolean

Activity 2.
The metaphor to compare classes and components would be about humans, and the classes are each body part, and then you attach them to a human which is a component. 

Activity 3.
The balls get extremely bright when bouncing a lot because the ball speeds up by the multiplier every time it comes into contact with something, and since it is going so fast by the multiplier, it will always meet the minimum speed requirement to increase brightness, so it will get brighter each time it bounces because of the GetColorMultiplier, and this continues.  

### W4
Question1. I added RigidBodies to the SoccerBall and the Cat but not the Goal, since the SoccerBall and Cat both deal with physics and movement and the Goal does not. The only thing I checked the IsTrigger for was the Goal since the ball needs to be able to go through the Goal, not hit it and bounce off.  

Question2. I had to fix many things. I had to learn how to use the OnTriggerEvent method and the Collider variable in the parameters. I also forgot to capitalize the o in "On" so I was confused for a little bit there. I accidentally skipped over the step to stop the cat from rotating by locking the rotation so I dealt with that for a while and had to ask for help. 



## Open-Source Assets


- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 