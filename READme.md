# Tumbleweed Dash

## Play the Game
**Unity Play Link**: [\[Your Unity Play URL\]](https://play.unity.com/en/games/73eed6a8-c40a-4b16-86e5-ddee2c51aa55/tumbleweed-dash)

## Game Overview
As a tumbleweed, avoid the cacti

### Controls
Hold your mouse in the direction you want your tumbleweed to go. 

### How to Play
Avoid the obstacles as long as you can to increase the score.

## Base Game Implementation

### Completion Status
- [x] Player movement and controls
- [x] Obstacle spawning system
- [x] Collision detection
- [x] Score system
- [x] Game over state

### Known Bugs
The thrust speed is quite slow on the unity build. I even changed it in the code but it still was sluggish in the actual release. This affects gameplay a bit, since it can be difficult to avoid obstacles, but I have no idea how to fix it at the moment. Everythign else works okay.

### Limitations
All the objects begin in the same place, though the rest of the randomization is fine.

## Extensions Implemented

### 1. Change Your Game Concept (3 points)
**Implementation**: Changed the theme of the game from a spaceship to a desert. Instead of ship vs asteroids, I made it tumbleweed vs. cacti.
**Game Impact**: No significant changes gameplay-wise, though I changed the shape and collider of the main object.
**Technical Details**: Added a desert image as a background, as well as cacti/tumbleweed images attached 
to their respective objects. Recolored the score meter, restart button, and borders to match the theme.

### 2. Swap out Sprites (3 points)
**Implementation**: Changed the player object to a tumbleweed, and the obstacles into cacti. 
**Game Impact**: Once again mostly cosmetic, though the hitbox of the player is changed a little bit due to the collider change. 
**Technical Details**: Changed the player appearance by attaching a tumbleweed image in the "Hierarchy" section. Repeated a similar process for the cacti (obstacles). 
**Known Issues**: I didn't change the hitboxes of the cacti, so they occassionally merge into each other, causing a very trivial visual effect. Nothing other than that. 

### 3. Ambient Particles (4 points)
**Implementation**: Added a "dust" effect to the best of my ability using a particle system.
**Game Impact**: Cosmetic effect that adds to the atmosphere of the game, since it organically matches the theme.
**Technical Details**: Created a new particle system. Changed the shape to a box, expanded it, set the speed extremely low and made the rate about 20 so there wasn't too much flying around. I also changed the color and opacity and made the size random to simulate dust.

### 4. Music/SFX (5 points)
**Implementation**: Set background music and an explosion effect to fit the theme of the game.
**Game Impact**: Makes the game a little more immersive.
**Technical Details**: I had a file of the theme song of the movie "Paris Texas" which fits the theme of the game well. The death effect was a little less intuitive, since I couldn't just use an explosion effect. I found a grass sound which worked well enough, it fit well with the game to me.

## Credits
- Ball cacti - https://www.wildculture.com/article/faces-wild-ball-cactus/1305
- Tumbleweed - https://www.rawpixel.com/search/tumbleweed?page=1&path=1522&sort=curated 
- Music - Paris, Texas theme by Ry Cooder 

## Reflection
**Total Points Claimed**: 78 - 80% (If thrust bug is gonna cost me points) + 15% (extensions) = 93-95%

**Challenges**: Since I mainly use a laptop that doesn't have super high processing potential, I was worried that unity wouldn't be the best to run. The performance wasn't too bad for this game, but it definitely got warm at points especially when compiling the build.

I was also a bit timid with C#, I think I'll get used to it since it is a lot like Python but it was still slightly daunting. Class live coding helps A LOT. 

Time management was a bit hectic, with like three other classes to worry about it could be hard to find time to get through the entire process. I'm glad I got a decent head start on this, it's 9:30 on Thursday as I write this, because I can't imagine doing the tutorial stuff and extensions within less than like a two day timespan. 

**Learning Outcomes**: Overall a nice project, I liked putting my own creative spin on the "sprite flight" concept and such. Unity has been really cool to learn, its potential is insanely powerful. Though learning it so far has been kinda like learning Adobe Premiere Pro due to the really technical and unintuitive presentation of everything. The tutorials help massively. This has definitely prepared me a bit more for the class final, when I'm more left on my own to do things. 
